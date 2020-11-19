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
            Logger.Log($"Updating status bar to '{status}'");
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

        private void btnCapture_Click(object sender, EventArgs e)
        {
            Config.CaptureAll();
            
        }

        // Public Form Access
        public TextBox TopLeft { get { return Inp_TopLeft; } }
        public TextBox BottomRight { get { return Inp_BottomRight; } }
        public TextBox LureSkill { get { return Inp_LureSkill; } }
        public TextBox FishSkill { get { return Inp_FishSkill; } }
        public TextBox BobberColor { get { return Inp_BobberColor; } }

    }
}
