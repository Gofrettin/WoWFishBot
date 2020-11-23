namespace WoWFishBot
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.Inp_SleepChance = new System.Windows.Forms.NumericUpDown();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnCaptureAll = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Inp_BobberColor = new System.Windows.Forms.TextBox();
            this.Inp_TopLeft = new System.Windows.Forms.TextBox();
            this.Inp_BottomRight = new System.Windows.Forms.TextBox();
            this.Inp_LureSkill = new System.Windows.Forms.TextBox();
            this.Inp_FishSkill = new System.Windows.Forms.TextBox();
            this.Btn_CaptureTopLeft = new System.Windows.Forms.Button();
            this.Btn_CaptureBottomRight = new System.Windows.Forms.Button();
            this.Btn_CaptureLureSkill = new System.Windows.Forms.Button();
            this.Btn_CaptureFishSkill = new System.Windows.Forms.Button();
            this.Btn_CaptureBobberColor = new System.Windows.Forms.Button();
            this.tb_Log = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.Btn_UpdateScreenshot = new System.Windows.Forms.Button();
            this.Btn_ResetPeakVolume = new System.Windows.Forms.Button();
            this.Inp_TriggerVolume = new System.Windows.Forms.TrackBar();
            this.Lb_PickedVolume = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PeakVolumeLable = new System.Windows.Forms.Label();
            this.Btn_Run = new System.Windows.Forms.Button();
            this.Btn_SaveConfig = new System.Windows.Forms.Button();
            this.Btn_ImportConfig = new System.Windows.Forms.Button();
            this.Btn_Stop = new System.Windows.Forms.Button();
            this.Listbox_CurrentStep = new System.Windows.Forms.ListBox();
            this.CurrentVolumeBar = new System.Windows.Forms.ProgressBar();
            this.CurrentVolumeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Inp_SleepChance)).BeginInit();
            this.StatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inp_TriggerVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sleep Chance %";
            // 
            // Inp_SleepChance
            // 
            this.Inp_SleepChance.DecimalPlaces = 1;
            this.Inp_SleepChance.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Inp_SleepChance.Location = new System.Drawing.Point(160, 168);
            this.Inp_SleepChance.Name = "Inp_SleepChance";
            this.Inp_SleepChance.Size = new System.Drawing.Size(57, 20);
            this.Inp_SleepChance.TabIndex = 2;
            this.Inp_SleepChance.ValueChanged += new System.EventHandler(this.Inp_SleepChance_ValueChanged);
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 446);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(605, 22);
            this.StatusStrip.TabIndex = 8;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(39, 17);
            this.StatusLabel.Text = "Status";
            // 
            // btnCaptureAll
            // 
            this.btnCaptureAll.Location = new System.Drawing.Point(9, 12);
            this.btnCaptureAll.Name = "btnCaptureAll";
            this.btnCaptureAll.Size = new System.Drawing.Size(205, 23);
            this.btnCaptureAll.TabIndex = 9;
            this.btnCaptureAll.Text = "Capture All";
            this.btnCaptureAll.UseVisualStyleBackColor = true;
            this.btnCaptureAll.Click += new System.EventHandler(this.Btn_CaptureAll_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Top Left";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Bottom Right";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Lure Skill";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Fish Skill";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 148);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Bobber Color";
            // 
            // Inp_BobberColor
            // 
            this.Inp_BobberColor.Enabled = false;
            this.Inp_BobberColor.Location = new System.Drawing.Point(96, 145);
            this.Inp_BobberColor.Name = "Inp_BobberColor";
            this.Inp_BobberColor.Size = new System.Drawing.Size(102, 20);
            this.Inp_BobberColor.TabIndex = 27;
            // 
            // Inp_TopLeft
            // 
            this.Inp_TopLeft.Enabled = false;
            this.Inp_TopLeft.Location = new System.Drawing.Point(96, 41);
            this.Inp_TopLeft.Name = "Inp_TopLeft";
            this.Inp_TopLeft.Size = new System.Drawing.Size(102, 20);
            this.Inp_TopLeft.TabIndex = 28;
            // 
            // Inp_BottomRight
            // 
            this.Inp_BottomRight.Enabled = false;
            this.Inp_BottomRight.Location = new System.Drawing.Point(96, 67);
            this.Inp_BottomRight.Name = "Inp_BottomRight";
            this.Inp_BottomRight.Size = new System.Drawing.Size(102, 20);
            this.Inp_BottomRight.TabIndex = 29;
            // 
            // Inp_LureSkill
            // 
            this.Inp_LureSkill.Enabled = false;
            this.Inp_LureSkill.Location = new System.Drawing.Point(96, 93);
            this.Inp_LureSkill.Name = "Inp_LureSkill";
            this.Inp_LureSkill.Size = new System.Drawing.Size(102, 20);
            this.Inp_LureSkill.TabIndex = 30;
            // 
            // Inp_FishSkill
            // 
            this.Inp_FishSkill.Enabled = false;
            this.Inp_FishSkill.Location = new System.Drawing.Point(96, 119);
            this.Inp_FishSkill.Name = "Inp_FishSkill";
            this.Inp_FishSkill.Size = new System.Drawing.Size(102, 20);
            this.Inp_FishSkill.TabIndex = 31;
            // 
            // Btn_CaptureTopLeft
            // 
            this.Btn_CaptureTopLeft.Location = new System.Drawing.Point(200, 41);
            this.Btn_CaptureTopLeft.Name = "Btn_CaptureTopLeft";
            this.Btn_CaptureTopLeft.Size = new System.Drawing.Size(17, 23);
            this.Btn_CaptureTopLeft.TabIndex = 32;
            this.Btn_CaptureTopLeft.Text = ">";
            this.Btn_CaptureTopLeft.UseVisualStyleBackColor = true;
            this.Btn_CaptureTopLeft.Click += new System.EventHandler(this.Btn_CaptureTopLeft_Click);
            // 
            // Btn_CaptureBottomRight
            // 
            this.Btn_CaptureBottomRight.Location = new System.Drawing.Point(200, 65);
            this.Btn_CaptureBottomRight.Name = "Btn_CaptureBottomRight";
            this.Btn_CaptureBottomRight.Size = new System.Drawing.Size(17, 23);
            this.Btn_CaptureBottomRight.TabIndex = 33;
            this.Btn_CaptureBottomRight.Text = ">";
            this.Btn_CaptureBottomRight.UseVisualStyleBackColor = true;
            this.Btn_CaptureBottomRight.Click += new System.EventHandler(this.Btn_CaptureBottomRight_Click);
            // 
            // Btn_CaptureLureSkill
            // 
            this.Btn_CaptureLureSkill.Location = new System.Drawing.Point(200, 91);
            this.Btn_CaptureLureSkill.Name = "Btn_CaptureLureSkill";
            this.Btn_CaptureLureSkill.Size = new System.Drawing.Size(17, 23);
            this.Btn_CaptureLureSkill.TabIndex = 34;
            this.Btn_CaptureLureSkill.Text = ">";
            this.Btn_CaptureLureSkill.UseVisualStyleBackColor = true;
            this.Btn_CaptureLureSkill.Click += new System.EventHandler(this.Btn_CaptureLureSkill_Click);
            // 
            // Btn_CaptureFishSkill
            // 
            this.Btn_CaptureFishSkill.Location = new System.Drawing.Point(200, 117);
            this.Btn_CaptureFishSkill.Name = "Btn_CaptureFishSkill";
            this.Btn_CaptureFishSkill.Size = new System.Drawing.Size(17, 23);
            this.Btn_CaptureFishSkill.TabIndex = 35;
            this.Btn_CaptureFishSkill.Text = ">";
            this.Btn_CaptureFishSkill.UseVisualStyleBackColor = true;
            this.Btn_CaptureFishSkill.Click += new System.EventHandler(this.Btn_CaptureFishSkill_Click);
            // 
            // Btn_CaptureBobberColor
            // 
            this.Btn_CaptureBobberColor.Location = new System.Drawing.Point(200, 143);
            this.Btn_CaptureBobberColor.Name = "Btn_CaptureBobberColor";
            this.Btn_CaptureBobberColor.Size = new System.Drawing.Size(17, 23);
            this.Btn_CaptureBobberColor.TabIndex = 36;
            this.Btn_CaptureBobberColor.Text = ">";
            this.Btn_CaptureBobberColor.UseVisualStyleBackColor = true;
            this.Btn_CaptureBobberColor.Click += new System.EventHandler(this.Btn_CaptureBobberColor_Click);
            // 
            // tb_Log
            // 
            this.tb_Log.Enabled = false;
            this.tb_Log.Location = new System.Drawing.Point(12, 301);
            this.tb_Log.Name = "tb_Log";
            this.tb_Log.Size = new System.Drawing.Size(462, 108);
            this.tb_Log.TabIndex = 37;
            this.tb_Log.Text = "";
            this.tb_Log.WordWrap = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Peak Volume";
            // 
            // PictureBox
            // 
            this.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox.Location = new System.Drawing.Point(223, 12);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(201, 154);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 40;
            this.PictureBox.TabStop = false;
            // 
            // Btn_UpdateScreenshot
            // 
            this.Btn_UpdateScreenshot.Location = new System.Drawing.Point(395, 143);
            this.Btn_UpdateScreenshot.Name = "Btn_UpdateScreenshot";
            this.Btn_UpdateScreenshot.Size = new System.Drawing.Size(29, 23);
            this.Btn_UpdateScreenshot.TabIndex = 41;
            this.Btn_UpdateScreenshot.Text = ">";
            this.Btn_UpdateScreenshot.UseVisualStyleBackColor = true;
            this.Btn_UpdateScreenshot.Click += new System.EventHandler(this.Btn_UpdateScreenshot_Click);
            // 
            // Btn_ResetPeakVolume
            // 
            this.Btn_ResetPeakVolume.Location = new System.Drawing.Point(148, 246);
            this.Btn_ResetPeakVolume.Name = "Btn_ResetPeakVolume";
            this.Btn_ResetPeakVolume.Size = new System.Drawing.Size(66, 23);
            this.Btn_ResetPeakVolume.TabIndex = 42;
            this.Btn_ResetPeakVolume.Text = "Reset";
            this.Btn_ResetPeakVolume.UseVisualStyleBackColor = true;
            this.Btn_ResetPeakVolume.Click += new System.EventHandler(this.Btn_ResetPeakVolume_Click);
            // 
            // Inp_TriggerVolume
            // 
            this.Inp_TriggerVolume.Location = new System.Drawing.Point(96, 201);
            this.Inp_TriggerVolume.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Inp_TriggerVolume.Maximum = 100;
            this.Inp_TriggerVolume.Name = "Inp_TriggerVolume";
            this.Inp_TriggerVolume.Size = new System.Drawing.Size(121, 45);
            this.Inp_TriggerVolume.TabIndex = 43;
            this.Inp_TriggerVolume.ValueChanged += new System.EventHandler(this.VolumeBar_ValueChanged);
            // 
            // Lb_PickedVolume
            // 
            this.Lb_PickedVolume.AutoSize = true;
            this.Lb_PickedVolume.Location = new System.Drawing.Point(39, 214);
            this.Lb_PickedVolume.Name = "Lb_PickedVolume";
            this.Lb_PickedVolume.Size = new System.Drawing.Size(21, 13);
            this.Lb_PickedVolume.TabIndex = 44;
            this.Lb_PickedVolume.Text = "0%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Trigger Volume";
            // 
            // PeakVolumeLable
            // 
            this.PeakVolumeLable.AutoSize = true;
            this.PeakVolumeLable.Location = new System.Drawing.Point(93, 251);
            this.PeakVolumeLable.Name = "PeakVolumeLable";
            this.PeakVolumeLable.Size = new System.Drawing.Size(21, 13);
            this.PeakVolumeLable.TabIndex = 46;
            this.PeakVolumeLable.Text = "0%";
            // 
            // Btn_Run
            // 
            this.Btn_Run.Location = new System.Drawing.Point(341, 172);
            this.Btn_Run.Name = "Btn_Run";
            this.Btn_Run.Size = new System.Drawing.Size(108, 23);
            this.Btn_Run.TabIndex = 47;
            this.Btn_Run.Text = "Run";
            this.Btn_Run.UseVisualStyleBackColor = true;
            this.Btn_Run.Click += new System.EventHandler(this.Btn_Run_Click);
            // 
            // Btn_SaveConfig
            // 
            this.Btn_SaveConfig.Location = new System.Drawing.Point(109, 272);
            this.Btn_SaveConfig.Name = "Btn_SaveConfig";
            this.Btn_SaveConfig.Size = new System.Drawing.Size(108, 23);
            this.Btn_SaveConfig.TabIndex = 48;
            this.Btn_SaveConfig.Text = "Save";
            this.Btn_SaveConfig.UseVisualStyleBackColor = true;
            this.Btn_SaveConfig.Click += new System.EventHandler(this.Btn_SaveConfig_Click);
            // 
            // Btn_ImportConfig
            // 
            this.Btn_ImportConfig.Location = new System.Drawing.Point(12, 272);
            this.Btn_ImportConfig.Name = "Btn_ImportConfig";
            this.Btn_ImportConfig.Size = new System.Drawing.Size(91, 23);
            this.Btn_ImportConfig.TabIndex = 49;
            this.Btn_ImportConfig.Text = "Import";
            this.Btn_ImportConfig.UseVisualStyleBackColor = true;
            this.Btn_ImportConfig.Click += new System.EventHandler(this.Btn_ImportConfig_Click);
            // 
            // Btn_Stop
            // 
            this.Btn_Stop.Location = new System.Drawing.Point(341, 204);
            this.Btn_Stop.Name = "Btn_Stop";
            this.Btn_Stop.Size = new System.Drawing.Size(108, 23);
            this.Btn_Stop.TabIndex = 50;
            this.Btn_Stop.Text = "Stop";
            this.Btn_Stop.UseVisualStyleBackColor = true;
            this.Btn_Stop.Click += new System.EventHandler(this.Btn_Stop_Click);
            // 
            // Listbox_CurrentStep
            // 
            this.Listbox_CurrentStep.Items.AddRange(new object[] {
            "1. Applying lure",
            "2. Using fish skill",
            "3. Waiting for bobber",
            "4. Finding bobber",
            "5. Listening for splash",
            "6. Catching fish",
            "-------------------------------",
            "Random sleep",
            "Paused"});
            this.Listbox_CurrentStep.Location = new System.Drawing.Point(224, 170);
            this.Listbox_CurrentStep.Name = "Listbox_CurrentStep";
            this.Listbox_CurrentStep.Size = new System.Drawing.Size(111, 121);
            this.Listbox_CurrentStep.TabIndex = 51;
            this.Listbox_CurrentStep.TabStop = false;
            // 
            // CurrentVolumeBar
            // 
            this.CurrentVolumeBar.Location = new System.Drawing.Point(0, 434);
            this.CurrentVolumeBar.MarqueeAnimationSpeed = 0;
            this.CurrentVolumeBar.Name = "CurrentVolumeBar";
            this.CurrentVolumeBar.Size = new System.Drawing.Size(561, 10);
            this.CurrentVolumeBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.CurrentVolumeBar.TabIndex = 52;
            // 
            // CurrentVolumeLabel
            // 
            this.CurrentVolumeLabel.AutoSize = true;
            this.CurrentVolumeLabel.Location = new System.Drawing.Point(572, 431);
            this.CurrentVolumeLabel.Name = "CurrentVolumeLabel";
            this.CurrentVolumeLabel.Size = new System.Drawing.Size(21, 13);
            this.CurrentVolumeLabel.TabIndex = 53;
            this.CurrentVolumeLabel.Text = "0%";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 468);
            this.Controls.Add(this.CurrentVolumeLabel);
            this.Controls.Add(this.CurrentVolumeBar);
            this.Controls.Add(this.Listbox_CurrentStep);
            this.Controls.Add(this.Btn_Stop);
            this.Controls.Add(this.Btn_ImportConfig);
            this.Controls.Add(this.Btn_SaveConfig);
            this.Controls.Add(this.Btn_Run);
            this.Controls.Add(this.PeakVolumeLable);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Lb_PickedVolume);
            this.Controls.Add(this.Inp_TriggerVolume);
            this.Controls.Add(this.Btn_ResetPeakVolume);
            this.Controls.Add(this.Btn_UpdateScreenshot);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_Log);
            this.Controls.Add(this.Btn_CaptureBobberColor);
            this.Controls.Add(this.Btn_CaptureFishSkill);
            this.Controls.Add(this.Btn_CaptureLureSkill);
            this.Controls.Add(this.Btn_CaptureBottomRight);
            this.Controls.Add(this.Btn_CaptureTopLeft);
            this.Controls.Add(this.Inp_FishSkill);
            this.Controls.Add(this.Inp_LureSkill);
            this.Controls.Add(this.Inp_BottomRight);
            this.Controls.Add(this.Inp_TopLeft);
            this.Controls.Add(this.Inp_BobberColor);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCaptureAll);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Inp_SleepChance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "WoW FishBot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Inp_SleepChance)).EndInit();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inp_TriggerVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Inp_SleepChance;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.Button btnCaptureAll;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button Btn_CaptureTopLeft;
        private System.Windows.Forms.Button Btn_CaptureBottomRight;
        private System.Windows.Forms.Button Btn_CaptureLureSkill;
        private System.Windows.Forms.Button Btn_CaptureFishSkill;
        private System.Windows.Forms.Button Btn_CaptureBobberColor;
        private System.Windows.Forms.RichTextBox tb_Log;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Button Btn_UpdateScreenshot;
        private System.Windows.Forms.Button Btn_ResetPeakVolume;
        private System.Windows.Forms.TrackBar Inp_TriggerVolume;
        private System.Windows.Forms.Label Lb_PickedVolume;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Btn_Run;
        public System.Windows.Forms.TextBox Inp_BobberColor;
        public System.Windows.Forms.TextBox Inp_TopLeft;
        public System.Windows.Forms.TextBox Inp_BottomRight;
        public System.Windows.Forms.TextBox Inp_LureSkill;
        public System.Windows.Forms.TextBox Inp_FishSkill;
        public System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.Button Btn_SaveConfig;
        private System.Windows.Forms.Button Btn_ImportConfig;
        private System.Windows.Forms.Button Btn_Stop;
        public System.Windows.Forms.ListBox Listbox_CurrentStep;
        private System.Windows.Forms.ProgressBar CurrentVolumeBar;
        private System.Windows.Forms.Label CurrentVolumeLabel;
        public System.Windows.Forms.Label PeakVolumeLable;
    }
}

