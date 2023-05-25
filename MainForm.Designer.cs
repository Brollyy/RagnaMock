namespace Ragnamock
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                components?.Dispose();
                if (wsClient?.Connected ?? false)
                {
                    wsClient?.Stop();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tbAddress = new TextBox();
            groupBox1 = new GroupBox();
            btnToggleConnection = new Button();
            groupBox2 = new GroupBox();
            tbOutput = new TextBox();
            groupBox3 = new GroupBox();
            groupBox10 = new GroupBox();
            cbScoreTrack = new CheckBox();
            nudScoreComboYellow = new NumericUpDown();
            nudScoreComboBlue = new NumericUpDown();
            label13 = new Label();
            btnScoreSend = new Button();
            tbScoreDistance = new TextBox();
            label8 = new Label();
            trackScoreDistance = new TrackBar();
            label12 = new Label();
            nudScoreDelta = new NumericUpDown();
            nudScoreMiss = new NumericUpDown();
            nudScoreHit = new NumericUpDown();
            label11 = new Label();
            label10 = new Label();
            nudScorePerfectPercent = new NumericUpDown();
            label9 = new Label();
            groupBox9 = new GroupBox();
            btnComboLost = new Button();
            label7 = new Label();
            nudLostAtPercent = new NumericUpDown();
            groupBox8 = new GroupBox();
            btnComboYellow = new Button();
            btnComboBlue = new Button();
            groupBox7 = new GroupBox();
            btnEndSong = new Button();
            btnSongInfo = new Button();
            btnStartSong = new Button();
            tbSongArtist = new TextBox();
            tbSongTitle = new TextBox();
            label5 = new Label();
            label4 = new Label();
            groupBox6 = new GroupBox();
            btnBeatMiss = new Button();
            tbBeatMissTime = new TextBox();
            trackBeatMissTime = new TrackBar();
            label6 = new Label();
            groupBox5 = new GroupBox();
            btnBeatHit = new Button();
            tbBeatHitDelta = new TextBox();
            trackBeatHitDelta = new TrackBar();
            label3 = new Label();
            tbBeatHitTime = new TextBox();
            trackBeatHitTime = new TrackBar();
            label2 = new Label();
            groupBox4 = new GroupBox();
            btnDrumHitRight = new Button();
            btnDrumHitLeft = new Button();
            tbDrumHitIntensity = new TextBox();
            trackDrumHitIntensity = new TrackBar();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudScoreComboYellow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudScoreComboBlue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackScoreDistance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudScoreDelta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudScoreMiss).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudScoreHit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudScorePerfectPercent).BeginInit();
            groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudLostAtPercent).BeginInit();
            groupBox8.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBeatMissTime).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBeatHitDelta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBeatHitTime).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackDrumHitIntensity).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 0;
            label1.Text = "Socket address:";
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(100, 16);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(146, 23);
            tbAddress.TabIndex = 1;
            tbAddress.Text = "ws://localhost:8033";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnToggleConnection);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbAddress);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(363, 50);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Connection";
            // 
            // btnToggleConnection
            // 
            btnToggleConnection.Location = new Point(252, 16);
            btnToggleConnection.Name = "btnToggleConnection";
            btnToggleConnection.Size = new Size(105, 23);
            btnToggleConnection.TabIndex = 2;
            btnToggleConnection.Text = "Connect";
            btnToggleConnection.UseVisualStyleBackColor = true;
            btnToggleConnection.Click += btnToggleConnection_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbOutput);
            groupBox2.Location = new Point(12, 57);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(363, 446);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Received";
            // 
            // tbOutput
            // 
            tbOutput.Location = new Point(6, 22);
            tbOutput.Multiline = true;
            tbOutput.Name = "tbOutput";
            tbOutput.ReadOnly = true;
            tbOutput.ScrollBars = ScrollBars.Vertical;
            tbOutput.Size = new Size(351, 418);
            tbOutput.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(groupBox10);
            groupBox3.Controls.Add(groupBox9);
            groupBox3.Controls.Add(groupBox8);
            groupBox3.Controls.Add(groupBox7);
            groupBox3.Controls.Add(groupBox6);
            groupBox3.Controls.Add(groupBox5);
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Location = new Point(381, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(407, 491);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Send";
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(cbScoreTrack);
            groupBox10.Controls.Add(nudScoreComboYellow);
            groupBox10.Controls.Add(nudScoreComboBlue);
            groupBox10.Controls.Add(label13);
            groupBox10.Controls.Add(btnScoreSend);
            groupBox10.Controls.Add(tbScoreDistance);
            groupBox10.Controls.Add(label8);
            groupBox10.Controls.Add(trackScoreDistance);
            groupBox10.Controls.Add(label12);
            groupBox10.Controls.Add(nudScoreDelta);
            groupBox10.Controls.Add(nudScoreMiss);
            groupBox10.Controls.Add(nudScoreHit);
            groupBox10.Controls.Add(label11);
            groupBox10.Controls.Add(label10);
            groupBox10.Controls.Add(nudScorePerfectPercent);
            groupBox10.Controls.Add(label9);
            groupBox10.Location = new Point(157, 307);
            groupBox10.Name = "groupBox10";
            groupBox10.Size = new Size(244, 178);
            groupBox10.TabIndex = 6;
            groupBox10.TabStop = false;
            groupBox10.Text = "Score";
            // 
            // cbScoreTrack
            // 
            cbScoreTrack.AutoSize = true;
            cbScoreTrack.Checked = true;
            cbScoreTrack.CheckState = CheckState.Checked;
            cbScoreTrack.Enabled = false;
            cbScoreTrack.Location = new Point(185, 19);
            cbScoreTrack.Name = "cbScoreTrack";
            cbScoreTrack.Size = new Size(53, 19);
            cbScoreTrack.TabIndex = 18;
            cbScoreTrack.Text = "Track";
            cbScoreTrack.UseVisualStyleBackColor = true;
            cbScoreTrack.CheckedChanged += cbScoreTrack_CheckedChanged;
            // 
            // nudScoreComboYellow
            // 
            nudScoreComboYellow.BackColor = Color.FromArgb(255, 207, 39);
            nudScoreComboYellow.Enabled = false;
            nudScoreComboYellow.Location = new Point(61, 147);
            nudScoreComboYellow.Name = "nudScoreComboYellow";
            nudScoreComboYellow.Size = new Size(46, 23);
            nudScoreComboYellow.TabIndex = 17;
            nudScoreComboYellow.ValueChanged += nudScoreComboYellow_ValueChanged;
            // 
            // nudScoreComboBlue
            // 
            nudScoreComboBlue.BackColor = Color.FromArgb(32, 186, 255);
            nudScoreComboBlue.Enabled = false;
            nudScoreComboBlue.Location = new Point(9, 147);
            nudScoreComboBlue.Name = "nudScoreComboBlue";
            nudScoreComboBlue.Size = new Size(46, 23);
            nudScoreComboBlue.TabIndex = 16;
            nudScoreComboBlue.ValueChanged += nudScoreComboBlue_ValueChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(30, 129);
            label13.Name = "label13";
            label13.Size = new Size(52, 15);
            label13.TabIndex = 15;
            label13.Text = "Combos";
            // 
            // btnScoreSend
            // 
            btnScoreSend.Enabled = false;
            btnScoreSend.Location = new Point(113, 131);
            btnScoreSend.Name = "btnScoreSend";
            btnScoreSend.Size = new Size(125, 41);
            btnScoreSend.TabIndex = 14;
            btnScoreSend.Text = "Send score";
            btnScoreSend.UseVisualStyleBackColor = true;
            btnScoreSend.Click += btnScoreSend_Click;
            // 
            // tbScoreDistance
            // 
            tbScoreDistance.Enabled = false;
            tbScoreDistance.Location = new Point(67, 17);
            tbScoreDistance.Name = "tbScoreDistance";
            tbScoreDistance.ReadOnly = true;
            tbScoreDistance.Size = new Size(112, 23);
            tbScoreDistance.TabIndex = 13;
            tbScoreDistance.Text = "0 m";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 20);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 12;
            label8.Text = "Distance";
            // 
            // trackScoreDistance
            // 
            trackScoreDistance.AutoSize = false;
            trackScoreDistance.Enabled = false;
            trackScoreDistance.LargeChange = 500;
            trackScoreDistance.Location = new Point(6, 42);
            trackScoreDistance.Maximum = 500000;
            trackScoreDistance.Name = "trackScoreDistance";
            trackScoreDistance.Size = new Size(232, 30);
            trackScoreDistance.SmallChange = 100;
            trackScoreDistance.TabIndex = 11;
            trackScoreDistance.ValueChanged += trackScoreDistance_ValueChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 104);
            label12.Name = "label12";
            label12.Size = new Size(87, 15);
            label12.TabIndex = 8;
            label12.Text = "Avg. delta (ms)";
            // 
            // nudScoreDelta
            // 
            nudScoreDelta.Enabled = false;
            nudScoreDelta.Location = new Point(96, 102);
            nudScoreDelta.Maximum = new decimal(new int[] { 75, 0, 0, 0 });
            nudScoreDelta.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nudScoreDelta.Name = "nudScoreDelta";
            nudScoreDelta.Size = new Size(44, 23);
            nudScoreDelta.TabIndex = 7;
            nudScoreDelta.ValueChanged += nudScoreDelta_ValueChanged;
            // 
            // nudScoreMiss
            // 
            nudScoreMiss.Enabled = false;
            nudScoreMiss.Location = new Point(195, 102);
            nudScoreMiss.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nudScoreMiss.Name = "nudScoreMiss";
            nudScoreMiss.Size = new Size(43, 23);
            nudScoreMiss.TabIndex = 6;
            nudScoreMiss.ValueChanged += nudScoreMiss_ValueChanged;
            // 
            // nudScoreHit
            // 
            nudScoreHit.Enabled = false;
            nudScoreHit.Location = new Point(195, 73);
            nudScoreHit.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nudScoreHit.Name = "nudScoreHit";
            nudScoreHit.Size = new Size(43, 23);
            nudScoreHit.TabIndex = 5;
            nudScoreHit.ValueChanged += nudScoreHit_ValueChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(146, 104);
            label11.Name = "label11";
            label11.Size = new Size(42, 15);
            label11.TabIndex = 4;
            label11.Text = "Misses";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(160, 75);
            label10.Name = "label10";
            label10.Size = new Size(28, 15);
            label10.TabIndex = 3;
            label10.Text = "Hits";
            // 
            // nudScorePerfectPercent
            // 
            nudScorePerfectPercent.Enabled = false;
            nudScorePerfectPercent.Location = new Point(96, 73);
            nudScorePerfectPercent.Name = "nudScorePerfectPercent";
            nudScorePerfectPercent.Size = new Size(44, 23);
            nudScorePerfectPercent.TabIndex = 2;
            nudScorePerfectPercent.ValueChanged += nudScorePerfectPercent_ValueChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 75);
            label9.Name = "label9";
            label9.Size = new Size(70, 15);
            label9.TabIndex = 1;
            label9.Text = "Perfects (%)";
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(btnComboLost);
            groupBox9.Controls.Add(label7);
            groupBox9.Controls.Add(nudLostAtPercent);
            groupBox9.Location = new Point(6, 421);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(145, 64);
            groupBox9.TabIndex = 5;
            groupBox9.TabStop = false;
            groupBox9.Text = "ComboLost";
            // 
            // btnComboLost
            // 
            btnComboLost.Enabled = false;
            btnComboLost.Location = new Point(76, 17);
            btnComboLost.Name = "btnComboLost";
            btnComboLost.Size = new Size(64, 36);
            btnComboLost.TabIndex = 2;
            btnComboLost.Text = "Oops!";
            btnComboLost.UseVisualStyleBackColor = true;
            btnComboLost.Click += btnComboLost_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(51, 28);
            label7.Name = "label7";
            label7.Size = new Size(17, 15);
            label7.TabIndex = 1;
            label7.Text = "%";
            // 
            // nudLostAtPercent
            // 
            nudLostAtPercent.Enabled = false;
            nudLostAtPercent.Location = new Point(6, 26);
            nudLostAtPercent.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            nudLostAtPercent.Minimum = new decimal(new int[] { 50, 0, 0, 0 });
            nudLostAtPercent.Name = "nudLostAtPercent";
            nudLostAtPercent.Size = new Size(45, 23);
            nudLostAtPercent.TabIndex = 0;
            nudLostAtPercent.Value = new decimal(new int[] { 99, 0, 0, 0 });
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(btnComboYellow);
            groupBox8.Controls.Add(btnComboBlue);
            groupBox8.Location = new Point(6, 307);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(145, 108);
            groupBox8.TabIndex = 4;
            groupBox8.TabStop = false;
            groupBox8.Text = "ComboTriggered";
            // 
            // btnComboYellow
            // 
            btnComboYellow.BackColor = Color.FromArgb(255, 207, 39);
            btnComboYellow.Enabled = false;
            btnComboYellow.Location = new Point(76, 28);
            btnComboYellow.Name = "btnComboYellow";
            btnComboYellow.Size = new Size(64, 64);
            btnComboYellow.TabIndex = 6;
            btnComboYellow.UseVisualStyleBackColor = false;
            btnComboYellow.Click += btnComboYellow_Click;
            // 
            // btnComboBlue
            // 
            btnComboBlue.BackColor = Color.FromArgb(32, 186, 255);
            btnComboBlue.Enabled = false;
            btnComboBlue.Location = new Point(6, 28);
            btnComboBlue.Name = "btnComboBlue";
            btnComboBlue.Size = new Size(64, 64);
            btnComboBlue.TabIndex = 0;
            btnComboBlue.UseVisualStyleBackColor = false;
            btnComboBlue.Click += btnComboBlue_Click;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(btnEndSong);
            groupBox7.Controls.Add(btnSongInfo);
            groupBox7.Controls.Add(btnStartSong);
            groupBox7.Controls.Add(tbSongArtist);
            groupBox7.Controls.Add(tbSongTitle);
            groupBox7.Controls.Add(label5);
            groupBox7.Controls.Add(label4);
            groupBox7.Location = new Point(6, 22);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(235, 114);
            groupBox7.TabIndex = 3;
            groupBox7.TabStop = false;
            groupBox7.Text = "Song";
            // 
            // btnEndSong
            // 
            btnEndSong.Enabled = false;
            btnEndSong.Location = new Point(87, 78);
            btnEndSong.Name = "btnEndSong";
            btnEndSong.Size = new Size(70, 30);
            btnEndSong.TabIndex = 6;
            btnEndSong.Text = "End Song";
            btnEndSong.UseVisualStyleBackColor = true;
            btnEndSong.Click += btnEndSong_Click;
            // 
            // btnSongInfo
            // 
            btnSongInfo.Enabled = false;
            btnSongInfo.Location = new Point(163, 78);
            btnSongInfo.Name = "btnSongInfo";
            btnSongInfo.Size = new Size(66, 30);
            btnSongInfo.TabIndex = 5;
            btnSongInfo.Text = "Song Info";
            btnSongInfo.UseVisualStyleBackColor = true;
            btnSongInfo.Click += btnSongInfo_Click;
            // 
            // btnStartSong
            // 
            btnStartSong.Enabled = false;
            btnStartSong.Location = new Point(6, 78);
            btnStartSong.Name = "btnStartSong";
            btnStartSong.Size = new Size(75, 30);
            btnStartSong.TabIndex = 4;
            btnStartSong.Text = "Start Song";
            btnStartSong.UseVisualStyleBackColor = true;
            btnStartSong.Click += btnStartSong_Click;
            // 
            // tbSongArtist
            // 
            tbSongArtist.Enabled = false;
            tbSongArtist.Location = new Point(47, 49);
            tbSongArtist.Name = "tbSongArtist";
            tbSongArtist.Size = new Size(182, 23);
            tbSongArtist.TabIndex = 3;
            tbSongArtist.Text = "Ultra Vomit";
            // 
            // tbSongTitle
            // 
            tbSongTitle.Enabled = false;
            tbSongTitle.Location = new Point(47, 22);
            tbSongTitle.Name = "tbSongTitle";
            tbSongTitle.Size = new Size(182, 23);
            tbSongTitle.TabIndex = 2;
            tbSongTitle.Text = "Kammthaar";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 52);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 1;
            label5.Text = "Artist";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 25);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 0;
            label4.Text = "Title";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(btnBeatMiss);
            groupBox6.Controls.Add(tbBeatMissTime);
            groupBox6.Controls.Add(trackBeatMissTime);
            groupBox6.Controls.Add(label6);
            groupBox6.Location = new Point(6, 243);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(395, 58);
            groupBox6.TabIndex = 2;
            groupBox6.TabStop = false;
            groupBox6.Text = "BeatMiss";
            // 
            // btnBeatMiss
            // 
            btnBeatMiss.Enabled = false;
            btnBeatMiss.Location = new Point(317, 22);
            btnBeatMiss.Name = "btnBeatMiss";
            btnBeatMiss.Size = new Size(72, 23);
            btnBeatMiss.TabIndex = 8;
            btnBeatMiss.Text = "Miss";
            btnBeatMiss.UseVisualStyleBackColor = true;
            btnBeatMiss.Click += btnBeatMiss_Click;
            // 
            // tbBeatMissTime
            // 
            tbBeatMissTime.Enabled = false;
            tbBeatMissTime.Location = new Point(263, 22);
            tbBeatMissTime.Name = "tbBeatMissTime";
            tbBeatMissTime.ReadOnly = true;
            tbBeatMissTime.Size = new Size(48, 23);
            tbBeatMissTime.TabIndex = 7;
            tbBeatMissTime.Text = "0";
            // 
            // trackBeatMissTime
            // 
            trackBeatMissTime.AutoSize = false;
            trackBeatMissTime.Enabled = false;
            trackBeatMissTime.LargeChange = 4;
            trackBeatMissTime.Location = new Point(47, 22);
            trackBeatMissTime.Maximum = 400;
            trackBeatMissTime.Name = "trackBeatMissTime";
            trackBeatMissTime.Size = new Size(211, 30);
            trackBeatMissTime.TabIndex = 7;
            trackBeatMissTime.Scroll += trackBeatMissTime_Scroll;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 25);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 1;
            label6.Text = "Time";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnBeatHit);
            groupBox5.Controls.Add(tbBeatHitDelta);
            groupBox5.Controls.Add(trackBeatHitDelta);
            groupBox5.Controls.Add(label3);
            groupBox5.Controls.Add(tbBeatHitTime);
            groupBox5.Controls.Add(trackBeatHitTime);
            groupBox5.Controls.Add(label2);
            groupBox5.Location = new Point(6, 142);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(395, 95);
            groupBox5.TabIndex = 1;
            groupBox5.TabStop = false;
            groupBox5.Text = "BeatHit";
            // 
            // btnBeatHit
            // 
            btnBeatHit.Enabled = false;
            btnBeatHit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBeatHit.Location = new Point(317, 22);
            btnBeatHit.Name = "btnBeatHit";
            btnBeatHit.Size = new Size(72, 57);
            btnBeatHit.TabIndex = 6;
            btnBeatHit.Text = "HIT";
            btnBeatHit.UseVisualStyleBackColor = true;
            btnBeatHit.Click += btnBeatHit_Click;
            // 
            // tbBeatHitDelta
            // 
            tbBeatHitDelta.BackColor = Color.FromArgb(255, 207, 39);
            tbBeatHitDelta.Enabled = false;
            tbBeatHitDelta.Location = new Point(263, 56);
            tbBeatHitDelta.Name = "tbBeatHitDelta";
            tbBeatHitDelta.ReadOnly = true;
            tbBeatHitDelta.Size = new Size(48, 23);
            tbBeatHitDelta.TabIndex = 5;
            tbBeatHitDelta.Text = "0 ms";
            // 
            // trackBeatHitDelta
            // 
            trackBeatHitDelta.AutoSize = false;
            trackBeatHitDelta.Enabled = false;
            trackBeatHitDelta.Location = new Point(46, 55);
            trackBeatHitDelta.Maximum = 75;
            trackBeatHitDelta.Minimum = -100;
            trackBeatHitDelta.Name = "trackBeatHitDelta";
            trackBeatHitDelta.Size = new Size(211, 34);
            trackBeatHitDelta.TabIndex = 4;
            trackBeatHitDelta.Scroll += trackBeatHitDelta_Scroll;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 59);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 3;
            label3.Text = "Delta";
            // 
            // tbBeatHitTime
            // 
            tbBeatHitTime.Enabled = false;
            tbBeatHitTime.Location = new Point(263, 22);
            tbBeatHitTime.Name = "tbBeatHitTime";
            tbBeatHitTime.ReadOnly = true;
            tbBeatHitTime.Size = new Size(48, 23);
            tbBeatHitTime.TabIndex = 2;
            tbBeatHitTime.Text = "0";
            // 
            // trackBeatHitTime
            // 
            trackBeatHitTime.Enabled = false;
            trackBeatHitTime.LargeChange = 4;
            trackBeatHitTime.Location = new Point(46, 22);
            trackBeatHitTime.Maximum = 400;
            trackBeatHitTime.Name = "trackBeatHitTime";
            trackBeatHitTime.Size = new Size(211, 45);
            trackBeatHitTime.TabIndex = 1;
            trackBeatHitTime.Scroll += trackBeatHitTime_Scroll;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 26);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 0;
            label2.Text = "Time";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnDrumHitRight);
            groupBox4.Controls.Add(btnDrumHitLeft);
            groupBox4.Controls.Add(tbDrumHitIntensity);
            groupBox4.Controls.Add(trackDrumHitIntensity);
            groupBox4.Location = new Point(247, 22);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(154, 114);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "DrumHit";
            // 
            // btnDrumHitRight
            // 
            btnDrumHitRight.Enabled = false;
            btnDrumHitRight.Location = new Point(80, 58);
            btnDrumHitRight.Name = "btnDrumHitRight";
            btnDrumHitRight.Size = new Size(68, 50);
            btnDrumHitRight.TabIndex = 3;
            btnDrumHitRight.Text = "Right";
            btnDrumHitRight.UseVisualStyleBackColor = true;
            btnDrumHitRight.Click += btnDrumHitRight_Click;
            // 
            // btnDrumHitLeft
            // 
            btnDrumHitLeft.Enabled = false;
            btnDrumHitLeft.Location = new Point(6, 58);
            btnDrumHitLeft.Name = "btnDrumHitLeft";
            btnDrumHitLeft.Size = new Size(68, 50);
            btnDrumHitLeft.TabIndex = 2;
            btnDrumHitLeft.Text = "Left";
            btnDrumHitLeft.UseVisualStyleBackColor = true;
            btnDrumHitLeft.Click += btnDrumHitLeft_Click;
            // 
            // tbDrumHitIntensity
            // 
            tbDrumHitIntensity.Enabled = false;
            tbDrumHitIntensity.Location = new Point(115, 23);
            tbDrumHitIntensity.Name = "tbDrumHitIntensity";
            tbDrumHitIntensity.ReadOnly = true;
            tbDrumHitIntensity.Size = new Size(33, 23);
            tbDrumHitIntensity.TabIndex = 1;
            tbDrumHitIntensity.Text = "0.75";
            // 
            // trackDrumHitIntensity
            // 
            trackDrumHitIntensity.Enabled = false;
            trackDrumHitIntensity.Location = new Point(6, 22);
            trackDrumHitIntensity.Maximum = 75;
            trackDrumHitIntensity.Minimum = 1;
            trackDrumHitIntensity.Name = "trackDrumHitIntensity";
            trackDrumHitIntensity.Size = new Size(104, 45);
            trackDrumHitIntensity.TabIndex = 0;
            trackDrumHitIntensity.Value = 75;
            trackDrumHitIntensity.Scroll += trackDrumHitIntensity_Scroll;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 515);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "MainForm";
            ShowIcon = false;
            Text = "RagnaMock";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox10.ResumeLayout(false);
            groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudScoreComboYellow).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudScoreComboBlue).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackScoreDistance).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudScoreDelta).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudScoreMiss).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudScoreHit).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudScorePerfectPercent).EndInit();
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudLostAtPercent).EndInit();
            groupBox8.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBeatMissTime).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBeatHitDelta).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBeatHitTime).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackDrumHitIntensity).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox tbAddress;
        private GroupBox groupBox1;
        private Button btnToggleConnection;
        private GroupBox groupBox2;
        private TextBox tbOutput;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private TrackBar trackDrumHitIntensity;
        private TextBox tbDrumHitIntensity;
        private Button btnDrumHitRight;
        private Button btnDrumHitLeft;
        private GroupBox groupBox5;
        private TextBox tbBeatHitTime;
        private TrackBar trackBeatHitTime;
        private Label label2;
        private Label label3;
        private TrackBar trackBeatHitDelta;
        private TextBox tbBeatHitDelta;
        private Button btnBeatHit;
        private GroupBox groupBox6;
        private GroupBox groupBox7;
        private TextBox tbSongArtist;
        private TextBox tbSongTitle;
        private Label label5;
        private Label label4;
        private Button btnStartSong;
        private Button btnEndSong;
        private Button btnSongInfo;
        private TextBox tbBeatMissTime;
        private TrackBar trackBeatMissTime;
        private Label label6;
        private Button btnBeatMiss;
        private GroupBox groupBox8;
        private GroupBox groupBox9;
        private Button btnComboYellow;
        private Button btnComboBlue;
        private GroupBox groupBox10;
        private NumericUpDown nudLostAtPercent;
        private Label label7;
        private Button btnComboLost;
        private Label label12;
        private NumericUpDown nudScoreDelta;
        private NumericUpDown nudScoreMiss;
        private NumericUpDown nudScoreHit;
        private Label label11;
        private Label label10;
        private NumericUpDown nudScorePerfectPercent;
        private Label label9;
        private TrackBar trackScoreDistance;
        private Label label8;
        private Button btnScoreSend;
        private TextBox tbScoreDistance;
        private Label label13;
        private NumericUpDown nudScoreComboYellow;
        private NumericUpDown nudScoreComboBlue;
        private CheckBox cbScoreTrack;
    }
}