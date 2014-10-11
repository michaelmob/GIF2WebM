using System;
using System.IO;
using System.Drawing;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Diagnostics;

namespace GIF2WebM
{
    public partial class Form_Convert : Form
    {
        public String args;
        public String temp = Path.GetTempPath() + "\\" + (DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond).ToString() + "\\";
        public Boolean done = false;
        GIF gif;

        public Form_Convert(Image _gif)
        {
            InitializeComponent();

            // Initialize the GIF class to work with our GIF
            gif = new GIF(_gif);
        }

        private void Form_Convert_Load(object sender, EventArgs e)
        {

        }

        private void list_frames_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                var bmp = new FileStream(temp + list_frames.SelectedItem + ".png", FileMode.Open, FileAccess.Read);
                preview.Image = Image.FromStream(bmp);
                bmp.Close();
            } catch {
                if(list_frames.SelectedIndex != -1)
                    list_frames.Items.RemoveAt(list_frames.SelectedIndex);
            }
        }

        private void Form_Convert_Shown(object sender, EventArgs e)
        {
            // Create directory the unique directory
            Directory.CreateDirectory(temp);

            // Set the status and then start the worker
            label_status.Text = "Saving";
            worker.RunWorkerAsync();
        }

        private void worker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            // For each frame save to the temp directory
            for (int i = 0; i < gif.frame_count; i++) {
                worker.ReportProgress(Convert.ToInt16(((float)i / gif.frame_count) * 100));
                Image frame = gif.frame(i);
                frame.Save(temp + (i + 1).ToString() + ".png", ImageFormat.Png);
                frame.Dispose();
            }
        }

        private void worker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progress.Value = e.ProgressPercentage;
        }

        private void worker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            label_status.Text = "Idle";
            progress.Value = 0;

            String[] files = Directory.GetFiles(temp, "*.png");

            for (int i = 0; i < files.Length; i++)
                list_frames.Items.Add((i+1).ToString());
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { // If can't do it just forget about it, not a big deal
                for (var i = list_frames.SelectedIndices.Count - 1; i >= 0; i--) {
                    var index = list_frames.SelectedIndices[i];
                    File.Delete((temp + list_frames.Items[index] + ".png").Replace("\\\\", "\\"));
                    list_frames.Items.RemoveAt(index);
                }
            }
            catch { }
        }

        private void list_frames_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Delete)
                deleteToolStripMenuItem_Click(sender, e);
        }

        private void button_done_Click(object sender, EventArgs e)
        {
            // Move each file for consecutive file naming
            for (var i = 0; i < list_frames.Items.Count; i++) {
                try {
                    File.Move(temp + list_frames.Items[i] + ".png", temp + "f_" + (i+1).ToString() + ".png");
                }
                catch { }
            }

            // Clear list for next use
            list_frames.Items.Clear();

            // Set args for ffmpeg
            args = text_ffmpeg_args.Text.Replace("%fps%", numeric_fps.Value.ToString())
                                        .Replace("%bitrate%", text_bitrate.Text);

            // Let main form know we're done
            done = true;

            // Finally close
            Close();
        }

        private void button_fps_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Higher frames per second for faster moving picture.", "FPS Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_bitrate_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Higher bitrate for higher quality but also increases file size.", "Bitrate Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}
