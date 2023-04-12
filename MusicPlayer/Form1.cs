using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] paths, files;

        private void trackList_SelectedIndexChanged(object sender, EventArgs e)
        {
            player.URL = paths[trackList.SelectedIndex];
            player.Ctlcontrols.play();
        }

        private void tombolStop_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
        }

        private void tombolPause_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
        }

        private void tombolPlay_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.play();
        }

        private void tombolNext_Click(object sender, EventArgs e)
        {
            if (trackList.SelectedIndex < trackList.Items.Count - 1)
            {
                trackList.SelectedIndex = trackList.SelectedIndex + 1;
            }
        }

        private void tombolPreviouse_Click(object sender, EventArgs e)
        {
            if (trackList.SelectedIndex >0)
            {
                trackList.SelectedIndex = trackList.SelectedIndex - 1;
            }
        }

        private void tombolOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog bukaDialogFile = new OpenFileDialog();
            bukaDialogFile.Multiselect = true;
            if (bukaDialogFile.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                files = bukaDialogFile.FileNames ;
                paths = bukaDialogFile.FileNames ;
                for (int x = 0; x < files.Length; x++)
                {
                    trackList.Items.Add(files[x]);
                }
            }
        }
    }
}
