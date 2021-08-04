namespace Rokkit_Media_Player
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelNavigation = new System.Windows.Forms.Panel();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.AlbumButton = new System.Windows.Forms.Button();
            this.ArtistsButton = new System.Windows.Forms.Button();
            this.TracksButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuStripFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseButton = new System.Windows.Forms.Button();
            this.DraggablePanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.DraggablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.PanelNavigation);
            this.panel1.Controls.Add(this.SettingsButton);
            this.panel1.Controls.Add(this.AlbumButton);
            this.panel1.Controls.Add(this.ArtistsButton);
            this.panel1.Controls.Add(this.TracksButton);
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 730);
            this.panel1.TabIndex = 0;
            // 
            // PanelNavigation
            // 
            this.PanelNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.PanelNavigation.Location = new System.Drawing.Point(0, 0);
            this.PanelNavigation.Name = "PanelNavigation";
            this.PanelNavigation.Size = new System.Drawing.Size(3, 45);
            this.PanelNavigation.TabIndex = 5;
            // 
            // SettingsButton
            // 
            this.SettingsButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SettingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.SettingsButton.Location = new System.Drawing.Point(0, 685);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(180, 45);
            this.SettingsButton.TabIndex = 4;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            this.SettingsButton.Leave += new System.EventHandler(this.SettingsButton_Leave);
            // 
            // AlbumButton
            // 
            this.AlbumButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AlbumButton.FlatAppearance.BorderSize = 0;
            this.AlbumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AlbumButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AlbumButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.AlbumButton.Location = new System.Drawing.Point(0, 90);
            this.AlbumButton.Name = "AlbumButton";
            this.AlbumButton.Size = new System.Drawing.Size(180, 45);
            this.AlbumButton.TabIndex = 4;
            this.AlbumButton.Text = "Album";
            this.AlbumButton.UseVisualStyleBackColor = true;
            this.AlbumButton.Click += new System.EventHandler(this.AlbumButton_Click);
            this.AlbumButton.Leave += new System.EventHandler(this.AlbumButton_Leave);
            // 
            // ArtistsButton
            // 
            this.ArtistsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ArtistsButton.FlatAppearance.BorderSize = 0;
            this.ArtistsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ArtistsButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ArtistsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ArtistsButton.Location = new System.Drawing.Point(0, 45);
            this.ArtistsButton.Name = "ArtistsButton";
            this.ArtistsButton.Size = new System.Drawing.Size(180, 45);
            this.ArtistsButton.TabIndex = 4;
            this.ArtistsButton.Text = "Artists";
            this.ArtistsButton.UseVisualStyleBackColor = true;
            this.ArtistsButton.Click += new System.EventHandler(this.ArtistsButton_Click);
            this.ArtistsButton.Leave += new System.EventHandler(this.ArtistsButton_Leave);
            // 
            // TracksButton
            // 
            this.TracksButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.TracksButton.FlatAppearance.BorderSize = 0;
            this.TracksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TracksButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TracksButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.TracksButton.Location = new System.Drawing.Point(0, 0);
            this.TracksButton.Name = "TracksButton";
            this.TracksButton.Size = new System.Drawing.Size(180, 45);
            this.TracksButton.TabIndex = 4;
            this.TracksButton.Text = "Tracks";
            this.TracksButton.UseVisualStyleBackColor = true;
            this.TracksButton.Click += new System.EventHandler(this.TracksButton_Click);
            this.TracksButton.Leave += new System.EventHandler(this.TracksButton_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripFiles,
            this.menuStripView,
            this.menuStripHelp});
            this.menuStrip2.Location = new System.Drawing.Point(54, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(206, 36);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuStripFiles
            // 
            this.menuStripFiles.BackColor = System.Drawing.Color.Transparent;
            this.menuStripFiles.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStripFiles.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStripFiles.Name = "menuStripFiles";
            this.menuStripFiles.Size = new System.Drawing.Size(64, 32);
            this.menuStripFiles.Text = "Files";
            // 
            // menuStripView
            // 
            this.menuStripView.BackColor = System.Drawing.Color.Transparent;
            this.menuStripView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStripView.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStripView.Name = "menuStripView";
            this.menuStripView.Size = new System.Drawing.Size(67, 32);
            this.menuStripView.Text = "View";
            // 
            // menuStripHelp
            // 
            this.menuStripHelp.BackColor = System.Drawing.Color.Transparent;
            this.menuStripHelp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStripHelp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStripHelp.Name = "menuStripHelp";
            this.menuStripHelp.Size = new System.Drawing.Size(67, 32);
            this.menuStripHelp.Text = "Help";
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.CloseButton.Location = new System.Drawing.Point(1358, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(30, 30);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // DraggablePanel
            // 
            this.DraggablePanel.Controls.Add(this.CloseButton);
            this.DraggablePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DraggablePanel.Location = new System.Drawing.Point(0, 0);
            this.DraggablePanel.Name = "DraggablePanel";
            this.DraggablePanel.Size = new System.Drawing.Size(1400, 43);
            this.DraggablePanel.TabIndex = 4;
            this.DraggablePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DraggablePanel_MouseDown);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(179, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1221, 642);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.Text = "dataGridView1";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1400, 780);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DraggablePanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(10, 10);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1400, 780);
            this.Name = "Form1";
            this.Text = "Rokkit";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.DraggablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem menuStripFiles;
        private System.Windows.Forms.ToolStripMenuItem menuStripView;
        private System.Windows.Forms.ToolStripMenuItem menuStripHelp;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button AlbumButton;
        private System.Windows.Forms.Button ArtistsButton;
        private System.Windows.Forms.Button TracksButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Panel PanelNavigation;
        private System.Windows.Forms.Panel DraggablePanel;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

