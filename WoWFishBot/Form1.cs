using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoWFishBot
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void UpdateStatusBar(string status)
        {
            Logger.Log($"Updating status bar to '{status}'", false);
            StatusLabel.Text = status;
            StatusStrip.Update();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Logger.Log("Updating settings");
            Config.triggerVolumePercent = float.Parse(Inp_TriggerVol.Text);
            Config.sleepChancePercent = float.Parse(Inp_SleepChance.Text);
            Config.delayMultiplyer = float.Parse(Inp_DelayMultiplier.Text);
            Config.useLure = cb_UseLure.Checked;

            UpdateStatusBar("Settings saved");
        }

        // Public Form Accessors
        public ToolStripStatusLabel StatusBarLabel { get { return StatusLabel; } }
        public TextBox TopLeft { get { return Inp_TopLeft; } }
        public TextBox BottomRight { get { return Inp_BottomRight; } }
        public TextBox LureSkill { get { return Inp_LureSkill; } }
        public TextBox FishSkill { get { return Inp_FishSkill; } }
        public TextBox BobberColor { get { return Inp_BobberColor; } }
        public void ClearAllCaptureInputs()
        {
            Inp_TopLeft.Text = string.Empty;
            Inp_BottomRight.Text = string.Empty;
            Inp_LureSkill.Text = string.Empty;
            Inp_FishSkill.Text = string.Empty;
            Inp_BobberColor.Text = string.Empty;
            Logger.Log("Cleared all capture inputs");
        }

        // Capture Buttons
        private void Btn_CaptureAll_Click(object sender, EventArgs e) =>Config.CaptureAll();
        private void Btn_CaptureTopLeft_Click(object sender, EventArgs e) => Config.CaptureTopLeft(3000);
        private void Btn_CaptureBottomRight_Click(object sender, EventArgs e) => Config.CaptureBottomRight(3000);
        private void Btn_CaptureLureSkill_Click(object sender, EventArgs e) => Config.CaptureLureSkill(3000);
        private void Btn_CaptureFishSkill_Click(object sender, EventArgs e) => Config.CaptureFishSkill(3000);
        private void Btn_CaptureBobberColor_Click(object sender, EventArgs e) => Config.CaptureBobberColor(3000);

    }
}
