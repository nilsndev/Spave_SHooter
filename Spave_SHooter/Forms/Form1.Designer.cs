namespace Spave_SHooter
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.game_timer1 = new System.Windows.Forms.Timer(this.components);
            this.pause_label1 = new System.Windows.Forms.Label();
            this.start_button1 = new System.Windows.Forms.Label();
            this.exit_button1 = new System.Windows.Forms.Label();
            this.protection_timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.heart_panel1 = new System.Windows.Forms.Panel();
            this.heart_pictureBox3 = new System.Windows.Forms.PictureBox();
            this.heart_pictureBox2 = new System.Windows.Forms.PictureBox();
            this.heart_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.settings_label = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.coincount_roundLabel1 = new Spave_SHooter.Class.RoundLabel();
            this.SpaceShip_pictureBox1 = new Spave_SHooter.Class.RoundPictureBox();
            this.score_label1 = new Spave_SHooter.Class.RoundLabel();
            this.coin_logo_roundPictureBox1 = new Spave_SHooter.Class.RoundPictureBox();
            this.heart_panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heart_pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart_pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart_pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpaceShip_pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin_logo_roundPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // game_timer1
            // 
            this.game_timer1.Interval = 5;
            this.game_timer1.Tick += new System.EventHandler(this.game_timer1_Tick);
            // 
            // pause_label1
            // 
            this.pause_label1.AutoSize = true;
            this.pause_label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pause_label1.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pause_label1.ForeColor = System.Drawing.Color.White;
            this.pause_label1.Location = new System.Drawing.Point(794, 6);
            this.pause_label1.Margin = new System.Windows.Forms.Padding(0);
            this.pause_label1.Name = "pause_label1";
            this.pause_label1.Size = new System.Drawing.Size(101, 111);
            this.pause_label1.TabIndex = 2;
            this.pause_label1.Text = "II";
            this.pause_label1.Click += new System.EventHandler(this.pause_label1_Click);
            // 
            // start_button1
            // 
            this.start_button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.start_button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.start_button1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.start_button1.Font = new System.Drawing.Font("Impact", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_button1.Location = new System.Drawing.Point(408, 229);
            this.start_button1.Name = "start_button1";
            this.start_button1.Size = new System.Drawing.Size(868, 201);
            this.start_button1.TabIndex = 3;
            this.start_button1.Text = "START";
            this.start_button1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.start_button1.Click += new System.EventHandler(this.start_button1_Click);
            // 
            // exit_button1
            // 
            this.exit_button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exit_button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.exit_button1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.exit_button1.Font = new System.Drawing.Font("Impact", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button1.Location = new System.Drawing.Point(408, 618);
            this.exit_button1.Name = "exit_button1";
            this.exit_button1.Size = new System.Drawing.Size(868, 201);
            this.exit_button1.TabIndex = 4;
            this.exit_button1.Text = "EXIT";
            this.exit_button1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exit_button1.Click += new System.EventHandler(this.exit_button1_Click);
            // 
            // protection_timer1
            // 
            this.protection_timer1.Interval = 1500;
            this.protection_timer1.Tick += new System.EventHandler(this.protection_timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // heart_panel1
            // 
            this.heart_panel1.Controls.Add(this.heart_pictureBox3);
            this.heart_panel1.Controls.Add(this.heart_pictureBox2);
            this.heart_panel1.Controls.Add(this.heart_pictureBox1);
            this.heart_panel1.Location = new System.Drawing.Point(1469, 10);
            this.heart_panel1.Name = "heart_panel1";
            this.heart_panel1.Size = new System.Drawing.Size(256, 107);
            this.heart_panel1.TabIndex = 10;
            this.heart_panel1.Visible = false;
            // 
            // heart_pictureBox3
            // 
            this.heart_pictureBox3.Image = global::Spave_SHooter.Properties.Resources.heart_image;
            this.heart_pictureBox3.Location = new System.Drawing.Point(176, 37);
            this.heart_pictureBox3.Name = "heart_pictureBox3";
            this.heart_pictureBox3.Size = new System.Drawing.Size(57, 47);
            this.heart_pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.heart_pictureBox3.TabIndex = 2;
            this.heart_pictureBox3.TabStop = false;
            this.heart_pictureBox3.Tag = "heart";
            // 
            // heart_pictureBox2
            // 
            this.heart_pictureBox2.Image = global::Spave_SHooter.Properties.Resources.heart_image;
            this.heart_pictureBox2.Location = new System.Drawing.Point(94, 37);
            this.heart_pictureBox2.Name = "heart_pictureBox2";
            this.heart_pictureBox2.Size = new System.Drawing.Size(57, 47);
            this.heart_pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.heart_pictureBox2.TabIndex = 1;
            this.heart_pictureBox2.TabStop = false;
            this.heart_pictureBox2.Tag = "heart";
            // 
            // heart_pictureBox1
            // 
            this.heart_pictureBox1.Image = global::Spave_SHooter.Properties.Resources.heart_image;
            this.heart_pictureBox1.Location = new System.Drawing.Point(16, 37);
            this.heart_pictureBox1.Name = "heart_pictureBox1";
            this.heart_pictureBox1.Size = new System.Drawing.Size(57, 47);
            this.heart_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.heart_pictureBox1.TabIndex = 0;
            this.heart_pictureBox1.TabStop = false;
            this.heart_pictureBox1.Tag = "heart";
            // 
            // settings_label
            // 
            this.settings_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settings_label.BackColor = System.Drawing.Color.Black;
            this.settings_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.settings_label.Font = new System.Drawing.Font("Impact", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settings_label.ForeColor = System.Drawing.Color.Black;
            this.settings_label.Image = global::Spave_SHooter.Properties.Resources.Settings_Icon;
            this.settings_label.Location = new System.Drawing.Point(1792, 6);
            this.settings_label.Name = "settings_label";
            this.settings_label.Size = new System.Drawing.Size(116, 108);
            this.settings_label.TabIndex = 9;
            this.settings_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.settings_label.Click += new System.EventHandler(this.settings_label_Click);
            // 
            // coincount_roundLabel1
            // 
            this.coincount_roundLabel1.AutoSize = true;
            this.coincount_roundLabel1.BackColor = System.Drawing.Color.Transparent;
            this.coincount_roundLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coincount_roundLabel1.ForeColor = System.Drawing.Color.White;
            this.coincount_roundLabel1.Location = new System.Drawing.Point(67, 14);
            this.coincount_roundLabel1.Name = "coincount_roundLabel1";
            this.coincount_roundLabel1.Size = new System.Drawing.Size(32, 33);
            this.coincount_roundLabel1.TabIndex = 8;
            this.coincount_roundLabel1.Text = "0";
            // 
            // SpaceShip_pictureBox1
            // 
            this.SpaceShip_pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.SpaceShip_pictureBox1.Image = global::Spave_SHooter.Properties.Resources.playerShip2_red;
            this.SpaceShip_pictureBox1.Location = new System.Drawing.Point(735, 908);
            this.SpaceShip_pictureBox1.Name = "SpaceShip_pictureBox1";
            this.SpaceShip_pictureBox1.Size = new System.Drawing.Size(198, 141);
            this.SpaceShip_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SpaceShip_pictureBox1.TabIndex = 6;
            this.SpaceShip_pictureBox1.TabStop = false;
            // 
            // score_label1
            // 
            this.score_label1.AutoSize = true;
            this.score_label1.BackColor = System.Drawing.Color.Transparent;
            this.score_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_label1.ForeColor = System.Drawing.Color.White;
            this.score_label1.Location = new System.Drawing.Point(809, 497);
            this.score_label1.Name = "score_label1";
            this.score_label1.Size = new System.Drawing.Size(99, 108);
            this.score_label1.TabIndex = 7;
            this.score_label1.Text = "0";
            this.score_label1.Visible = false;
            // 
            // coin_logo_roundPictureBox1
            // 
            this.coin_logo_roundPictureBox1.Image = global::Spave_SHooter.Properties.Resources.star_coin_rotate_1;
            this.coin_logo_roundPictureBox1.Location = new System.Drawing.Point(6, 3);
            this.coin_logo_roundPictureBox1.Name = "coin_logo_roundPictureBox1";
            this.coin_logo_roundPictureBox1.Size = new System.Drawing.Size(55, 50);
            this.coin_logo_roundPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coin_logo_roundPictureBox1.TabIndex = 11;
            this.coin_logo_roundPictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1061);
            this.Controls.Add(this.coin_logo_roundPictureBox1);
            this.Controls.Add(this.heart_panel1);
            this.Controls.Add(this.settings_label);
            this.Controls.Add(this.coincount_roundLabel1);
            this.Controls.Add(this.start_button1);
            this.Controls.Add(this.exit_button1);
            this.Controls.Add(this.SpaceShip_pictureBox1);
            this.Controls.Add(this.pause_label1);
            this.Controls.Add(this.score_label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Shooter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.heart_panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.heart_pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart_pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart_pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpaceShip_pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin_logo_roundPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer game_timer1;
        private System.Windows.Forms.Label pause_label1;
        private System.Windows.Forms.Label start_button1;
        private System.Windows.Forms.Label exit_button1;
        private System.Windows.Forms.Timer protection_timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Class.RoundLabel score_label1;
        private Class.RoundLabel coincount_roundLabel1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label settings_label;
        public Class.RoundPictureBox SpaceShip_pictureBox1;
        private System.Windows.Forms.Panel heart_panel1;
        private System.Windows.Forms.PictureBox heart_pictureBox1;
        private System.Windows.Forms.PictureBox heart_pictureBox2;
        private System.Windows.Forms.PictureBox heart_pictureBox3;
        private Class.RoundPictureBox coin_logo_roundPictureBox1;
    }
}

