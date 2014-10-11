namespace GIF2WebM
{
    partial class Form_Convert
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Convert));
            this.list_frames = new System.Windows.Forms.ListBox();
            this.frames_context = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.split_container = new System.Windows.Forms.SplitContainer();
            this.numeric_fps = new System.Windows.Forms.NumericUpDown();
            this.text_bitrate = new System.Windows.Forms.TextBox();
            this.label_fps = new System.Windows.Forms.Label();
            this.label_bitrate = new System.Windows.Forms.Label();
            this.text_ffmpeg_args = new System.Windows.Forms.TextBox();
            this.label_status = new System.Windows.Forms.Label();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.preview = new System.Windows.Forms.PictureBox();
            this.button_done = new System.Windows.Forms.Button();
            this.worker = new System.ComponentModel.BackgroundWorker();
            this.button_fps_help = new System.Windows.Forms.Button();
            this.button_bitrate_help = new System.Windows.Forms.Button();
            this.frames_context.SuspendLayout();
            //((System.ComponentModel.ISupportInitialize)(this.split_container)).BeginInit();
            this.split_container.Panel1.SuspendLayout();
            this.split_container.Panel2.SuspendLayout();
            this.split_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_fps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preview)).BeginInit();
            this.SuspendLayout();
            // 
            // list_frames
            // 
            this.list_frames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_frames.ContextMenuStrip = this.frames_context;
            this.list_frames.FormattingEnabled = true;
            this.list_frames.Location = new System.Drawing.Point(2, 2);
            this.list_frames.Name = "list_frames";
            this.list_frames.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.list_frames.Size = new System.Drawing.Size(213, 316);
            this.list_frames.TabIndex = 0;
            this.list_frames.SelectedIndexChanged += new System.EventHandler(this.list_frames_SelectedIndexChanged);
            this.list_frames.KeyDown += new System.Windows.Forms.KeyEventHandler(this.list_frames_KeyDown);
            // 
            // frames_context
            // 
            this.frames_context.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.frames_context.Name = "frames_context";
            this.frames_context.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // split_container
            // 
            this.split_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split_container.Location = new System.Drawing.Point(0, 0);
            this.split_container.Name = "split_container";
            // 
            // split_container.Panel1
            // 
            this.split_container.Panel1.Controls.Add(this.button_bitrate_help);
            this.split_container.Panel1.Controls.Add(this.button_fps_help);
            this.split_container.Panel1.Controls.Add(this.numeric_fps);
            this.split_container.Panel1.Controls.Add(this.text_bitrate);
            this.split_container.Panel1.Controls.Add(this.label_fps);
            this.split_container.Panel1.Controls.Add(this.label_bitrate);
            this.split_container.Panel1.Controls.Add(this.text_ffmpeg_args);
            this.split_container.Panel1.Controls.Add(this.label_status);
            this.split_container.Panel1.Controls.Add(this.progress);
            this.split_container.Panel1.Controls.Add(this.list_frames);
            // 
            // split_container.Panel2
            // 
            this.split_container.Panel2.Controls.Add(this.preview);
            this.split_container.Panel2.Controls.Add(this.button_done);
            this.split_container.Size = new System.Drawing.Size(653, 419);
            this.split_container.SplitterDistance = 217;
            this.split_container.TabIndex = 1;
            // 
            // numeric_fps
            // 
            this.numeric_fps.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numeric_fps.Location = new System.Drawing.Point(71, 323);
            this.numeric_fps.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numeric_fps.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_fps.Name = "numeric_fps";
            this.numeric_fps.Size = new System.Drawing.Size(142, 20);
            this.numeric_fps.TabIndex = 8;
            this.numeric_fps.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // text_bitrate
            // 
            this.text_bitrate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_bitrate.Location = new System.Drawing.Point(71, 344);
            this.text_bitrate.Name = "text_bitrate";
            this.text_bitrate.Size = new System.Drawing.Size(142, 20);
            this.text_bitrate.TabIndex = 7;
            this.text_bitrate.Text = "2500k";
            // 
            // label_fps
            // 
            this.label_fps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_fps.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_fps.Location = new System.Drawing.Point(3, 320);
            this.label_fps.Name = "label_fps";
            this.label_fps.Size = new System.Drawing.Size(56, 22);
            this.label_fps.TabIndex = 6;
            this.label_fps.Text = "FPS:";
            this.label_fps.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_bitrate
            // 
            this.label_bitrate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_bitrate.Location = new System.Drawing.Point(3, 342);
            this.label_bitrate.Name = "label_bitrate";
            this.label_bitrate.Size = new System.Drawing.Size(56, 22);
            this.label_bitrate.TabIndex = 5;
            this.label_bitrate.Text = "Bitrate:";
            this.label_bitrate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // text_ffmpeg_args
            // 
            this.text_ffmpeg_args.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_ffmpeg_args.Location = new System.Drawing.Point(4, 367);
            this.text_ffmpeg_args.Name = "text_ffmpeg_args";
            this.text_ffmpeg_args.Size = new System.Drawing.Size(209, 20);
            this.text_ffmpeg_args.TabIndex = 3;
            this.text_ffmpeg_args.Text = "-i \"f_%d.png\" -vb %bitrate% -r %fps%";
            // 
            // label_status
            // 
            this.label_status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_status.Location = new System.Drawing.Point(139, 391);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(76, 23);
            this.label_status.TabIndex = 2;
            this.label_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progress
            // 
            this.progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progress.Location = new System.Drawing.Point(5, 391);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(128, 23);
            this.progress.TabIndex = 1;
            // 
            // preview
            // 
            this.preview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.preview.Location = new System.Drawing.Point(0, 0);
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(432, 391);
            this.preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.preview.TabIndex = 0;
            this.preview.TabStop = false;
            // 
            // button_done
            // 
            this.button_done.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_done.Location = new System.Drawing.Point(0, 391);
            this.button_done.Name = "button_done";
            this.button_done.Size = new System.Drawing.Size(432, 28);
            this.button_done.TabIndex = 1;
            this.button_done.Text = "Done";
            this.button_done.UseVisualStyleBackColor = true;
            this.button_done.Click += new System.EventHandler(this.button_done_Click);
            // 
            // worker
            // 
            this.worker.WorkerReportsProgress = true;
            this.worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.worker_DoWork);
            this.worker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.worker_ProgressChanged);
            this.worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.worker_RunWorkerCompleted);
            // 
            // button_fps_help
            // 
            this.button_fps_help.Location = new System.Drawing.Point(48, 323);
            this.button_fps_help.Name = "button_fps_help";
            this.button_fps_help.Size = new System.Drawing.Size(20, 20);
            this.button_fps_help.TabIndex = 9;
            this.button_fps_help.Text = "?";
            this.button_fps_help.UseVisualStyleBackColor = true;
            this.button_fps_help.Click += new System.EventHandler(this.button_fps_help_Click);
            // 
            // button_bitrate_help
            // 
            this.button_bitrate_help.Location = new System.Drawing.Point(48, 344);
            this.button_bitrate_help.Name = "button_bitrate_help";
            this.button_bitrate_help.Size = new System.Drawing.Size(20, 20);
            this.button_bitrate_help.TabIndex = 10;
            this.button_bitrate_help.Text = "?";
            this.button_bitrate_help.UseVisualStyleBackColor = true;
            this.button_bitrate_help.Click += new System.EventHandler(this.button_bitrate_help_Click);
            // 
            // Form_Convert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 419);
            this.Controls.Add(this.split_container);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Convert";
            this.Text = "Convert";
            this.Load += new System.EventHandler(this.Form_Convert_Load);
            this.Shown += new System.EventHandler(this.Form_Convert_Shown);
            this.frames_context.ResumeLayout(false);
            this.split_container.Panel1.ResumeLayout(false);
            this.split_container.Panel1.PerformLayout();
            this.split_container.Panel2.ResumeLayout(false);
            //((System.ComponentModel.ISupportInitialize)(this.split_container)).EndInit();
            this.split_container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_fps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox list_frames;
        private System.Windows.Forms.SplitContainer split_container;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.PictureBox preview;
        private System.ComponentModel.BackgroundWorker worker;
        private System.Windows.Forms.Button button_done;
        private System.Windows.Forms.ContextMenuStrip frames_context;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numeric_fps;
        private System.Windows.Forms.TextBox text_bitrate;
        private System.Windows.Forms.Label label_fps;
        private System.Windows.Forms.Label label_bitrate;
        private System.Windows.Forms.TextBox text_ffmpeg_args;
        private System.Windows.Forms.Button button_bitrate_help;
        private System.Windows.Forms.Button button_fps_help;
    }
}