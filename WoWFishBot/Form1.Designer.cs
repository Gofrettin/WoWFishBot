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
            this.Inp_TriggerVol = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Inp_SleepChance = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Inp_DelayMultiplier = new System.Windows.Forms.NumericUpDown();
            this.cb_UseLure = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.Inp_TriggerVol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inp_SleepChance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inp_DelayMultiplier)).BeginInit();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Inp_TriggerVol
            // 
            this.Inp_TriggerVol.DecimalPlaces = 1;
            this.Inp_TriggerVol.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Inp_TriggerVol.Location = new System.Drawing.Point(144, 12);
            this.Inp_TriggerVol.Name = "Inp_TriggerVol";
            this.Inp_TriggerVol.Size = new System.Drawing.Size(67, 20);
            this.Inp_TriggerVol.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trigger Volume %";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
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
            this.Inp_SleepChance.Location = new System.Drawing.Point(144, 38);
            this.Inp_SleepChance.Name = "Inp_SleepChance";
            this.Inp_SleepChance.Size = new System.Drawing.Size(67, 20);
            this.Inp_SleepChance.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Delay Multiplier";
            // 
            // Inp_DelayMultiplier
            // 
            this.Inp_DelayMultiplier.DecimalPlaces = 1;
            this.Inp_DelayMultiplier.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Inp_DelayMultiplier.Location = new System.Drawing.Point(144, 64);
            this.Inp_DelayMultiplier.Name = "Inp_DelayMultiplier";
            this.Inp_DelayMultiplier.Size = new System.Drawing.Size(67, 20);
            this.Inp_DelayMultiplier.TabIndex = 4;
            // 
            // cb_UseLure
            // 
            this.cb_UseLure.AutoSize = true;
            this.cb_UseLure.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_UseLure.Location = new System.Drawing.Point(12, 93);
            this.cb_UseLure.Name = "cb_UseLure";
            this.cb_UseLure.Size = new System.Drawing.Size(69, 17);
            this.cb_UseLure.TabIndex = 6;
            this.cb_UseLure.Text = "Use Lure";
            this.cb_UseLure.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(485, 132);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 603);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(800, 22);
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
            this.btnCaptureAll.Location = new System.Drawing.Point(12, 154);
            this.btnCaptureAll.Name = "btnCaptureAll";
            this.btnCaptureAll.Size = new System.Drawing.Size(234, 23);
            this.btnCaptureAll.TabIndex = 9;
            this.btnCaptureAll.Text = "Capture All";
            this.btnCaptureAll.UseVisualStyleBackColor = true;
            this.btnCaptureAll.Click += new System.EventHandler(this.Btn_CaptureAll_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Top Left";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Bottom Right";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Lure Skill";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 263);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Fish Skill";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 289);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Bobber Color";
            // 
            // Inp_BobberColor
            // 
            this.Inp_BobberColor.Enabled = false;
            this.Inp_BobberColor.Location = new System.Drawing.Point(109, 286);
            this.Inp_BobberColor.Name = "Inp_BobberColor";
            this.Inp_BobberColor.Size = new System.Drawing.Size(102, 20);
            this.Inp_BobberColor.TabIndex = 27;
            // 
            // Inp_TopLeft
            // 
            this.Inp_TopLeft.Enabled = false;
            this.Inp_TopLeft.Location = new System.Drawing.Point(109, 182);
            this.Inp_TopLeft.Name = "Inp_TopLeft";
            this.Inp_TopLeft.Size = new System.Drawing.Size(102, 20);
            this.Inp_TopLeft.TabIndex = 28;
            // 
            // Inp_BottomRight
            // 
            this.Inp_BottomRight.Enabled = false;
            this.Inp_BottomRight.Location = new System.Drawing.Point(109, 208);
            this.Inp_BottomRight.Name = "Inp_BottomRight";
            this.Inp_BottomRight.Size = new System.Drawing.Size(102, 20);
            this.Inp_BottomRight.TabIndex = 29;
            // 
            // Inp_LureSkill
            // 
            this.Inp_LureSkill.Enabled = false;
            this.Inp_LureSkill.Location = new System.Drawing.Point(109, 234);
            this.Inp_LureSkill.Name = "Inp_LureSkill";
            this.Inp_LureSkill.Size = new System.Drawing.Size(102, 20);
            this.Inp_LureSkill.TabIndex = 30;
            // 
            // Inp_FishSkill
            // 
            this.Inp_FishSkill.Enabled = false;
            this.Inp_FishSkill.Location = new System.Drawing.Point(109, 260);
            this.Inp_FishSkill.Name = "Inp_FishSkill";
            this.Inp_FishSkill.Size = new System.Drawing.Size(102, 20);
            this.Inp_FishSkill.TabIndex = 31;
            // 
            // Btn_CaptureTopLeft
            // 
            this.Btn_CaptureTopLeft.Location = new System.Drawing.Point(217, 182);
            this.Btn_CaptureTopLeft.Name = "Btn_CaptureTopLeft";
            this.Btn_CaptureTopLeft.Size = new System.Drawing.Size(29, 23);
            this.Btn_CaptureTopLeft.TabIndex = 32;
            this.Btn_CaptureTopLeft.Text = ">";
            this.Btn_CaptureTopLeft.UseVisualStyleBackColor = true;
            this.Btn_CaptureTopLeft.Click += new System.EventHandler(this.Btn_CaptureTopLeft_Click);
            // 
            // Btn_CaptureBottomRight
            // 
            this.Btn_CaptureBottomRight.Location = new System.Drawing.Point(217, 206);
            this.Btn_CaptureBottomRight.Name = "Btn_CaptureBottomRight";
            this.Btn_CaptureBottomRight.Size = new System.Drawing.Size(29, 23);
            this.Btn_CaptureBottomRight.TabIndex = 33;
            this.Btn_CaptureBottomRight.Text = ">";
            this.Btn_CaptureBottomRight.UseVisualStyleBackColor = true;
            this.Btn_CaptureBottomRight.Click += new System.EventHandler(this.Btn_CaptureBottomRight_Click);
            // 
            // Btn_CaptureLureSkill
            // 
            this.Btn_CaptureLureSkill.Location = new System.Drawing.Point(217, 232);
            this.Btn_CaptureLureSkill.Name = "Btn_CaptureLureSkill";
            this.Btn_CaptureLureSkill.Size = new System.Drawing.Size(29, 23);
            this.Btn_CaptureLureSkill.TabIndex = 34;
            this.Btn_CaptureLureSkill.Text = ">";
            this.Btn_CaptureLureSkill.UseVisualStyleBackColor = true;
            this.Btn_CaptureLureSkill.Click += new System.EventHandler(this.Btn_CaptureLureSkill_Click);
            // 
            // Btn_CaptureFishSkill
            // 
            this.Btn_CaptureFishSkill.Location = new System.Drawing.Point(217, 258);
            this.Btn_CaptureFishSkill.Name = "Btn_CaptureFishSkill";
            this.Btn_CaptureFishSkill.Size = new System.Drawing.Size(29, 23);
            this.Btn_CaptureFishSkill.TabIndex = 35;
            this.Btn_CaptureFishSkill.Text = ">";
            this.Btn_CaptureFishSkill.UseVisualStyleBackColor = true;
            this.Btn_CaptureFishSkill.Click += new System.EventHandler(this.Btn_CaptureFishSkill_Click);
            // 
            // Btn_CaptureBobberColor
            // 
            this.Btn_CaptureBobberColor.Location = new System.Drawing.Point(217, 284);
            this.Btn_CaptureBobberColor.Name = "Btn_CaptureBobberColor";
            this.Btn_CaptureBobberColor.Size = new System.Drawing.Size(29, 23);
            this.Btn_CaptureBobberColor.TabIndex = 36;
            this.Btn_CaptureBobberColor.Text = ">";
            this.Btn_CaptureBobberColor.UseVisualStyleBackColor = true;
            this.Btn_CaptureBobberColor.Click += new System.EventHandler(this.Btn_CaptureBobberColor_Click);
            // 
            // tb_Log
            // 
            this.tb_Log.Location = new System.Drawing.Point(12, 322);
            this.tb_Log.Name = "tb_Log";
            this.tb_Log.Size = new System.Drawing.Size(528, 208);
            this.tb_Log.TabIndex = 37;
            this.tb_Log.Text = "";
            this.tb_Log.WordWrap = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 625);
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
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cb_UseLure);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Inp_DelayMultiplier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Inp_SleepChance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Inp_TriggerVol);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Inp_TriggerVol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inp_SleepChance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inp_DelayMultiplier)).EndInit();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Inp_TriggerVol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Inp_SleepChance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Inp_DelayMultiplier;
        private System.Windows.Forms.CheckBox cb_UseLure;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.Button btnCaptureAll;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Inp_BobberColor;
        private System.Windows.Forms.TextBox Inp_TopLeft;
        private System.Windows.Forms.TextBox Inp_BottomRight;
        private System.Windows.Forms.TextBox Inp_LureSkill;
        private System.Windows.Forms.TextBox Inp_FishSkill;
        private System.Windows.Forms.Button Btn_CaptureTopLeft;
        private System.Windows.Forms.Button Btn_CaptureBottomRight;
        private System.Windows.Forms.Button Btn_CaptureLureSkill;
        private System.Windows.Forms.Button Btn_CaptureFishSkill;
        private System.Windows.Forms.Button Btn_CaptureBobberColor;
        private System.Windows.Forms.RichTextBox tb_Log;
    }
}

