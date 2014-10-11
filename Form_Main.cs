using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace GIF2WebM
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
            check_ffmpeg();
        }

        #region Checks
        Boolean check_ffmpeg()
        {
            if (!File.Exists(Directory.GetCurrentDirectory() + "\\ffmpeg.exe")) {
                MessageBox.Show(
                    "FFmpeg.exe could not be found! You cannot convert GIFs to WebMs without it! To go download it open the Links menu.",
                    "Here in my car",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }
            return true;
        }
        #endregion

        #region Main Menu
        // File
        private void menu_item_browse_Click(object sender, EventArgs e)
        {
            var open_file_dialog = new OpenFileDialog();
            open_file_dialog.Filter = "GIF|*.gif";
            open_file_dialog.Multiselect = true;

            if (open_file_dialog.ShowDialog() == DialogResult.OK) {
                verify(open_file_dialog.FileNames);
            }
        }
        private void menu_item_exit_Click(object sender, EventArgs e)
        { Environment.Exit(0); }

        // Links
        private void menu_item_link_author_Click(object sender, EventArgs e)
        { Process.Start("https://mikeserver.org/"); }
        private void menu_item_link_github_Click(object sender, EventArgs e)
        { Process.Start("https://github.com/thetarkus/GIF2WebM"); }
        private void menu_item_link_ffmpeg_Click(object sender, EventArgs e)
        { Process.Start("https://ffmpeg.org/"); }
        #endregion

        #region Drag and Drop
        private void label_drag_DragEnter(object sender, DragEventArgs e)
        {
            // Set effect if they're dragging in files and not something else
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop, false) ? DragDropEffects.All : DragDropEffects.None;
        }
        private void label_drag_DragDrop(object sender, DragEventArgs e)
        {
            var files = (string[])e.Data.GetData(DataFormats.FileDrop);
            verify(files);
        }
        #endregion

        #region Convert
        private void convert(Image gif)
        {
            // Open our converter as a dialog so we can't have more than one
            // running at a time
            var form_convert = new Form_Frames(gif);
            form_convert.ShowDialog();

            if (form_convert.done == true) {
                // Show dialog and only continue if OK.
			    var save = new SaveFileDialog();
			    save.Title = "Select a location and name for your webm";
			    save.Filter = "WebM (*.webm)|*.webm|All files (*.*)|*.*";

                if (save.ShowDialog() == DialogResult.OK) {
                    // Setup our process for conversion using ffmpeg
                    var ffmpeg = new ProcessStartInfo();
                    ffmpeg.WorkingDirectory = form_convert.temp;
                    ffmpeg.FileName = Directory.GetCurrentDirectory() + "\\ffmpeg.exe";
                    ffmpeg.Arguments = form_convert.args + " \"" + save.FileName + "\"";

                    Debug.WriteLine(ffmpeg.FileName + " " + ffmpeg.Arguments);

                    var process = new Process { StartInfo = ffmpeg };
                    process.Start();
                    process.WaitForExit();
                }
            }

            // Delete the directory afterwards since we don't need the
            // images anymore
            Directory.Delete(form_convert.temp, true);
        }

        private void verify(String[] filenames)
        {
            if (!check_ffmpeg())
                return;

            try {
                // Check to see that they're images
                foreach(var filename in filenames) {
                    Image.FromFile(filename);
                }
            }
            catch (Exception ex) {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("File input must be an animated GIF.", "The wind cannot hear", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Now that we've verified lets continue
            foreach(var filename in filenames) {
                convert(Image.FromFile(filename));
            }
        }
        #endregion

    }
}
