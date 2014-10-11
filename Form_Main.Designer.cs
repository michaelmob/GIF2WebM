namespace GIF2WebM
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.label_drag = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.linksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_item_link_author = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_item_link_github = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_item_link_ffmpeg = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_item_browse = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_item_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_drag
            // 
            this.label_drag.AllowDrop = true;
            this.label_drag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_drag.Location = new System.Drawing.Point(0, 24);
            this.label_drag.Name = "label_drag";
            this.label_drag.Size = new System.Drawing.Size(306, 206);
            this.label_drag.TabIndex = 0;
            this.label_drag.Text = "Drag and Drop GIFs";
            this.label_drag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_drag.DragDrop += new System.Windows.Forms.DragEventHandler(this.label_drag_DragDrop);
            this.label_drag.DragEnter += new System.Windows.Forms.DragEventHandler(this.label_drag_DragEnter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.linksToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(306, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // linksToolStripMenuItem
            // 
            this.linksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_item_link_author,
            this.menu_item_link_github,
            this.menu_item_link_ffmpeg});
            this.linksToolStripMenuItem.Name = "linksToolStripMenuItem";
            this.linksToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.linksToolStripMenuItem.Text = "Links";
            // 
            // menu_item_link_author
            // 
            this.menu_item_link_author.Name = "menu_item_link_author";
            this.menu_item_link_author.Size = new System.Drawing.Size(152, 22);
            this.menu_item_link_author.Text = "MikeServer";
            this.menu_item_link_author.Click += new System.EventHandler(this.menu_item_link_author_Click);
            // 
            // menu_item_link_github
            // 
            this.menu_item_link_github.Name = "menu_item_link_github";
            this.menu_item_link_github.Size = new System.Drawing.Size(152, 22);
            this.menu_item_link_github.Text = "GitHub";
            this.menu_item_link_github.Click += new System.EventHandler(this.menu_item_link_github_Click);
            // 
            // menu_item_link_ffmpeg
            // 
            this.menu_item_link_ffmpeg.Name = "menu_item_link_ffmpeg";
            this.menu_item_link_ffmpeg.Size = new System.Drawing.Size(152, 22);
            this.menu_item_link_ffmpeg.Text = "FFmpeg";
            this.menu_item_link_ffmpeg.Click += new System.EventHandler(this.menu_item_link_ffmpeg_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_item_browse,
            this.toolStripMenuItem1,
            this.menu_item_exit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menu_item_browse
            // 
            this.menu_item_browse.Name = "menu_item_browse";
            this.menu_item_browse.Size = new System.Drawing.Size(152, 22);
            this.menu_item_browse.Text = "Browse";
            this.menu_item_browse.Click += new System.EventHandler(this.menu_item_browse_Click);
            // 
            // menu_item_exit
            // 
            this.menu_item_exit.Name = "menu_item_exit";
            this.menu_item_exit.Size = new System.Drawing.Size(152, 22);
            this.menu_item_exit.Text = "Exit";
            this.menu_item_exit.Click += new System.EventHandler(this.menu_item_exit_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 230);
            this.Controls.Add(this.label_drag);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Main";
            this.Text = "GIF2WebM v1.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_drag;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_item_browse;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menu_item_exit;
        private System.Windows.Forms.ToolStripMenuItem linksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_item_link_author;
        private System.Windows.Forms.ToolStripMenuItem menu_item_link_github;
        private System.Windows.Forms.ToolStripMenuItem menu_item_link_ffmpeg;

    }
}

