using Newtonsoft.Json.Linq;
using System.Globalization;
using System.Text;
using WatsonWebsocket;

namespace Ragnamock
{
    public partial class MainForm : Form
    {
        private WatsonWsClient? wsClient;

        // For keeping score
        private bool suppressScoreTrackDisable;
        private int perfectHits;
        private int overallDelta;

        public MainForm()
        {
            InitializeComponent();
            var logger = new TextBoxLogger(tbOutput);
            Console.SetOut(logger);
            Console.SetError(logger);
        }

        private void btnToggleConnection_Click(object sender, EventArgs e)
        {
            if (wsClient == null)
            {
                try
                {
                    BlockConnection();
                    wsClient = new WatsonWsClient(new Uri(tbAddress.Text));
                    wsClient.ServerConnected += WsClient_ServerConnected;
                    wsClient.ServerDisconnected += WsClient_ServerDisconnected;
                    wsClient.MessageReceived += WsClient_MessageReceived;
                    wsClient.StartAsync().ContinueWith(delegate
                    {
                        if (wsClient.Connected)
                        {
                            Invoke(Connected);
                        }
                        else
                        {
                            wsClient = null;
                            Console.Error.WriteLine("Connection timeout");
                            Invoke(UnblockConnection);
                        }
                    });
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine(ex.ToString());
                    UnblockConnection();
                }

            }
            else
            {
                if (wsClient?.Connected ?? false)
                {
                    wsClient.Stop();
                }
                else
                {
                    Disconnected();
                }
                wsClient = null;
            }
        }

        private void BlockConnection()
        {
            tbAddress.Enabled = false;
            btnToggleConnection.Enabled = false;
            btnToggleConnection.Text = "Disconnect";
        }

        private void Connected()
        {
            btnToggleConnection.Enabled = true;
            ToggleSong();
            ToggleDrumHit();
            ToggleBeatHit();
            ToggleBeatMiss();
            ToggleComboTriggered();
            ToggleComboLost();
            ToggleScore();
        }

        private void UnblockConnection()
        {
            tbAddress.Enabled = true;
            btnToggleConnection.Enabled = true;
            btnToggleConnection.Text = "Connect";
        }

        private void Disconnected()
        {
            UnblockConnection();
            ToggleSong();
            ToggleDrumHit();
            ToggleBeatHit();
            ToggleBeatMiss();
            ToggleComboTriggered();
            ToggleComboLost();
            ToggleScore();
        }

        private void WsClient_MessageReceived(object? sender, MessageReceivedEventArgs e)
        {
            var message = Encoding.UTF8.GetString(e.Data);
            Console.WriteLine($"[{DateTime.Now}]: {message}");
            HandleMessage(message);
        }

        private void HandleMessage(string message)
        {
            var msg = JToken.Parse(message);
            // We should handle current_song event in the same way Ragnarock does.
            if (msg["event"]?.ToString() == "current_song")
            {
                Invoke(SendSongInfos);
            }
        }

        private void WsClient_ServerConnected(object? sender, EventArgs e)
        {
            // For some reason Ragnarock sends this as soon as they connect.
            wsClient?.SendAsync($"{{\"event\":\"ragnarockInitConnection\",\"data\":\"init connection\"}}");
        }

        private void WsClient_ServerDisconnected(object? sender, EventArgs e)
        {
            wsClient = null;
            Invoke(Disconnected);
        }

        class TextBoxLogger : TextWriter
        {
            private readonly TextBox tb;
            public TextBoxLogger(TextBox tb) { this.tb = tb; }
            public override Encoding Encoding { get { return Encoding.UTF8; } }
            public override void Write(char value)
            {
                if (tb.InvokeRequired)
                {
                    tb.Invoke(delegate { Write(value); });
                }
                else
                {
                    tb.AppendText(new string(value, 1));
                }
            }
        }

