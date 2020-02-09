using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsMediaCtrl;

namespace MediaCtrl
{
    public partial class MediaCtrlForm : Form
    {
        WindowsAppCommand volctrl;

        public MediaCtrlForm()
        {
            volctrl = new WindowsAppCommand(this.Handle);
            InitializeComponent();
        }

        private void VolUpBtn_Click(object sender, EventArgs e)
        {
            volctrl.VolUp();
            UpdateVolume();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitVolumeBar();
        }

        private void InitVolumeBar()
        {
            volumeBar.Maximum = 100;
            volumeBar.Minimum = 0;
            UpdateVolume();
        }

        private void VolDownBtn_Click(object sender, EventArgs e)
        {
            volctrl.VolDown();
            UpdateVolume();
        }

        private void MuteBtn_Click(object sender, EventArgs e)
        {
            volctrl.Mute();
            UpdateVolume();
        }

        private void UpdateVolume()
        {
            int vol = MasterVolume.GetVolume();
            volumeBar.Value = vol;
        }

        private void PlayPauseBtn_Click(object sender, EventArgs e)
        {
            volctrl.PlayPause();
        }

        private void PrevBtn_Click(object sender, EventArgs e)
        {
            volctrl.PreviousTrack();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            volctrl.NextTrack();
        }
    }
}
