namespace MediaCtrl
{
    partial class MediaCtrlForm
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
            this.VolumeUpBtn = new System.Windows.Forms.Button();
            this.VolDownBtn = new System.Windows.Forms.Button();
            this.volumeBar = new MediaCtrl.VerticalProgressBar();
            this.MuteBtn = new System.Windows.Forms.Button();
            this.PlayPauseBtn = new System.Windows.Forms.Button();
            this.PrevBtn = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VolumeUpBtn
            // 
            this.VolumeUpBtn.Location = new System.Drawing.Point(41, 12);
            this.VolumeUpBtn.Name = "VolumeUpBtn";
            this.VolumeUpBtn.Size = new System.Drawing.Size(75, 23);
            this.VolumeUpBtn.TabIndex = 0;
            this.VolumeUpBtn.Text = "Vol +";
            this.VolumeUpBtn.UseVisualStyleBackColor = true;
            this.VolumeUpBtn.Click += new System.EventHandler(this.VolUpBtn_Click);
            // 
            // VolDownBtn
            // 
            this.VolDownBtn.Location = new System.Drawing.Point(41, 41);
            this.VolDownBtn.Name = "VolDownBtn";
            this.VolDownBtn.Size = new System.Drawing.Size(75, 23);
            this.VolDownBtn.TabIndex = 1;
            this.VolDownBtn.Text = "Vol -";
            this.VolDownBtn.UseVisualStyleBackColor = true;
            this.VolDownBtn.Click += new System.EventHandler(this.VolDownBtn_Click);
            // 
            // volumeBar
            // 
            this.volumeBar.Location = new System.Drawing.Point(12, 12);
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.Size = new System.Drawing.Size(23, 81);
            this.volumeBar.Step = 1;
            this.volumeBar.TabIndex = 2;
            // 
            // MuteBtn
            // 
            this.MuteBtn.Location = new System.Drawing.Point(41, 70);
            this.MuteBtn.Name = "MuteBtn";
            this.MuteBtn.Size = new System.Drawing.Size(75, 23);
            this.MuteBtn.TabIndex = 3;
            this.MuteBtn.Text = "Mute";
            this.MuteBtn.UseVisualStyleBackColor = true;
            this.MuteBtn.Click += new System.EventHandler(this.MuteBtn_Click);
            // 
            // PlayPauseBtn
            // 
            this.PlayPauseBtn.Location = new System.Drawing.Point(203, 41);
            this.PlayPauseBtn.Name = "PlayPauseBtn";
            this.PlayPauseBtn.Size = new System.Drawing.Size(75, 23);
            this.PlayPauseBtn.TabIndex = 4;
            this.PlayPauseBtn.Text = "Play/Pause";
            this.PlayPauseBtn.UseVisualStyleBackColor = true;
            this.PlayPauseBtn.Click += new System.EventHandler(this.PlayPauseBtn_Click);
            // 
            // PrevBtn
            // 
            this.PrevBtn.Location = new System.Drawing.Point(122, 41);
            this.PrevBtn.Name = "PrevBtn";
            this.PrevBtn.Size = new System.Drawing.Size(75, 23);
            this.PrevBtn.TabIndex = 5;
            this.PrevBtn.Text = "Prev";
            this.PrevBtn.UseVisualStyleBackColor = true;
            this.PrevBtn.Click += new System.EventHandler(this.PrevBtn_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.Location = new System.Drawing.Point(284, 41);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(75, 23);
            this.NextBtn.TabIndex = 6;
            this.NextBtn.Text = "Next";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // MediaCtrlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(374, 107);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.PrevBtn);
            this.Controls.Add(this.PlayPauseBtn);
            this.Controls.Add(this.MuteBtn);
            this.Controls.Add(this.volumeBar);
            this.Controls.Add(this.VolDownBtn);
            this.Controls.Add(this.VolumeUpBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MediaCtrlForm";
            this.ShowIcon = false;
            this.Text = "MediaCtrl";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button VolumeUpBtn;
        private System.Windows.Forms.Button VolDownBtn;
        private VerticalProgressBar volumeBar;
        private System.Windows.Forms.Button MuteBtn;
        private System.Windows.Forms.Button PlayPauseBtn;
        private System.Windows.Forms.Button PrevBtn;
        private System.Windows.Forms.Button NextBtn;
    }
}