        #region Song
        private void ToggleSong()
        {
            tbSongTitle.Enabled = !tbSongTitle.Enabled;
            tbSongArtist.Enabled = !tbSongArtist.Enabled;
            btnStartSong.Enabled = !btnStartSong.Enabled;
            btnEndSong.Enabled = !btnEndSong.Enabled;
            btnSongInfo.Enabled = !btnSongInfo.Enabled;
        }

        private void btnStartSong_Click(object sender, EventArgs e)
        {
            wsClient?.SendAsync($"{{\"event\":\"StartSong\",\"data\":{{\"SongName\":\"{tbSongTitle.Text}\",\"SongBand\":\"{tbSongArtist.Text}\"}}}}");
            ResetScoreValues();
        }

        private void btnEndSong_Click(object sender, EventArgs e)
        {
            wsClient?.SendAsync($"{{\"event\":\"EndSong\",\"data\":{{}}}}");
        }

        private void SendSongInfos()
        {
            wsClient?.SendAsync($"{{\"event\":\"SongInfos\",\"data\":{{\"SongName\":\"{tbSongTitle.Text}\",\"SongBand\":\"{tbSongArtist.Text}\"}}}}");
        }

        private void btnSongInfo_Click(object sender, EventArgs e)
        {
            SendSongInfos();
        }
        #endregion

        #region DrumHit
        private void ToggleDrumHit()
        {
            tbDrumHitIntensity.Enabled = !tbDrumHitIntensity.Enabled;
            trackDrumHitIntensity.Enabled = !trackDrumHitIntensity.Enabled;
            btnDrumHitLeft.Enabled = !btnDrumHitLeft.Enabled;
            btnDrumHitRight.Enabled = !btnDrumHitRight.Enabled;
        }

        private void trackDrumHitIntensity_Scroll(object sender, EventArgs e)
        {
            tbDrumHitIntensity.Text = ((double)trackDrumHitIntensity.Value / 100).ToString(CultureInfo.InvariantCulture);
        }

        private void SendDrumHit(string hand)
        {
            wsClient?.SendAsync($"{{\"event\":\"DrumHit\",\"data\":{{\"hand\":\"{hand}\",\"intensity\":{tbDrumHitIntensity.Text}}}}}");
        }

        private void btnDrumHitLeft_Click(object sender, EventArgs e)
        {
            SendDrumHit("Left");
        }

        private void btnDrumHitRight_Click(object sender, EventArgs e)
        {
            SendDrumHit("Right");
        }
        #endregion

        #region BeatHit
        private void ToggleBeatHit()
        {
            tbBeatHitTime.Enabled = !tbBeatHitTime.Enabled;
            trackBeatHitTime.Enabled = !trackBeatHitTime.Enabled;
            tbBeatHitDelta.Enabled = !tbBeatHitDelta.Enabled;
            trackBeatHitDelta.Enabled = !trackBeatHitDelta.Enabled;
            btnBeatHit.Enabled = !btnBeatHit.Enabled;
        }

        private void trackBeatHitTime_Scroll(object sender, EventArgs e)
        {
            tbBeatHitTime.Text = ((double)trackBeatHitTime.Value / 4).ToString(CultureInfo.InvariantCulture);
        }

        private void trackBeatHitDelta_Scroll(object sender, EventArgs e)
        {
            tbBeatHitDelta.Text = $"{trackBeatHitDelta.Value} ms";
            tbBeatHitDelta.BackColor = Math.Abs(trackBeatHitDelta.Value) <= 15 ? Color.FromArgb(255, 207, 39) : DefaultBackColor;
        }

