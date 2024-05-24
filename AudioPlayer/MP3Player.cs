using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AudioPlayer
{
    public partial class MP3Player : Form
    {
        public MP3Player()
        {
            InitializeComponent();
            track_volume.Value = 30;
        }
        string[] files;
        List<string> paths;

        private void track_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex >= 0 && track_list.SelectedIndex < paths.Count)
            {
                player.URL = paths[track_list.SelectedIndex];
                player.Ctlcontrols.play();
            }
        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
        }

        private void pause_button_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
        }

        private void play_button_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.play();
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex < track_list.Items.Count - 1)
            {
                track_list.SelectedIndex++;
            }
        }

        private void preview_button_Click(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex > 0)
            {
                track_list.SelectedIndex--;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                p_bar.Maximum = (int)player.Ctlcontrols.currentItem.duration;
                p_bar.Value = (int)player.Ctlcontrols.currentPosition;
            }
            try
            {
                label_track_start.Text = player.Ctlcontrols.currentPositionString;
                label_track_end.Text = player.Ctlcontrols.currentItem.durationString.ToString();
            }
            catch
            {

            }
        }

        private void track_volume_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = track_volume.Value;
            label_volume.Text = track_volume.Value.ToString() + "%";
        }

        private void p_bar_MouseDown(object sender, MouseEventArgs e)
        {
            player.Ctlcontrols.currentPosition = player.currentMedia.duration * e.X / p_bar.Width;
        }

        private void open_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.FileNames;
                for (int x = 0; x < files.Length; x++)
                {
                    int index = 0;
                    for (int i = files[x].Length - 1; i > 0; i--)
                    {
                        if (files[x][i] == '\\')
                        {
                            index = i + 1;
                            break;
                        }
                    }
                    track_list.Items.Add(System.IO.Path.GetFileNameWithoutExtension(files[x]));
                    if (paths == null)
                        paths = new List<string>();
                    paths.Add(files[x]);

                }
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex != -1)
            {
                int selectedIndex = track_list.SelectedIndex;

                track_list.Items.RemoveAt(selectedIndex);

                if (selectedIndex < paths.Count)
                {
                    paths.RemoveAt(selectedIndex);
                }

                if (track_list.Items.Count > 0)
                {
                    if (selectedIndex == track_list.Items.Count)
                    {
                        track_list.SelectedIndex = selectedIndex - 1;
                    }
                    else
                    {
                        track_list.SelectedIndex = selectedIndex;
                    }
                }
                else
                {
                    player.Ctlcontrols.stop();
                }
            }
        }
    }
}
