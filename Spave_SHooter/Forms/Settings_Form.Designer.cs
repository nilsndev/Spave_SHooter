namespace Spave_SHooter.Forms
{
    partial class Settings_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings_Form));
            this.exit_button1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.finished_button1 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.selected_ship_label1 = new System.Windows.Forms.Label();
            this.selected_laser_label1 = new System.Windows.Forms.Label();
            this.laser3_pictureBox2 = new System.Windows.Forms.PictureBox();
            this.laser2_pictureBox2 = new System.Windows.Forms.PictureBox();
            this.laser1_pictureBox3 = new System.Windows.Forms.PictureBox();
            this.selected_laser_pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ship5_pb1 = new System.Windows.Forms.PictureBox();
            this.ship2_pb = new System.Windows.Forms.PictureBox();
            this.ship4_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ship3_pb1 = new System.Windows.Forms.PictureBox();
            this.ship1_pb1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.selected_ship_PB = new System.Windows.Forms.PictureBox();
            this.selected_ship_pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.laser3_pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laser2_pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laser1_pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selected_laser_pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship5_pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship2_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship4_pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship3_pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship1_pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selected_ship_PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selected_ship_pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // exit_button1
            // 
            this.exit_button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exit_button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.exit_button1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.exit_button1.Font = new System.Drawing.Font("Impact", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button1.Location = new System.Drawing.Point(1718, 9);
            this.exit_button1.Name = "exit_button1";
            this.exit_button1.Size = new System.Drawing.Size(190, 95);
            this.exit_button1.TabIndex = 5;
            this.exit_button1.Text = "EXIT";
            this.exit_button1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exit_button1.Click += new System.EventHandler(this.exit_button1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "playerShip1_red.png");
            this.imageList1.Images.SetKeyName(1, "playerShip2_green.png");
            this.imageList1.Images.SetKeyName(2, "playerShip2_red.png");
            this.imageList1.Images.SetKeyName(3, "playerShip3_blue.png");
            this.imageList1.Images.SetKeyName(4, "playerShip3_green.png");
            // 
            // finished_button1
            // 
            this.finished_button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.finished_button1.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finished_button1.Location = new System.Drawing.Point(590, 804);
            this.finished_button1.Name = "finished_button1";
            this.finished_button1.Size = new System.Drawing.Size(868, 201);
            this.finished_button1.TabIndex = 11;
            this.finished_button1.Text = "Finished";
            this.finished_button1.UseVisualStyleBackColor = false;
            this.finished_button1.Click += new System.EventHandler(this.finished_button1_Click);
            // 
            // selected_ship_label1
            // 
            this.selected_ship_label1.AutoSize = true;
            this.selected_ship_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selected_ship_label1.ForeColor = System.Drawing.Color.White;
            this.selected_ship_label1.Location = new System.Drawing.Point(96, 263);
            this.selected_ship_label1.Name = "selected_ship_label1";
            this.selected_ship_label1.Size = new System.Drawing.Size(207, 33);
            this.selected_ship_label1.TabIndex = 18;
            this.selected_ship_label1.Text = "Selected Ship";
            // 
            // selected_laser_label1
            // 
            this.selected_laser_label1.AutoSize = true;
            this.selected_laser_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selected_laser_label1.ForeColor = System.Drawing.Color.White;
            this.selected_laser_label1.Location = new System.Drawing.Point(97, 562);
            this.selected_laser_label1.Name = "selected_laser_label1";
            this.selected_laser_label1.Size = new System.Drawing.Size(189, 29);
            this.selected_laser_label1.TabIndex = 19;
            this.selected_laser_label1.Text = "Selected Laser";
            // 
            // laser3_pictureBox2
            // 
            this.laser3_pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laser3_pictureBox2.Image = global::Spave_SHooter.Properties.Resources.laserRed16;
            this.laser3_pictureBox2.Location = new System.Drawing.Point(431, 379);
            this.laser3_pictureBox2.Name = "laser3_pictureBox2";
            this.laser3_pictureBox2.Size = new System.Drawing.Size(75, 72);
            this.laser3_pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.laser3_pictureBox2.TabIndex = 23;
            this.laser3_pictureBox2.TabStop = false;
            this.laser3_pictureBox2.Click += new System.EventHandler(this.laser3_pictureBox2_Click);
            // 
            // laser2_pictureBox2
            // 
            this.laser2_pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laser2_pictureBox2.Image = global::Spave_SHooter.Properties.Resources.laserGreen10;
            this.laser2_pictureBox2.Location = new System.Drawing.Point(319, 475);
            this.laser2_pictureBox2.Name = "laser2_pictureBox2";
            this.laser2_pictureBox2.Size = new System.Drawing.Size(75, 72);
            this.laser2_pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.laser2_pictureBox2.TabIndex = 22;
            this.laser2_pictureBox2.TabStop = false;
            this.laser2_pictureBox2.Click += new System.EventHandler(this.laser2_pictureBox2_Click);
            // 
            // laser1_pictureBox3
            // 
            this.laser1_pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laser1_pictureBox3.Image = global::Spave_SHooter.Properties.Resources.laserBlue16;
            this.laser1_pictureBox3.Location = new System.Drawing.Point(319, 379);
            this.laser1_pictureBox3.Name = "laser1_pictureBox3";
            this.laser1_pictureBox3.Size = new System.Drawing.Size(75, 72);
            this.laser1_pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.laser1_pictureBox3.TabIndex = 21;
            this.laser1_pictureBox3.TabStop = false;
            this.laser1_pictureBox3.Click += new System.EventHandler(this.laser1_pictureBox3_Click);
            // 
            // selected_laser_pictureBox2
            // 
            this.selected_laser_pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selected_laser_pictureBox2.Location = new System.Drawing.Point(102, 379);
            this.selected_laser_pictureBox2.Name = "selected_laser_pictureBox2";
            this.selected_laser_pictureBox2.Size = new System.Drawing.Size(169, 168);
            this.selected_laser_pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.selected_laser_pictureBox2.TabIndex = 20;
            this.selected_laser_pictureBox2.TabStop = false;
            // 
            // ship5_pb1
            // 
            this.ship5_pb1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ship5_pb1.Image = global::Spave_SHooter.Properties.Resources.playerShip3_green;
            this.ship5_pb1.Location = new System.Drawing.Point(319, 176);
            this.ship5_pb1.Name = "ship5_pb1";
            this.ship5_pb1.Size = new System.Drawing.Size(75, 75);
            this.ship5_pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ship5_pb1.TabIndex = 17;
            this.ship5_pb1.TabStop = false;
            this.ship5_pb1.Click += new System.EventHandler(this.ship5_pb1_Click);
            // 
            // ship2_pb
            // 
            this.ship2_pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ship2_pb.Image = global::Spave_SHooter.Properties.Resources.playerShip3_blue;
            this.ship2_pb.Location = new System.Drawing.Point(431, 83);
            this.ship2_pb.Name = "ship2_pb";
            this.ship2_pb.Size = new System.Drawing.Size(75, 75);
            this.ship2_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ship2_pb.TabIndex = 16;
            this.ship2_pb.TabStop = false;
            this.ship2_pb.Click += new System.EventHandler(this.ship2_pb_Click);
            // 
            // ship4_pictureBox1
            // 
            this.ship4_pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ship4_pictureBox1.Image = global::Spave_SHooter.Properties.Resources.playerShip2_green;
            this.ship4_pictureBox1.Location = new System.Drawing.Point(431, 176);
            this.ship4_pictureBox1.Name = "ship4_pictureBox1";
            this.ship4_pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.ship4_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ship4_pictureBox1.TabIndex = 15;
            this.ship4_pictureBox1.TabStop = false;
            this.ship4_pictureBox1.Click += new System.EventHandler(this.ship4_pictureBox1_Click);
            // 
            // ship3_pb1
            // 
            this.ship3_pb1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ship3_pb1.Image = global::Spave_SHooter.Properties.Resources.playerShip1_red;
            this.ship3_pb1.Location = new System.Drawing.Point(541, 176);
            this.ship3_pb1.Name = "ship3_pb1";
            this.ship3_pb1.Size = new System.Drawing.Size(75, 75);
            this.ship3_pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ship3_pb1.TabIndex = 14;
            this.ship3_pb1.TabStop = false;
            this.ship3_pb1.Click += new System.EventHandler(this.ship3_pb1_Click);
            // 
            // ship1_pb1
            // 
            this.ship1_pb1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ship1_pb1.Image = global::Spave_SHooter.Properties.Resources.playerShip2_red;
            this.ship1_pb1.Location = new System.Drawing.Point(319, 80);
            this.ship1_pb1.Name = "ship1_pb1";
            this.ship1_pb1.Size = new System.Drawing.Size(75, 75);
            this.ship1_pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ship1_pb1.TabIndex = 13;
            this.ship1_pb1.TabStop = false;
            this.ship1_pb1.Click += new System.EventHandler(this.ship1_pb1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(319, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // selected_ship_PB
            // 
            this.selected_ship_PB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selected_ship_PB.Location = new System.Drawing.Point(111, 80);
            this.selected_ship_PB.Name = "selected_ship_PB";
            this.selected_ship_PB.Size = new System.Drawing.Size(169, 168);
            this.selected_ship_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.selected_ship_PB.TabIndex = 12;
            this.selected_ship_PB.TabStop = false;
            // 
            // selected_ship_pictureBox1
            // 
            this.selected_ship_pictureBox1.Location = new System.Drawing.Point(111, 83);
            this.selected_ship_pictureBox1.Name = "selected_ship_pictureBox1";
            this.selected_ship_pictureBox1.Size = new System.Drawing.Size(169, 168);
            this.selected_ship_pictureBox1.TabIndex = 12;
            this.selected_ship_pictureBox1.TabStop = false;
            // 
            // Settings_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.laser3_pictureBox2);
            this.Controls.Add(this.laser2_pictureBox2);
            this.Controls.Add(this.laser1_pictureBox3);
            this.Controls.Add(this.selected_laser_pictureBox2);
            this.Controls.Add(this.selected_laser_label1);
            this.Controls.Add(this.selected_ship_label1);
            this.Controls.Add(this.ship5_pb1);
            this.Controls.Add(this.ship2_pb);
            this.Controls.Add(this.ship4_pictureBox1);
            this.Controls.Add(this.ship3_pb1);
            this.Controls.Add(this.ship1_pb1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.selected_ship_PB);
            this.Controls.Add(this.selected_ship_pictureBox1);
            this.Controls.Add(this.finished_button1);
            this.Controls.Add(this.exit_button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Settings_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.laser3_pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laser2_pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laser1_pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selected_laser_pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship5_pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship2_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship4_pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship3_pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship1_pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selected_ship_PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selected_ship_pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label exit_button1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button finished_button1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox selected_ship_pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ship3_pb1;
        private System.Windows.Forms.PictureBox ship4_pictureBox1;
        private System.Windows.Forms.PictureBox ship2_pb;
        private System.Windows.Forms.PictureBox ship5_pb1;
        private System.Windows.Forms.PictureBox ship1_pb1;
        public System.Windows.Forms.PictureBox selected_ship_PB;
        private System.Windows.Forms.Label selected_ship_label1;
        private System.Windows.Forms.Label selected_laser_label1;
        public System.Windows.Forms.PictureBox selected_laser_pictureBox2;
        public System.Windows.Forms.PictureBox laser1_pictureBox3;
        public System.Windows.Forms.PictureBox laser2_pictureBox2;
        public System.Windows.Forms.PictureBox laser3_pictureBox2;
    }
}