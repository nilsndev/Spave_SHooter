namespace Spave_SHooter.Forms
{
    partial class score_form
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
            this.score_label1 = new System.Windows.Forms.Label();
            this.throphe_PB1 = new System.Windows.Forms.PictureBox();
            this.load_score_timer1 = new System.Windows.Forms.Timer(this.components);
            this.continue_button1 = new System.Windows.Forms.Label();
            this.exit_button1 = new System.Windows.Forms.Label();
            this.skip_button1 = new System.Windows.Forms.Label();
            this.new_HighSCore_label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.throphe_PB1)).BeginInit();
            this.SuspendLayout();
            // 
            // score_label1
            // 
            this.score_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_label1.ForeColor = System.Drawing.Color.White;
            this.score_label1.Location = new System.Drawing.Point(797, 503);
            this.score_label1.Name = "score_label1";
            this.score_label1.Size = new System.Drawing.Size(354, 152);
            this.score_label1.TabIndex = 0;
            this.score_label1.Text = "0";
            this.score_label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // throphe_PB1
            // 
            this.throphe_PB1.Image = global::Spave_SHooter.Properties.Resources.better_Throphy;
            this.throphe_PB1.Location = new System.Drawing.Point(764, 54);
            this.throphe_PB1.Name = "throphe_PB1";
            this.throphe_PB1.Size = new System.Drawing.Size(400, 400);
            this.throphe_PB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.throphe_PB1.TabIndex = 3;
            this.throphe_PB1.TabStop = false;
            // 
            // load_score_timer1
            // 
            this.load_score_timer1.Interval = 20;
            this.load_score_timer1.Tick += new System.EventHandler(this.load_score_timer1_Tick);
            // 
            // continue_button1
            // 
            this.continue_button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.continue_button1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.continue_button1.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continue_button1.Location = new System.Drawing.Point(655, 787);
            this.continue_button1.Name = "continue_button1";
            this.continue_button1.Size = new System.Drawing.Size(598, 236);
            this.continue_button1.TabIndex = 5;
            this.continue_button1.Text = "Continue";
            this.continue_button1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.continue_button1.Click += new System.EventHandler(this.continue_button1_Click);
            // 
            // exit_button1
            // 
            this.exit_button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.exit_button1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.exit_button1.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button1.Location = new System.Drawing.Point(1713, 0);
            this.exit_button1.Name = "exit_button1";
            this.exit_button1.Size = new System.Drawing.Size(195, 113);
            this.exit_button1.TabIndex = 6;
            this.exit_button1.Text = "Exit";
            this.exit_button1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exit_button1.Click += new System.EventHandler(this.exit_button1_Click);
            // 
            // skip_button1
            // 
            this.skip_button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.skip_button1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.skip_button1.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skip_button1.Location = new System.Drawing.Point(1244, 565);
            this.skip_button1.Name = "skip_button1";
            this.skip_button1.Size = new System.Drawing.Size(159, 66);
            this.skip_button1.TabIndex = 7;
            this.skip_button1.Text = "Skip";
            this.skip_button1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.skip_button1.Click += new System.EventHandler(this.skip_button1_Click);
            // 
            // new_HighSCore_label1
            // 
            this.new_HighSCore_label1.AutoSize = true;
            this.new_HighSCore_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_HighSCore_label1.ForeColor = System.Drawing.Color.White;
            this.new_HighSCore_label1.Location = new System.Drawing.Point(865, 655);
            this.new_HighSCore_label1.Name = "new_HighSCore_label1";
            this.new_HighSCore_label1.Size = new System.Drawing.Size(205, 25);
            this.new_HighSCore_label1.TabIndex = 8;
            this.new_HighSCore_label1.Text = "NEW HIGHSCORE";
            this.new_HighSCore_label1.Visible = false;
            // 
            // score_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.new_HighSCore_label1);
            this.Controls.Add(this.skip_button1);
            this.Controls.Add(this.exit_button1);
            this.Controls.Add(this.continue_button1);
            this.Controls.Add(this.throphe_PB1);
            this.Controls.Add(this.score_label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "score_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "score_form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.score_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.throphe_PB1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label score_label1;
        private System.Windows.Forms.PictureBox throphe_PB1;
        private System.Windows.Forms.Timer load_score_timer1;
        private System.Windows.Forms.Label continue_button1;
        private System.Windows.Forms.Label exit_button1;
        private System.Windows.Forms.Label skip_button1;
        private System.Windows.Forms.Label new_HighSCore_label1;
    }
}