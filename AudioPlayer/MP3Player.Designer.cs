namespace AudioPlayer
{
    partial class MP3Player
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MP3Player));
            this.open_button = new System.Windows.Forms.Button();
            this.preview_button = new System.Windows.Forms.Button();
            this.play_button = new System.Windows.Forms.Button();
            this.pause_button = new System.Windows.Forms.Button();
            this.next_button = new System.Windows.Forms.Button();
            this.stop_button = new System.Windows.Forms.Button();
            this.track_list = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.p_bar = new System.Windows.Forms.ProgressBar();
            this.label_track_start = new System.Windows.Forms.Label();
            this.label_track_end = new System.Windows.Forms.Label();
            this.track_volume = new System.Windows.Forms.TrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.label_volume = new System.Windows.Forms.Label();
            this.delete_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.track_volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // open_button
            // 
            this.open_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("open_button.BackgroundImage")));
            this.open_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.open_button.FlatAppearance.BorderSize = 0;
            this.open_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.open_button.Location = new System.Drawing.Point(275, 250);
            this.open_button.Name = "open_button";
            this.open_button.Size = new System.Drawing.Size(34, 23);
            this.open_button.TabIndex = 1;
            this.open_button.UseVisualStyleBackColor = true;
            this.open_button.Click += new System.EventHandler(this.open_button_Click);
            // 
            // preview_button
            // 
            this.preview_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("preview_button.BackgroundImage")));
            this.preview_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.preview_button.FlatAppearance.BorderSize = 0;
            this.preview_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.preview_button.Location = new System.Drawing.Point(7, 279);
            this.preview_button.Name = "preview_button";
            this.preview_button.Size = new System.Drawing.Size(34, 23);
            this.preview_button.TabIndex = 3;
            this.preview_button.UseVisualStyleBackColor = true;
            this.preview_button.Click += new System.EventHandler(this.preview_button_Click);
            // 
            // play_button
            // 
            this.play_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("play_button.BackgroundImage")));
            this.play_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.play_button.FlatAppearance.BorderSize = 0;
            this.play_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play_button.Location = new System.Drawing.Point(64, 279);
            this.play_button.Name = "play_button";
            this.play_button.Size = new System.Drawing.Size(34, 23);
            this.play_button.TabIndex = 7;
            this.play_button.UseVisualStyleBackColor = true;
            this.play_button.Click += new System.EventHandler(this.play_button_Click);
            // 
            // pause_button
            // 
            this.pause_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pause_button.BackgroundImage")));
            this.pause_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pause_button.FlatAppearance.BorderSize = 0;
            this.pause_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pause_button.Location = new System.Drawing.Point(118, 279);
            this.pause_button.Name = "pause_button";
            this.pause_button.Size = new System.Drawing.Size(34, 23);
            this.pause_button.TabIndex = 8;
            this.pause_button.UseVisualStyleBackColor = true;
            this.pause_button.Click += new System.EventHandler(this.pause_button_Click);
            // 
            // next_button
            // 
            this.next_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("next_button.BackgroundImage")));
            this.next_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.next_button.FlatAppearance.BorderSize = 0;
            this.next_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next_button.Location = new System.Drawing.Point(228, 279);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(34, 23);
            this.next_button.TabIndex = 9;
            this.next_button.UseVisualStyleBackColor = true;
            this.next_button.Click += new System.EventHandler(this.next_button_Click);
            // 
            // stop_button
            // 
            this.stop_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stop_button.BackgroundImage")));
            this.stop_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.stop_button.FlatAppearance.BorderSize = 0;
            this.stop_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop_button.Location = new System.Drawing.Point(174, 279);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(34, 23);
            this.stop_button.TabIndex = 10;
            this.stop_button.UseVisualStyleBackColor = true;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // track_list
            // 
            this.track_list.BackColor = System.Drawing.Color.White;
            this.track_list.FormattingEnabled = true;
            this.track_list.ItemHeight = 16;
            this.track_list.Location = new System.Drawing.Point(7, 308);
            this.track_list.Name = "track_list";
            this.track_list.Size = new System.Drawing.Size(305, 292);
            this.track_list.TabIndex = 11;
            this.track_list.SelectedIndexChanged += new System.EventHandler(this.track_list_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // p_bar
            // 
            this.p_bar.Location = new System.Drawing.Point(7, 263);
            this.p_bar.Name = "p_bar";
            this.p_bar.Size = new System.Drawing.Size(255, 10);
            this.p_bar.TabIndex = 14;
            this.p_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_bar_MouseDown);
            // 
            // label_track_start
            // 
            this.label_track_start.AutoSize = true;
            this.label_track_start.Location = new System.Drawing.Point(4, 244);
            this.label_track_start.Name = "label_track_start";
            this.label_track_start.Size = new System.Drawing.Size(38, 16);
            this.label_track_start.TabIndex = 15;
            this.label_track_start.Text = "00:00";
            // 
            // label_track_end
            // 
            this.label_track_end.AutoSize = true;
            this.label_track_end.Location = new System.Drawing.Point(228, 244);
            this.label_track_end.Name = "label_track_end";
            this.label_track_end.Size = new System.Drawing.Size(38, 16);
            this.label_track_end.TabIndex = 16;
            this.label_track_end.Text = "00:00";
            // 
            // track_volume
            // 
            this.track_volume.Location = new System.Drawing.Point(270, 122);
            this.track_volume.Maximum = 100;
            this.track_volume.Name = "track_volume";
            this.track_volume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.track_volume.Size = new System.Drawing.Size(56, 119);
            this.track_volume.TabIndex = 17;
            this.track_volume.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.track_volume.Scroll += new System.EventHandler(this.track_volume_Scroll);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(9, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 213);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // player
            // 
            this.player.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.player.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.player.CausesValidation = false;
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(11, 523);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(255, 38);
            this.player.TabIndex = 13;
            // 
            // label_volume
            // 
            this.label_volume.AutoSize = true;
            this.label_volume.Location = new System.Drawing.Point(281, 106);
            this.label_volume.Name = "label_volume";
            this.label_volume.Size = new System.Drawing.Size(33, 16);
            this.label_volume.TabIndex = 19;
            this.label_volume.Text = "30%";
            // 
            // delete_button
            // 
            this.delete_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delete_button.BackgroundImage")));
            this.delete_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.delete_button.FlatAppearance.BorderSize = 0;
            this.delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_button.Location = new System.Drawing.Point(275, 279);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(34, 23);
            this.delete_button.TabIndex = 20;
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // MP3Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(319, 604);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.label_volume);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.track_volume);
            this.Controls.Add(this.label_track_end);
            this.Controls.Add(this.label_track_start);
            this.Controls.Add(this.p_bar);
            this.Controls.Add(this.track_list);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.next_button);
            this.Controls.Add(this.pause_button);
            this.Controls.Add(this.play_button);
            this.Controls.Add(this.preview_button);
            this.Controls.Add(this.open_button);
            this.Controls.Add(this.player);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MP3Player";
            this.Text = "MP3Player";
            ((System.ComponentModel.ISupportInitialize)(this.track_volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button open_button;
        private System.Windows.Forms.Button preview_button;
        private System.Windows.Forms.Button play_button;
        private System.Windows.Forms.Button pause_button;
        private System.Windows.Forms.Button next_button;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.ListBox track_list;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar p_bar;
        private System.Windows.Forms.Label label_track_start;
        private System.Windows.Forms.Label label_track_end;
        private System.Windows.Forms.TrackBar track_volume;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_volume;
        private System.Windows.Forms.Button delete_button;
    }
}

