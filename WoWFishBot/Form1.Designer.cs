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
            this.Listbox_CurrentStep = new System.Windows.Forms.ListBox();
            this.CurrentVolumeBar = new System.Windows.Forms.ProgressBar();
            this.CurrentVolumeLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Inp_SleepChance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inp_TriggerVolume)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sleep Chance %";
            // 
            // Inp_SleepChance
            // 
            this.Inp_SleepChance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Inp_SleepChance.DecimalPlaces = 1;
            this.Inp_SleepChance.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Inp_SleepChance.Location = new System.Drawing.Point(157, 160);
            this.Inp_SleepChance.Name = "Inp_SleepChance";
            this.Inp_SleepChance.Size = new System.Drawing.Size(57, 20);
            this.Inp_SleepChance.TabIndex = 2;
            this.Inp_SleepChance.ValueChanged += new System.EventHandler(this.Inp_SleepChance_ValueChanged);
            // 
            // btnCaptureAll
            // 
            this.btnCaptureAll.BackColor = System.Drawing.SystemColors.Control;
            this.btnCaptureAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaptureAll.Location = new System.Drawing.Point(6, 6);
            this.btnCaptureAll.Name = "btnCaptureAll";
            this.btnCaptureAll.Size = new System.Drawing.Size(207, 23);
            this.btnCaptureAll.TabIndex = 9;
            this.btnCaptureAll.Text = "Capture All";
            this.btnCaptureAll.UseVisualStyleBackColor = false;
            this.btnCaptureAll.Click += new System.EventHandler(this.Btn_CaptureAll_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Top Left";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Bottom Right";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Lure Skill";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Fish Skill";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Bobber Color";
            // 
            // Inp_BobberColor
            // 
            this.Inp_BobberColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Inp_BobberColor.Enabled = false;
            this.Inp_BobberColor.Location = new System.Drawing.Point(93, 137);
            this.Inp_BobberColor.Name = "Inp_BobberColor";
            this.Inp_BobberColor.Size = new System.Drawing.Size(102, 20);
            this.Inp_BobberColor.TabIndex = 27;
            // 
            // Inp_TopLeft
            // 
            this.Inp_TopLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Inp_TopLeft.Enabled = false;
            this.Inp_TopLeft.Location = new System.Drawing.Point(93, 33);
            this.Inp_TopLeft.Name = "Inp_TopLeft";
            this.Inp_TopLeft.Size = new System.Drawing.Size(102, 20);
            this.Inp_TopLeft.TabIndex = 28;
            // 
            // Inp_BottomRight
            // 
            this.Inp_BottomRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Inp_BottomRight.Enabled = false;
            this.Inp_BottomRight.Location = new System.Drawing.Point(93, 59);
            this.Inp_BottomRight.Name = "Inp_BottomRight";
            this.Inp_BottomRight.Size = new System.Drawing.Size(102, 20);
            this.Inp_BottomRight.TabIndex = 29;
            // 
            // Inp_LureSkill
            // 
            this.Inp_LureSkill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Inp_LureSkill.Enabled = false;
            this.Inp_LureSkill.Location = new System.Drawing.Point(93, 85);
            this.Inp_LureSkill.Name = "Inp_LureSkill";
            this.Inp_LureSkill.Size = new System.Drawing.Size(102, 20);
            this.Inp_LureSkill.TabIndex = 30;
            // 
            // Inp_FishSkill
            // 
            this.Inp_FishSkill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Inp_FishSkill.Enabled = false;
            this.Inp_FishSkill.Location = new System.Drawing.Point(93, 111);
            this.Inp_FishSkill.Name = "Inp_FishSkill";
            this.Inp_FishSkill.Size = new System.Drawing.Size(102, 20);
            this.Inp_FishSkill.TabIndex = 31;
            // 
            // Btn_CaptureTopLeft
            // 
            this.Btn_CaptureTopLeft.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_CaptureTopLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CaptureTopLeft.Location = new System.Drawing.Point(197, 33);
            this.Btn_CaptureTopLeft.Name = "Btn_CaptureTopLeft";
            this.Btn_CaptureTopLeft.Size = new System.Drawing.Size(17, 23);
            this.Btn_CaptureTopLeft.TabIndex = 32;
            this.Btn_CaptureTopLeft.Text = ">";
            this.Btn_CaptureTopLeft.UseVisualStyleBackColor = false;
            this.Btn_CaptureTopLeft.Click += new System.EventHandler(this.Btn_CaptureTopLeft_Click);
            // 
            // Btn_CaptureBottomRight
            // 
            this.Btn_CaptureBottomRight.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_CaptureBottomRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CaptureBottomRight.Location = new System.Drawing.Point(197, 58);
            this.Btn_CaptureBottomRight.Name = "Btn_CaptureBottomRight";
            this.Btn_CaptureBottomRight.Size = new System.Drawing.Size(17, 23);
            this.Btn_CaptureBottomRight.TabIndex = 33;
            this.Btn_CaptureBottomRight.Text = ">";
            this.Btn_CaptureBottomRight.UseVisualStyleBackColor = false;
            this.Btn_CaptureBottomRight.Click += new System.EventHandler(this.Btn_CaptureBottomRight_Click);
            // 
            // Btn_CaptureLureSkill
            // 
            this.Btn_CaptureLureSkill.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_CaptureLureSkill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CaptureLureSkill.Location = new System.Drawing.Point(197, 83);
            this.Btn_CaptureLureSkill.Name = "Btn_CaptureLureSkill";
            this.Btn_CaptureLureSkill.Size = new System.Drawing.Size(17, 23);
            this.Btn_CaptureLureSkill.TabIndex = 34;
            this.Btn_CaptureLureSkill.Text = ">";
            this.Btn_CaptureLureSkill.UseVisualStyleBackColor = false;
            this.Btn_CaptureLureSkill.Click += new System.EventHandler(this.Btn_CaptureLureSkill_Click);
            // 
            // Btn_CaptureFishSkill
            // 
            this.Btn_CaptureFishSkill.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_CaptureFishSkill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CaptureFishSkill.Location = new System.Drawing.Point(197, 108);
            this.Btn_CaptureFishSkill.Name = "Btn_CaptureFishSkill";
            this.Btn_CaptureFishSkill.Size = new System.Drawing.Size(17, 23);
            this.Btn_CaptureFishSkill.TabIndex = 35;
            this.Btn_CaptureFishSkill.Text = ">";
            this.Btn_CaptureFishSkill.UseVisualStyleBackColor = false;
            this.Btn_CaptureFishSkill.Click += new System.EventHandler(this.Btn_CaptureFishSkill_Click);
            // 
            // Btn_CaptureBobberColor
            // 
            this.Btn_CaptureBobberColor.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_CaptureBobberColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CaptureBobberColor.Location = new System.Drawing.Point(197, 133);
            this.Btn_CaptureBobberColor.Name = "Btn_CaptureBobberColor";
            this.Btn_CaptureBobberColor.Size = new System.Drawing.Size(17, 23);
            this.Btn_CaptureBobberColor.TabIndex = 36;
            this.Btn_CaptureBobberColor.Text = ">";
            this.Btn_CaptureBobberColor.UseVisualStyleBackColor = false;
            this.Btn_CaptureBobberColor.Click += new System.EventHandler(this.Btn_CaptureBobberColor_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(3, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Peak Volume";
            // 
            // PictureBox
            // 
            this.PictureBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox.Location = new System.Drawing.Point(161, 6);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(281, 226);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 40;
            this.PictureBox.TabStop = false;
            // 
            // Btn_UpdateScreenshot
            // 
            this.Btn_UpdateScreenshot.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_UpdateScreenshot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_UpdateScreenshot.Location = new System.Drawing.Point(413, 209);
            this.Btn_UpdateScreenshot.Name = "Btn_UpdateScreenshot";
            this.Btn_UpdateScreenshot.Size = new System.Drawing.Size(29, 23);
            this.Btn_UpdateScreenshot.TabIndex = 41;
            this.Btn_UpdateScreenshot.Text = ">";
            this.Btn_UpdateScreenshot.UseVisualStyleBackColor = false;
            this.Btn_UpdateScreenshot.Click += new System.EventHandler(this.Btn_UpdateScreenshot_Click);
            // 
            // Btn_ResetPeakVolume
            // 
            this.Btn_ResetPeakVolume.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_ResetPeakVolume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ResetPeakVolume.Location = new System.Drawing.Point(106, 209);
            this.Btn_ResetPeakVolume.Name = "Btn_ResetPeakVolume";
            this.Btn_ResetPeakVolume.Size = new System.Drawing.Size(49, 23);
            this.Btn_ResetPeakVolume.TabIndex = 42;
            this.Btn_ResetPeakVolume.Text = "Reset";
            this.Btn_ResetPeakVolume.UseVisualStyleBackColor = false;
            this.Btn_ResetPeakVolume.Click += new System.EventHandler(this.Btn_ResetPeakVolume_Click);
            // 
            // Inp_TriggerVolume
            // 
            this.Inp_TriggerVolume.BackColor = System.Drawing.Color.White;
            this.Inp_TriggerVolume.Location = new System.Drawing.Point(92, 189);
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
            this.Lb_PickedVolume.Location = new System.Drawing.Point(35, 202);
            this.Lb_PickedVolume.Name = "Lb_PickedVolume";
            this.Lb_PickedVolume.Size = new System.Drawing.Size(21, 13);
            this.Lb_PickedVolume.TabIndex = 44;
            this.Lb_PickedVolume.Text = "0%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Trigger Volume";
            // 
            // PeakVolumeLable
            // 
            this.PeakVolumeLable.AutoSize = true;
            this.PeakVolumeLable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PeakVolumeLable.Location = new System.Drawing.Point(79, 214);
            this.PeakVolumeLable.Name = "PeakVolumeLable";
            this.PeakVolumeLable.Size = new System.Drawing.Size(21, 13);
            this.PeakVolumeLable.TabIndex = 46;
            this.PeakVolumeLable.Text = "0%";
            // 
            // Btn_Run
            // 
            this.Btn_Run.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Run.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Run.Location = new System.Drawing.Point(6, 6);
            this.Btn_Run.Name = "Btn_Run";
            this.Btn_Run.Size = new System.Drawing.Size(149, 23);
            this.Btn_Run.TabIndex = 47;
            this.Btn_Run.Text = "Run";
            this.Btn_Run.UseVisualStyleBackColor = false;
            this.Btn_Run.Click += new System.EventHandler(this.Btn_Run_Click);
            // 
            // Btn_SaveConfig
            // 
            this.Btn_SaveConfig.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_SaveConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SaveConfig.Location = new System.Drawing.Point(220, 33);
            this.Btn_SaveConfig.Name = "Btn_SaveConfig";
            this.Btn_SaveConfig.Size = new System.Drawing.Size(109, 23);
            this.Btn_SaveConfig.TabIndex = 48;
            this.Btn_SaveConfig.Text = "Save";
            this.Btn_SaveConfig.UseVisualStyleBackColor = false;
            this.Btn_SaveConfig.Click += new System.EventHandler(this.Btn_SaveConfig_Click);
            // 
            // Btn_ImportConfig
            // 
            this.Btn_ImportConfig.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_ImportConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ImportConfig.Location = new System.Drawing.Point(220, 6);
            this.Btn_ImportConfig.Name = "Btn_ImportConfig";
            this.Btn_ImportConfig.Size = new System.Drawing.Size(109, 23);
            this.Btn_ImportConfig.TabIndex = 49;
            this.Btn_ImportConfig.Text = "Import";
            this.Btn_ImportConfig.UseVisualStyleBackColor = false;
            this.Btn_ImportConfig.Click += new System.EventHandler(this.Btn_ImportConfig_Click);
            // 
            // Listbox_CurrentStep
            // 
            this.Listbox_CurrentStep.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Listbox_CurrentStep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Listbox_CurrentStep.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Listbox_CurrentStep.Items.AddRange(new object[] {
            "1. Applying lure",
            "2. Using fish skill",
            "3. Waiting for bobber",
            "4. Finding bobber",
            "5. Listening for splash",
            "6. Catching fish",
            "------------------------------------------------------------",
            "Random sleep",
            "Paused"});
            this.Listbox_CurrentStep.Location = new System.Drawing.Point(6, 48);
            this.Listbox_CurrentStep.Name = "Listbox_CurrentStep";
            this.Listbox_CurrentStep.Size = new System.Drawing.Size(149, 119);
            this.Listbox_CurrentStep.TabIndex = 51;
            this.Listbox_CurrentStep.TabStop = false;
            // 
            // CurrentVolumeBar
            // 
            this.CurrentVolumeBar.ForeColor = System.Drawing.SystemColors.Control;
            this.CurrentVolumeBar.Location = new System.Drawing.Point(6, 188);
            this.CurrentVolumeBar.MarqueeAnimationSpeed = 0;
            this.CurrentVolumeBar.Name = "CurrentVolumeBar";
            this.CurrentVolumeBar.Size = new System.Drawing.Size(149, 18);
            this.CurrentVolumeBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.CurrentVolumeBar.TabIndex = 52;
            // 
            // CurrentVolumeLabel
            // 
            this.CurrentVolumeLabel.AutoSize = true;
            this.CurrentVolumeLabel.BackColor = System.Drawing.Color.Transparent;
            this.CurrentVolumeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CurrentVolumeLabel.Location = new System.Drawing.Point(134, 172);
            this.CurrentVolumeLabel.Name = "CurrentVolumeLabel";
            this.CurrentVolumeLabel.Size = new System.Drawing.Size(21, 13);
            this.CurrentVolumeLabel.TabIndex = 53;
            this.CurrentVolumeLabel.Text = "0%";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(457, 266);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 56;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.Btn_UpdateScreenshot);
            this.tabPage2.Controls.Add(this.Listbox_CurrentStep);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.Btn_Run);
            this.tabPage2.Controls.Add(this.PictureBox);
            this.tabPage2.Controls.Add(this.CurrentVolumeLabel);
            this.tabPage2.Controls.Add(this.CurrentVolumeBar);
            this.tabPage2.Controls.Add(this.Btn_ResetPeakVolume);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.PeakVolumeLable);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(449, 240);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bot";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Btn_SaveConfig);
            this.tabPage3.Controls.Add(this.Btn_ImportConfig);
            this.tabPage3.Controls.Add(this.Inp_SleepChance);
            this.tabPage3.Controls.Add(this.btnCaptureAll);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.Lb_PickedVolume);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.Inp_TriggerVolume);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.Btn_CaptureFishSkill);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.Btn_CaptureBobberColor);
            this.tabPage3.Controls.Add(this.Btn_CaptureLureSkill);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.Btn_CaptureBottomRight);
            this.tabPage3.Controls.Add(this.Btn_CaptureTopLeft);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.Inp_FishSkill);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.Inp_LureSkill);
            this.tabPage3.Controls.Add(this.Inp_BobberColor);
            this.tabPage3.Controls.Add(this.Inp_BottomRight);
            this.tabPage3.Controls.Add(this.Inp_TopLeft);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(449, 240);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Settings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(6, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Current Volume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(8, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Current Step";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(449, 240);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Stats";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(196, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Soon...";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(454, 264);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Remote Fisher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Inp_SleepChance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inp_TriggerVolume)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Inp_SleepChance;
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
        private System.Windows.Forms.Button Btn_SaveConfig;
        private System.Windows.Forms.Button Btn_ImportConfig;
        public System.Windows.Forms.ListBox Listbox_CurrentStep;
        private System.Windows.Forms.ProgressBar CurrentVolumeBar;
        private System.Windows.Forms.Label CurrentVolumeLabel;
        public System.Windows.Forms.Label PeakVolumeLable;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label9;
    }
}

