using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        WindowsMediaPlayer player = new WindowsMediaPlayer();

        private void Form1_Load(object sender, EventArgs e)
        {
            player.URL = "Imagine Dragons – Thunder.mp3";
            player.controls.stop();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            player.controls.play();
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            player.controls.pause();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            player.controls.stop();
        }

        private void previousTrackButton_Click(object sender, EventArgs e)
        {
            player.controls.previous();
        }

        private void nextTrackButton_Click(object sender, EventArgs e)
        {
            player.controls.next();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            trackName.Text = player.currentMedia.name;
        }
    }
}
