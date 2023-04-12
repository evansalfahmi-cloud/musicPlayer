namespace MusicPlayer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tombolPreviouse = new System.Windows.Forms.Button();
            this.tombolNext = new System.Windows.Forms.Button();
            this.tombolPlay = new System.Windows.Forms.Button();
            this.tombolPause = new System.Windows.Forms.Button();
            this.tombolStop = new System.Windows.Forms.Button();
            this.tombolOpen = new System.Windows.Forms.Button();
            this.progressBarPlaying = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trackList = new System.Windows.Forms.ListBox();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.volumeBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.volumeTrack = new System.Windows.Forms.Label();
            this.labelTrackStart = new System.Windows.Forms.Label();
            this.labelTrackEnd = new System.Windows.Forms.Label();
            this.timerPlaying = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).BeginInit();
            this.SuspendLayout();
            // 
            // tombolPreviouse
            // 
            this.tombolPreviouse.Font = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolPreviouse.Location = new System.Drawing.Point(8, 189);
            this.tombolPreviouse.Margin = new System.Windows.Forms.Padding(2);
            this.tombolPreviouse.Name = "tombolPreviouse";
            this.tombolPreviouse.Size = new System.Drawing.Size(58, 23);
            this.tombolPreviouse.TabIndex = 0;
            this.tombolPreviouse.Text = "previous";
            this.tombolPreviouse.UseVisualStyleBackColor = true;
            this.tombolPreviouse.Click += new System.EventHandler(this.tombolPreviouse_Click);
            // 
            // tombolNext
            // 
            this.tombolNext.Font = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolNext.Location = new System.Drawing.Point(70, 189);
            this.tombolNext.Margin = new System.Windows.Forms.Padding(2);
            this.tombolNext.Name = "tombolNext";
            this.tombolNext.Size = new System.Drawing.Size(58, 23);
            this.tombolNext.TabIndex = 1;
            this.tombolNext.Text = "next";
            this.tombolNext.UseVisualStyleBackColor = true;
            this.tombolNext.Click += new System.EventHandler(this.tombolNext_Click);
            // 
            // tombolPlay
            // 
            this.tombolPlay.Font = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolPlay.Location = new System.Drawing.Point(132, 189);
            this.tombolPlay.Margin = new System.Windows.Forms.Padding(2);
            this.tombolPlay.Name = "tombolPlay";
            this.tombolPlay.Size = new System.Drawing.Size(58, 23);
            this.tombolPlay.TabIndex = 2;
            this.tombolPlay.Text = "play";
            this.tombolPlay.UseVisualStyleBackColor = true;
            this.tombolPlay.Click += new System.EventHandler(this.tombolPlay_Click);
            // 
            // tombolPause
            // 
            this.tombolPause.Font = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolPause.Location = new System.Drawing.Point(194, 189);
            this.tombolPause.Margin = new System.Windows.Forms.Padding(2);
            this.tombolPause.Name = "tombolPause";
            this.tombolPause.Size = new System.Drawing.Size(58, 23);
            this.tombolPause.TabIndex = 3;
            this.tombolPause.Text = "pause";
            this.tombolPause.UseVisualStyleBackColor = true;
            this.tombolPause.Click += new System.EventHandler(this.tombolPause_Click);
            // 
            // tombolStop
            // 
            this.tombolStop.Font = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolStop.Location = new System.Drawing.Point(256, 189);
            this.tombolStop.Margin = new System.Windows.Forms.Padding(2);
            this.tombolStop.Name = "tombolStop";
            this.tombolStop.Size = new System.Drawing.Size(58, 23);
            this.tombolStop.TabIndex = 4;
            this.tombolStop.Text = "stop";
            this.tombolStop.UseVisualStyleBackColor = true;
            this.tombolStop.Click += new System.EventHandler(this.tombolStop_Click);
            // 
            // tombolOpen
            // 
            this.tombolOpen.Font = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolOpen.Location = new System.Drawing.Point(318, 189);
            this.tombolOpen.Margin = new System.Windows.Forms.Padding(2);
            this.tombolOpen.Name = "tombolOpen";
            this.tombolOpen.Size = new System.Drawing.Size(58, 23);
            this.tombolOpen.TabIndex = 5;
            this.tombolOpen.Text = "open";
            this.tombolOpen.UseVisualStyleBackColor = true;
            this.tombolOpen.Click += new System.EventHandler(this.tombolOpen_Click);
            // 
            // progressBarPlaying
            // 
            this.progressBarPlaying.Location = new System.Drawing.Point(8, 174);
            this.progressBarPlaying.Name = "progressBarPlaying";
            this.progressBarPlaying.Size = new System.Drawing.Size(368, 10);
            this.progressBarPlaying.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // trackList
            // 
            this.trackList.FormattingEnabled = true;
            this.trackList.ItemHeight = 14;
            this.trackList.Location = new System.Drawing.Point(134, 48);
            this.trackList.Name = "trackList";
            this.trackList.Size = new System.Drawing.Size(207, 116);
            this.trackList.TabIndex = 7;
            this.trackList.SelectedIndexChanged += new System.EventHandler(this.trackList_SelectedIndexChanged);
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(-3, 2);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(395, 40);
            this.player.TabIndex = 9;
            // 
            // volumeBar
            // 
            this.volumeBar.Location = new System.Drawing.Point(347, 61);
            this.volumeBar.Maximum = 100;
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.volumeBar.Size = new System.Drawing.Size(45, 96);
            this.volumeBar.TabIndex = 10;
            this.volumeBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Pro Display", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 11);
            this.label1.TabIndex = 11;
            this.label1.Text = "volume";
            // 
            // volumeTrack
            // 
            this.volumeTrack.AutoSize = true;
            this.volumeTrack.Font = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volumeTrack.Location = new System.Drawing.Point(350, 50);
            this.volumeTrack.Name = "volumeTrack";
            this.volumeTrack.Size = new System.Drawing.Size(26, 14);
            this.volumeTrack.TabIndex = 12;
            this.volumeTrack.Text = "100";
            // 
            // labelTrackStart
            // 
            this.labelTrackStart.AutoSize = true;
            this.labelTrackStart.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrackStart.Location = new System.Drawing.Point(9, 12);
            this.labelTrackStart.Name = "labelTrackStart";
            this.labelTrackStart.Size = new System.Drawing.Size(53, 19);
            this.labelTrackStart.TabIndex = 13;
            this.labelTrackStart.Text = "00:00";
            // 
            // labelTrackEnd
            // 
            this.labelTrackEnd.AutoSize = true;
            this.labelTrackEnd.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrackEnd.Location = new System.Drawing.Point(323, 12);
            this.labelTrackEnd.Name = "labelTrackEnd";
            this.labelTrackEnd.Size = new System.Drawing.Size(53, 19);
            this.labelTrackEnd.TabIndex = 14;
            this.labelTrackEnd.Text = "00:00";
            // 
            // timerPlaying
            // 
            this.timerPlaying.Enabled = true;
            this.timerPlaying.Tick += new System.EventHandler(this.timerPlaying_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 227);
            this.Controls.Add(this.labelTrackEnd);
            this.Controls.Add(this.labelTrackStart);
            this.Controls.Add(this.volumeTrack);
            this.Controls.Add(this.trackList);
            this.Controls.Add(this.player);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.volumeBar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progressBarPlaying);
            this.Controls.Add(this.tombolOpen);
            this.Controls.Add(this.tombolStop);
            this.Controls.Add(this.tombolPause);
            this.Controls.Add(this.tombolPlay);
            this.Controls.Add(this.tombolNext);
            this.Controls.Add(this.tombolPreviouse);
            this.Font = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tombolPreviouse;
        private System.Windows.Forms.Button tombolNext;
        private System.Windows.Forms.Button tombolPlay;
        private System.Windows.Forms.Button tombolPause;
        private System.Windows.Forms.Button tombolStop;
        private System.Windows.Forms.Button tombolOpen;
        private System.Windows.Forms.ProgressBar progressBarPlaying;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox trackList;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.TrackBar volumeBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label volumeTrack;
        private System.Windows.Forms.Label labelTrackStart;
        private System.Windows.Forms.Label labelTrackEnd;
        private System.Windows.Forms.Timer timerPlaying;
    }
}