        private void btnBeatHit_Click(object sender, EventArgs e)
        {
            var delta = ((double)trackBeatHitDelta.Value / 1000).ToString(CultureInfo.InvariantCulture);
            wsClient?.SendAsync($"{{\"event\":\"BeatHit\",\"data\":{{\"time\":\"{tbBeatHitTime.Text}\",\"delta\":\"{delta}\"}}}}");
            if (cbScoreTrack.Checked)
            {
                suppressScoreTrackDisable = true;
                nudScoreHit.Value += 1;
                trackScoreDistance.Value += 500;
                if (Math.Abs(trackBeatHitDelta.Value) <= 15)
                {
                    trackScoreDistance.Value += 300;
                    perfectHits++;
                }
                overallDelta += trackBeatHitDelta.Value;
                nudScorePerfectPercent.Value = 100 * perfectHits / (nudScoreHit.Value + nudScoreMiss.Value);
                nudScoreDelta.Value = overallDelta / nudScoreHit.Value;
                suppressScoreTrackDisable = false;
            }
        }
        #endregion

        #region BeatMiss
        private void ToggleBeatMiss()
        {
            trackBeatMissTime.Enabled = !trackBeatMissTime.Enabled;
            tbBeatMissTime.Enabled = !tbBeatMissTime.Enabled;
            btnBeatMiss.Enabled = !btnBeatMiss.Enabled;
        }

        private void trackBeatMissTime_Scroll(object sender, EventArgs e)
        {
            tbBeatMissTime.Text = ((double)trackBeatMissTime.Value / 4).ToString(CultureInfo.InvariantCulture);
        }

        private void btnBeatMiss_Click(object sender, EventArgs e)
        {
            wsClient?.SendAsync($"{{\"event\":\"BeatMiss\",\"data\":{{\"time\":\"{tbBeatMissTime.Text}\",\"delta\":\"0.0\"}}}}");
            if (cbScoreTrack.Checked)
            {
                suppressScoreTrackDisable = true;
                nudScoreMiss.Value += 1;
                trackScoreDistance.Value += 200;
                nudScorePerfectPercent.Value = 100 * perfectHits / (nudScoreHit.Value + nudScoreMiss.Value);
                suppressScoreTrackDisable = false;
            }
        }
        #endregion

        #region ComboTriggered
        private void ToggleComboTriggered()
        {
            btnComboBlue.Enabled = !btnComboBlue.Enabled;
            btnComboYellow.Enabled = !btnComboYellow.Enabled;
        }

        private void SendComboTriggered(int level)
        {
            wsClient?.SendAsync($"{{\"event\":\"ComboTriggered\",\"data\":{{\"level\":{level}}}}}");
            if (cbScoreTrack.Checked)
            {
                suppressScoreTrackDisable = true;
                if (level == 1)
                {
                    nudScoreComboBlue.Value += 1;
                    trackScoreDistance.Value += 1000;
                }
                else
                {
                    nudScoreComboYellow.Value += 1;
                    trackScoreDistance.Value += 4000;
                }
                suppressScoreTrackDisable = false;
            }
        }

        private void btnComboBlue_Click(object sender, EventArgs e)
        {
            SendComboTriggered(1);
        }

        private void btnComboYellow_Click(object sender, EventArgs e)
        {
            SendComboTriggered(2);
        }
        #endregion

        #region ComboLost
        private void ToggleComboLost()
        {
            nudLostAtPercent.Enabled = !nudLostAtPercent.Enabled;
            btnComboLost.Enabled = !btnComboLost.Enabled;
        }

        private void btnComboLost_Click(object sender, EventArgs e)
        {
            var lostAt = ((double)nudLostAtPercent.Value / 100).ToString(CultureInfo.InvariantCulture);
            wsClient?.SendAsync($"{{\"event\":\"ComboLost\",\"data\":{{\"lostAt\":\"{lostAt}\"}}}}");
        }
        #endregion

        #region Score
        private void ToggleScore()
        {
            tbScoreDistance.Enabled = !tbScoreDistance.Enabled;
            trackScoreDistance.Enabled = !trackScoreDistance.Enabled;
            cbScoreTrack.Enabled = !cbScoreTrack.Enabled;
            nudScorePerfectPercent.Enabled = !nudScorePerfectPercent.Enabled;
            nudScoreDelta.Enabled = !nudScoreDelta.Enabled;
            nudScoreHit.Enabled = !nudScoreHit.Enabled;
            nudScoreMiss.Enabled = !nudScoreMiss.Enabled;
            nudScoreComboBlue.Enabled = !nudScoreComboBlue.Enabled;
            nudScoreComboYellow.Enabled = !nudScoreComboYellow.Enabled;
            btnScoreSend.Enabled = !btnScoreSend.Enabled;
        }

