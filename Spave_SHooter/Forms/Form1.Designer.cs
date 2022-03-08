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
            this.meteorid_timer1 = new System.Windows.Forms.Timer(this.components);
            this.laser_timer1 = new System.Windows.Forms.Timer(this.components);
            this.scorelabel1 = new System.Windows.Forms.Label();
            this.score_timer1 = new System.Windows.Forms.Timer(this.components);
            this.meteorid_timer2 = new System.Windows.Forms.Timer(this.components);
            this.level_label1 = new System.Windows.Forms.Label();
            this.start_label1 = new System.Windows.Forms.Label();
            this.exit_label1 = new System.Windows.Forms.Label();
            this.end_panel1 = new System.Windows.Forms.Panel();
            this.victory_label1 = new System.Windows.Forms.Label();
            this.throphy_pictureBox7 = new System.Windows.Forms.PictureBox();
            this.new_high_score_label1 = new System.Windows.Forms.Label();
            this.score_name_end_label2 = new System.Windows.Forms.Label();
            this.end_score_label2 = new System.Windows.Forms.Label();
            this.ok_button = new System.Windows.Forms.Label();
            this.load_Score_timer1 = new System.Windows.Forms.Timer(this.components);
            this.wait_timer1 = new System.Windows.Forms.Timer(this.components);
            this.heart_panel1 = new System.Windows.Forms.Panel();
            this.heart_pictureBox3 = new System.Windows.Forms.PictureBox();
            this.heart_pictureBox2 = new System.Windows.Forms.PictureBox();
            this.heart_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Laser_pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Laser_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SpaceShip_pictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.coin_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.meteorid_timer3 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.skip_label1 = new System.Windows.Forms.Label();
            this.end_panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.throphy_pictureBox7)).BeginInit();
            this.heart_panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heart_pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart_pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart_pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Laser_pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Laser_pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpaceShip_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin_pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            this.SuspendLayout();
            // 
            // meteorid_timer1
            // 
            this.meteorid_timer1.Interval = 10;
            this.meteorid_timer1.Tick += new System.EventHandler(this.meteorid_timer1_Tick);
            // 
            // laser_timer1
            // 
            this.laser_timer1.Interval = 1;
            this.laser_timer1.Tick += new System.EventHandler(this.laser_timer1_Tick);
            // 
            // scorelabel1
            // 
            this.scorelabel1.AutoSize = true;
            this.scorelabel1.BackColor = System.Drawing.Color.Transparent;
            this.scorelabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorelabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.scorelabel1.Location = new System.Drawing.Point(446, 316);
            this.scorelabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scorelabel1.Name = "scorelabel1";
            this.scorelabel1.Size = new System.Drawing.Size(84, 91);
            this.scorelabel1.TabIndex = 5;
            this.scorelabel1.Text = "0";
            // 
            // score_timer1
            // 
            this.score_timer1.Interval = 400;
            this.score_timer1.Tick += new System.EventHandler(this.score_timer1_Tick);
            // 
            // meteorid_timer2
            // 
            this.meteorid_timer2.Interval = 10;
            this.meteorid_timer2.Tick += new System.EventHandler(this.meteorid_timer2_Tick);
            // 
            // level_label1
            // 
            this.level_label1.AutoSize = true;
            this.level_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level_label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.level_label1.Location = new System.Drawing.Point(42, 29);
            this.level_label1.Name = "level_label1";
            this.level_label1.Size = new System.Drawing.Size(153, 54);
            this.level_label1.TabIndex = 10;
            this.level_label1.Text = "Level ";
            this.level_label1.Visible = false;
            // 
            // start_label1
            // 
            this.start_label1.BackColor = System.Drawing.Color.Green;
            this.start_label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.start_label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_label1.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_label1.ForeColor = System.Drawing.Color.Black;
            this.start_label1.Location = new System.Drawing.Point(235, 181);
            this.start_label1.Name = "start_label1";
            this.start_label1.Size = new System.Drawing.Size(566, 184);
            this.start_label1.TabIndex = 19;
            this.start_label1.Text = "Start";
            this.start_label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.start_label1.Click += new System.EventHandler(this.start_label1_Click);
            // 
            // exit_label1
            // 
            this.exit_label1.BackColor = System.Drawing.Color.Green;
            this.exit_label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_label1.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_label1.ForeColor = System.Drawing.Color.Black;
            this.exit_label1.Location = new System.Drawing.Point(235, 503);
            this.exit_label1.Name = "exit_label1";
            this.exit_label1.Size = new System.Drawing.Size(566, 184);
            this.exit_label1.TabIndex = 20;
            this.exit_label1.Text = "Exit";
            this.exit_label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exit_label1.Click += new System.EventHandler(this.exit_label1_Click);
            // 
            // end_panel1
            // 
            this.end_panel1.Controls.Add(this.skip_label1);
            this.end_panel1.Controls.Add(this.victory_label1);
            this.end_panel1.Controls.Add(this.throphy_pictureBox7);
            this.end_panel1.Controls.Add(this.new_high_score_label1);
            this.end_panel1.Controls.Add(this.score_name_end_label2);
            this.end_panel1.Controls.Add(this.end_score_label2);
            this.end_panel1.Controls.Add(this.ok_button);
            this.end_panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.end_panel1.Location = new System.Drawing.Point(0, 0);
            this.end_panel1.Name = "end_panel1";
            this.end_panel1.Size = new System.Drawing.Size(982, 853);
            this.end_panel1.TabIndex = 21;
            this.end_panel1.Visible = false;
            this.end_panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // victory_label1
            // 
            this.victory_label1.AutoSize = true;
            this.victory_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 49.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.victory_label1.ForeColor = System.Drawing.Color.White;
            this.victory_label1.Location = new System.Drawing.Point(201, 29);
            this.victory_label1.Name = "victory_label1";
            this.victory_label1.Size = new System.Drawing.Size(639, 95);
            this.victory_label1.TabIndex = 21;
            this.victory_label1.Text = "Congratulations";
            // 
            // throphy_pictureBox7
            // 
            this.throphy_pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.throphy_pictureBox7.Image = global::Spave_SHooter.Properties.Resources.better_Throphy;
            this.throphy_pictureBox7.Location = new System.Drawing.Point(368, 152);
            this.throphy_pictureBox7.Name = "throphy_pictureBox7";
            this.throphy_pictureBox7.Size = new System.Drawing.Size(300, 300);
            this.throphy_pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.throphy_pictureBox7.TabIndex = 25;
            this.throphy_pictureBox7.TabStop = false;
            // 
            // new_high_score_label1
            // 
            this.new_high_score_label1.AutoSize = true;
            this.new_high_score_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_high_score_label1.ForeColor = System.Drawing.Color.White;
            this.new_high_score_label1.Location = new System.Drawing.Point(376, 464);
            this.new_high_score_label1.Name = "new_high_score_label1";
            this.new_high_score_label1.Size = new System.Drawing.Size(268, 38);
            this.new_high_score_label1.TabIndex = 24;
            this.new_high_score_label1.Text = "New High Score";
            this.new_high_score_label1.Visible = false;
            // 
            // score_name_end_label2
            // 
            this.score_name_end_label2.AutoSize = true;
            this.score_name_end_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_name_end_label2.ForeColor = System.Drawing.Color.White;
            this.score_name_end_label2.Location = new System.Drawing.Point(361, 555);
            this.score_name_end_label2.Name = "score_name_end_label2";
            this.score_name_end_label2.Size = new System.Drawing.Size(138, 38);
            this.score_name_end_label2.TabIndex = 23;
            this.score_name_end_label2.Text = "Score  :";
            // 
            // end_score_label2
            // 
            this.end_score_label2.AutoSize = true;
            this.end_score_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_score_label2.ForeColor = System.Drawing.Color.White;
            this.end_score_label2.Location = new System.Drawing.Point(537, 551);
            this.end_score_label2.Name = "end_score_label2";
            this.end_score_label2.Size = new System.Drawing.Size(92, 48);
            this.end_score_label2.TabIndex = 22;
            this.end_score_label2.Text = "000";
            // 
            // ok_button
            // 
            this.ok_button.BackColor = System.Drawing.Color.Green;
            this.ok_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ok_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok_button.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok_button.ForeColor = System.Drawing.Color.Black;
            this.ok_button.Location = new System.Drawing.Point(351, 662);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(332, 142);
            this.ok_button.TabIndex = 20;
            this.ok_button.Text = "OK";
            this.ok_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // load_Score_timer1
            // 
            this.load_Score_timer1.Interval = 1;
            this.load_Score_timer1.Tick += new System.EventHandler(this.load_Score_timer1_Tick);
            // 
            // wait_timer1
            // 
            this.wait_timer1.Interval = 4000;
            this.wait_timer1.Tick += new System.EventHandler(this.wait_timer1_Tick);
            // 
            // heart_panel1
            // 
            this.heart_panel1.BackColor = System.Drawing.Color.Transparent;
            this.heart_panel1.Controls.Add(this.heart_pictureBox3);
            this.heart_panel1.Controls.Add(this.heart_pictureBox2);
            this.heart_panel1.Controls.Add(this.heart_pictureBox1);
            this.heart_panel1.Location = new System.Drawing.Point(368, 12);
            this.heart_panel1.Name = "heart_panel1";
            this.heart_panel1.Size = new System.Drawing.Size(306, 102);
            this.heart_panel1.TabIndex = 22;
            this.heart_panel1.Visible = false;
            // 
            // heart_pictureBox3
            // 
            this.heart_pictureBox3.Image = global::Spave_SHooter.Properties.Resources.heart_image;
            this.heart_pictureBox3.Location = new System.Drawing.Point(201, 28);
            this.heart_pictureBox3.Name = "heart_pictureBox3";
            this.heart_pictureBox3.Size = new System.Drawing.Size(63, 50);
            this.heart_pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heart_pictureBox3.TabIndex = 4;
            this.heart_pictureBox3.TabStop = false;
            // 
            // heart_pictureBox2
            // 
            this.heart_pictureBox2.Image = global::Spave_SHooter.Properties.Resources.heart_image;
            this.heart_pictureBox2.Location = new System.Drawing.Point(116, 28);
            this.heart_pictureBox2.Name = "heart_pictureBox2";
            this.heart_pictureBox2.Size = new System.Drawing.Size(63, 50);
            this.heart_pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heart_pictureBox2.TabIndex = 3;
            this.heart_pictureBox2.TabStop = false;
            // 
            // heart_pictureBox1
            // 
            this.heart_pictureBox1.Image = global::Spave_SHooter.Properties.Resources.heart_image;
            this.heart_pictureBox1.Location = new System.Drawing.Point(35, 28);
            this.heart_pictureBox1.Name = "heart_pictureBox1";
            this.heart_pictureBox1.Size = new System.Drawing.Size(63, 50);
            this.heart_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heart_pictureBox1.TabIndex = 2;
            this.heart_pictureBox1.TabStop = false;
            // 
            // Laser_pictureBox2
            // 
            this.Laser_pictureBox2.BackColor = System.Drawing.Color.Blue;
            this.Laser_pictureBox2.Enabled = false;
            this.Laser_pictureBox2.Location = new System.Drawing.Point(569, 597);
            this.Laser_pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Laser_pictureBox2.Name = "Laser_pictureBox2";
            this.Laser_pictureBox2.Size = new System.Drawing.Size(10, 40);
            this.Laser_pictureBox2.TabIndex = 11;
            this.Laser_pictureBox2.TabStop = false;
            this.Laser_pictureBox2.Visible = false;
            // 
            // Laser_pictureBox1
            // 
            this.Laser_pictureBox1.BackColor = System.Drawing.Color.Blue;
            this.Laser_pictureBox1.Enabled = false;
            this.Laser_pictureBox1.Location = new System.Drawing.Point(438, 597);
            this.Laser_pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Laser_pictureBox1.Name = "Laser_pictureBox1";
            this.Laser_pictureBox1.Size = new System.Drawing.Size(10, 40);
            this.Laser_pictureBox1.TabIndex = 4;
            this.Laser_pictureBox1.TabStop = false;
            this.Laser_pictureBox1.Visible = false;
            // 
            // SpaceShip_pictureBox
            // 
            this.SpaceShip_pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.SpaceShip_pictureBox.Image = global::Spave_SHooter.Properties.Resources.spaceShipbest;
            this.SpaceShip_pictureBox.Location = new System.Drawing.Point(438, 643);
            this.SpaceShip_pictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SpaceShip_pictureBox.Name = "SpaceShip_pictureBox";
            this.SpaceShip_pictureBox.Size = new System.Drawing.Size(141, 112);
            this.SpaceShip_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.SpaceShip_pictureBox.TabIndex = 0;
            this.SpaceShip_pictureBox.TabStop = false;
            this.SpaceShip_pictureBox.Click += new System.EventHandler(this.SpaceShip_pictureBox_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(650, 46);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 100);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 9;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(202, -17);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 100);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(462, 59);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 100);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // coin_pictureBox1
            // 
            this.coin_pictureBox1.Location = new System.Drawing.Point(1089, 702);
            this.coin_pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.coin_pictureBox1.Name = "coin_pictureBox1";
            this.coin_pictureBox1.Size = new System.Drawing.Size(98, 86);
            this.coin_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin_pictureBox1.TabIndex = 6;
            this.coin_pictureBox1.TabStop = false;
            this.coin_pictureBox1.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(762, 288);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 100);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(783, 78);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(113, 155);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // meteorid_timer3
            // 
            this.meteorid_timer3.Interval = 10;
            this.meteorid_timer3.Tick += new System.EventHandler(this.meteorid_timer3_Tick);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(95, 333);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(100, 100);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 23;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Visible = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(300, 350);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(100, 100);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 24;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Visible = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(574, 350);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(100, 100);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 25;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Visible = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(441, 376);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(100, 100);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 26;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Visible = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(449, 384);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(100, 100);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 27;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Visible = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(457, 392);
            this.pictureBox12.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(100, 100);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 28;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Visible = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(701, 350);
            this.pictureBox13.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(100, 100);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 29;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Visible = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
            this.pictureBox14.Location = new System.Drawing.Point(574, 384);
            this.pictureBox14.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(100, 100);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox14.TabIndex = 30;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Visible = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox15.Image")));
            this.pictureBox15.Location = new System.Drawing.Point(727, 376);
            this.pictureBox15.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(100, 100);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox15.TabIndex = 31;
            this.pictureBox15.TabStop = false;
            this.pictureBox15.Visible = false;
            // 
            // skip_label1
            // 
            this.skip_label1.BackColor = System.Drawing.Color.Green;
            this.skip_label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skip_label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skip_label1.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skip_label1.ForeColor = System.Drawing.Color.Black;
            this.skip_label1.Location = new System.Drawing.Point(684, 553);
            this.skip_label1.Name = "skip_label1";
            this.skip_label1.Size = new System.Drawing.Size(117, 54);
            this.skip_label1.TabIndex = 26;
            this.skip_label1.Text = "Skip";
            this.skip_label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.skip_label1.Click += new System.EventHandler(this.skip_label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 853);
            this.Controls.Add(this.end_panel1);
            this.Controls.Add(this.heart_panel1);
            this.Controls.Add(this.exit_label1);
            this.Controls.Add(this.start_label1);
            this.Controls.Add(this.scorelabel1);
            this.Controls.Add(this.Laser_pictureBox2);
            this.Controls.Add(this.Laser_pictureBox1);
            this.Controls.Add(this.SpaceShip_pictureBox);
            this.Controls.Add(this.level_label1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.coin_pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox15);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Shooter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.end_panel1.ResumeLayout(false);
            this.end_panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.throphy_pictureBox7)).EndInit();
            this.heart_panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.heart_pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart_pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart_pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Laser_pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Laser_pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpaceShip_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin_pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox SpaceShip_pictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer meteorid_timer1;
        private System.Windows.Forms.PictureBox Laser_pictureBox1;
        private System.Windows.Forms.Timer laser_timer1;
        private System.Windows.Forms.Label scorelabel1;
        private System.Windows.Forms.Timer score_timer1;
        private System.Windows.Forms.PictureBox coin_pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Timer meteorid_timer2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label level_label1;
        private System.Windows.Forms.PictureBox Laser_pictureBox2;
        private System.Windows.Forms.Label start_label1;
        private System.Windows.Forms.Label exit_label1;
        private System.Windows.Forms.Panel end_panel1;
        private System.Windows.Forms.Label ok_button;
        private System.Windows.Forms.Label victory_label1;
        private System.Windows.Forms.Label end_score_label2;
        private System.Windows.Forms.Label score_name_end_label2;
        private System.Windows.Forms.Timer load_Score_timer1;
        private System.Windows.Forms.Timer wait_timer1;
        private System.Windows.Forms.Label new_high_score_label1;
        private System.Windows.Forms.Panel heart_panel1;
        private System.Windows.Forms.PictureBox throphy_pictureBox7;
        private System.Windows.Forms.PictureBox heart_pictureBox1;
        private System.Windows.Forms.PictureBox heart_pictureBox3;
        private System.Windows.Forms.PictureBox heart_pictureBox2;
        private System.Windows.Forms.Timer meteorid_timer3;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.Label skip_label1;
    }
}

