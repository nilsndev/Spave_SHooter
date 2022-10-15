namespace Spave_SHooter.Forms
{
    partial class LoadingScreen
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
            this.load_timer1 = new System.Windows.Forms.Timer(this.components);
            this.load_label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.title_label2 = new System.Windows.Forms.Label();
            this.fooder_label1 = new System.Windows.Forms.Label();
            this.sp_logo_roundPictureBox1 = new Spave_SHooter.Class.RoundPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sp_logo_roundPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // load_timer1
            // 
            this.load_timer1.Enabled = true;
            this.load_timer1.Interval = 150;
            this.load_timer1.Tick += new System.EventHandler(this.load_timer1_Tick);
            // 
            // load_label1
            // 
            this.load_label1.AutoSize = true;
            this.load_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load_label1.ForeColor = System.Drawing.Color.White;
            this.load_label1.Location = new System.Drawing.Point(47, 250);
            this.load_label1.Name = "load_label1";
            this.load_label1.Size = new System.Drawing.Size(326, 73);
            this.load_label1.TabIndex = 0;
            this.load_label1.Text = "Loading...";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Black;
            this.progressBar1.Location = new System.Drawing.Point(60, 340);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(679, 58);
            this.progressBar1.TabIndex = 1;
            // 
            // title_label2
            // 
            this.title_label2.AutoSize = true;
            this.title_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label2.ForeColor = System.Drawing.Color.White;
            this.title_label2.Location = new System.Drawing.Point(149, 9);
            this.title_label2.Name = "title_label2";
            this.title_label2.Size = new System.Drawing.Size(471, 73);
            this.title_label2.TabIndex = 2;
            this.title_label2.Text = "Space Shooter";
            // 
            // fooder_label1
            // 
            this.fooder_label1.AutoSize = true;
            this.fooder_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fooder_label1.ForeColor = System.Drawing.Color.White;
            this.fooder_label1.Location = new System.Drawing.Point(612, 420);
            this.fooder_label1.Name = "fooder_label1";
            this.fooder_label1.Size = new System.Drawing.Size(127, 31);
            this.fooder_label1.TabIndex = 3;
            this.fooder_label1.Text = "nilsNdev";
            // 
            // sp_logo_roundPictureBox1
            // 
            this.sp_logo_roundPictureBox1.Image = global::Spave_SHooter.Properties.Resources.sp_logo;
            this.sp_logo_roundPictureBox1.Location = new System.Drawing.Point(298, 107);
            this.sp_logo_roundPictureBox1.Name = "sp_logo_roundPictureBox1";
            this.sp_logo_roundPictureBox1.Size = new System.Drawing.Size(120, 120);
            this.sp_logo_roundPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sp_logo_roundPictureBox1.TabIndex = 4;
            this.sp_logo_roundPictureBox1.TabStop = false;
            // 
            // LoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(788, 473);
            this.Controls.Add(this.sp_logo_roundPictureBox1);
            this.Controls.Add(this.fooder_label1);
            this.Controls.Add(this.title_label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.load_label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadingScreen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadingScreen";
            this.Load += new System.EventHandler(this.LoadingScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_logo_roundPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer load_timer1;
        private System.Windows.Forms.Label load_label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label title_label2;
        private System.Windows.Forms.Label fooder_label1;
        private Class.RoundPictureBox sp_logo_roundPictureBox1;
    }
}