        private void trackScoreDistance_ValueChanged(object sender, EventArgs e)
        {
            tbScoreDistance.Text = $"{((double)trackScoreDistance.Value / 100).ToString(CultureInfo.InvariantCulture)} m";
            if (!suppressScoreTrackDisable)
            {
                cbScoreTrack.Checked = false;
            }
        }

        private void nudScorePerfectPercent_ValueChanged(object sender, EventArgs e)
        {
            if (!suppressScoreTrackDisable)
            {
                cbScoreTrack.Checked = false;
            }
        }

        private void nudScoreDelta_ValueChanged(object sender, EventArgs e)
        {
            if (!suppressScoreTrackDisable)
            {
                cbScoreTrack.Checked = false;
            }
        }

        private void nudScoreHit_ValueChanged(object sender, EventArgs e)
        {
            if (!suppressScoreTrackDisable)
            {
                cbScoreTrack.Checked = false;
            }
        }

        private void nudScoreMiss_ValueChanged(object sender, EventArgs e)
        {
            if (!suppressScoreTrackDisable)
            {
                cbScoreTrack.Checked = false;
            }
        }

        private void nudScoreComboBlue_ValueChanged(object sender, EventArgs e)
        {
            if (!suppressScoreTrackDisable)
            {
                cbScoreTrack.Checked = false;
            }
        }

        private void nudScoreComboYellow_ValueChanged(object sender, EventArgs e)
        {
            if (!suppressScoreTrackDisable)
            {
                cbScoreTrack.Checked = false;
            }
        }

        private void ResetScoreValues()
        {
            suppressScoreTrackDisable = true;
            perfectHits = 0;
            overallDelta = 0;
            trackScoreDistance.Value = 0;
            nudScorePerfectPercent.Value = 0;
            nudScoreDelta.Value = 0;
            nudScoreHit.Value = 0;
            nudScoreMiss.Value = 0;
            nudScoreComboBlue.Value = 0;
            nudScoreComboYellow.Value = 0;
            suppressScoreTrackDisable = false;
        }

        private void cbScoreTrack_CheckedChanged(object sender, EventArgs e)
        {
            if (cbScoreTrack.Checked)
            {
                perfectHits = (int)(nudScorePerfectPercent.Value * (nudScoreHit.Value + nudScoreMiss.Value) / 100);
                overallDelta = (int)(nudScoreDelta.Value * nudScoreHit.Value);
            }
        }

        private void btnScoreSend_Click(object sender, EventArgs e)
        {
            var hitPercentage = (nudScoreHit.Value + nudScoreMiss.Value > 0) ? (int)decimal.Round(100 * nudScoreHit.Value / (nudScoreHit.Value + nudScoreMiss.Value)) : 0;
            wsClient?.SendAsync($"{{\"event\":\"Score\",\"data\":{{\"stats\":{{\"PercentageOfPerfects\":{(int)decimal.Round(nudScorePerfectPercent.Value)},\"ComboBlue\":{(int)nudScoreComboBlue.Value},\"ComboYellow\":{(int)nudScoreComboYellow.Value},\"Missed\":{(int)nudScoreMiss.Value},\"Hit\":{(int)nudScoreHit.Value},\"HitPercentage\":{hitPercentage},\"HitDeltaAverage\":{(int)decimal.Round(nudScoreDelta.Value)}}},\"extra\":{{}},\"distance\":\"{((double)trackScoreDistance.Value / 100).ToString(CultureInfo.InvariantCulture)}\"}}}}");
        }
        #endregion
    }
}