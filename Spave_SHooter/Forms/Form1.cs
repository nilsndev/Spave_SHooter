using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;
using Spave_SHooter.Class;
using System.Threading;

namespace Spave_SHooter
{
    public partial class Form1 : Form
    {


        bool newLevel = false;
        SoundPlayer coinCollect = new SoundPlayer(Application.StartupPath + "\\Sounds\\coin.wav");
        SoundPlayer sp = new SoundPlayer(Application.StartupPath + "\\Sounds\\laser1.wav");
        SoundPlayer shieldDown = new SoundPlayer(Application.StartupPath + "\\Sounds\\sfx_shieldDown.wav");
        SoundPlayer shieldUp = new SoundPlayer(Application.StartupPath + "\\Sounds\\sfx_shieldUp.wav");
        bool goLeft, goRight, goUp, goDown;
        bool spacePressd;
        int asteroidCount;
        int asteroidSpeed = 13;
        int maxBulletCount = 3;
        int maxAsteroidCount = 6;
        int bulletSpeed = 15;
        int bulletCount;
        
        bool doubleShoot;
        int heartcount = 3;
        Random coinSpawner = new Random();
        public Form1(){
            InitializeComponent();
            Settings.SpaceShipSpeed = 8;
            Settings.MaxWidth = this.Width - SpaceShip_pictureBox1.Width;
            Settings.MaxHeight = this.Height - SpaceShip_pictureBox1.Height;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.A){
                goLeft = false;
            }
            if (e.KeyCode == Keys.D){
                goRight = false;
            }
            if (e.KeyCode == Keys.W){
                goUp = false;
            }
            if (e.KeyCode == Keys.S){
                goDown = false;
            }
            if (e.KeyCode == Keys.Space){
                spacePressd = false;
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e){
            if (e.KeyCode == Keys.A){
                goLeft = true;
            }
            if (e.KeyCode == Keys.D){
                goRight = true;
            }
            if (e.KeyCode == Keys.W){
                goUp = true;
            }
            if (e.KeyCode == Keys.S){
                goDown = true;
            }
            if (e.KeyCode == Keys.Space){
                spacePressd = true;
            }
            if (e.KeyCode == Keys.Escape){
                if (start_button1.Visible){
                    start_button1_Click(sender, e); 
                }
                else{
                    pause_label1_Click(sender, e);
                }
              
            }
        }

        private void Form1_Load(object sender, EventArgs e){
          loadSettings();
        }

        private void game_timer1_Tick(object sender, EventArgs e) {
            int cc = Settings.CoinCount; 
            this.coincount_roundLabel1.Text = cc.ToString();
            int locationX = this.SpaceShip_pictureBox1.Location.X;
            int locationY = this.SpaceShip_pictureBox1.Location.Y;
            Check_keyPressd(locationX, locationY);
            spawnMeteorit();
            shootBullet();

        }
        void Check_keyPressd(int x, int y) {
            if (goLeft) {
                if (x > 0)
                    SpaceShip_pictureBox1.Left -= Settings.SpaceShipSpeed; }
            if (goRight) {
                if (x < Settings.MaxWidth)
                    SpaceShip_pictureBox1.Left += Settings.SpaceShipSpeed; }
            if (goUp) {
                if (y > 0)
                    SpaceShip_pictureBox1.Top -= Settings.SpaceShipSpeed; }
            if (goDown) {
                if (y < Settings.MaxHeight)
                    SpaceShip_pictureBox1.Top += Settings.SpaceShipSpeed; }
        }
        

        void spawnMeteorit() {
            Random r = new Random();
            if (asteroidCount < maxAsteroidCount) {
                asteroidCount++;
                //Create-Asteroid-PB----------------------------------------
                RoundPictureBox met = createRoundGameObject("asteroid",
                Spave_SHooter.Properties.Resources.meteorBrown_big4,
                new Size(150, 150),
                new Point(r.Next(0, this.Width - 110), r.Next(-1000, 0)));
                //==========================================================
                this.Controls.Add(met); }
        }

        private void pause_label1_Click(object sender, EventArgs e) {
            this.game_timer1.Enabled = false;
            this.start_button1.Visible = true;
            this.exit_button1.Visible = true;
            this.settings_label.Visible = true;
            this.heart_panel1.Visible = false;
            this.score_label1.Visible = false;
            this.coincount_roundLabel1.Visible = false;
        }

        private void exit_button1_Click(object sender, EventArgs e) {
            Application.Exit(); 
        }

        private void start_button1_Click(object sender, EventArgs e) {
            this.settings_label.Visible = false;
            this.start_button1.Visible = false;
            this.exit_button1.Visible = false;
            this.game_timer1.Enabled = true;
            this.heart_panel1.Visible = true;
            this.score_label1.Visible = true;
            this.coincount_roundLabel1.Visible = true;
        }

        private void protection_timer1_Tick(object sender, EventArgs e)
        {
            this.protection_timer1.Enabled = false;
        }

        void checkifbulletBounds(PictureBox bullet) {

            foreach (Control p in this.Controls) {
                if (p is RoundPictureBox) {
                    if (p.Tag == "asteroid") {
                        if (bullet.Bounds.IntersectsWith(p.Bounds)) {
                            crateRandomGameObject(p as RoundPictureBox);
                            asteroidCount += removeGameObject(p as PictureBox);
                            bulletCount += removeGameObject(bullet);
                            Settings.Score += 10;
                            score_label1.Text = Settings.Score.ToString(); }
                    }
                }
            }
        }

        void crateRandomGameObject(RoundPictureBox p){
            int random = coinSpawner.Next(1, 40);
            if (random % 4 == 0)
            {
                //create-coin-----------------------------------
                this.Controls.Add(createRoundGameObject("coin", Spave_SHooter.Properties.Resources.star_coin_rotate_1,
                new Size(75, 75), new Point(p.Location.X, p.Location.Y)));
                //================================================
            }
            else if (random == 1)
            {
                this.Controls.Add(createRoundGameObject("heart_item", Spave_SHooter.Properties.Resources.heart_image,
                    new Size(60, 60), new Point(p.Location.X, p.Location.Y)));
            }
            else if (random == 3)
            {
                doubleShoot = true;
            }
            else if (random == 5)
            {
                doubleShoot = false;
            }
        }
        RoundPictureBox createRoundGameObject(string tag, Image img, Size s, Point loc) {
            RoundPictureBox p = new RoundPictureBox();
            p.Tag = tag;
            p.Size = s;
            p.Image = img;
            p.SizeMode = PictureBoxSizeMode.Zoom;
            p.Location = loc;
            p.BringToFront();
            return p;
        }
        PictureBox createGameObject(string tag, Image img, Size s, Point loc)
        {
            PictureBox p = new PictureBox();
            p.Tag = tag;
            p.Size = s;
            p.Image = img;
            p.SizeMode = PictureBoxSizeMode.Zoom;
            p.Location = loc;
            p.BringToFront();
            return p;

        }
        private void settings_label_Click(object sender, EventArgs e){
            Spave_SHooter.Forms.Settings_Form sf = new Forms.Settings_Form();
            sf.selected_ship_PB.Image = SpaceShip_pictureBox1.Image;
            sf.selected_laser_pictureBox2.Image = Settings.LaserImage;
            sf.ShowDialog();
            if(sf.DialogResult == DialogResult.OK){
                Settings.LaserImage = sf.selected_laser_pictureBox2.Image;
                SpaceShip_pictureBox1.Image = sf.selected_ship_PB.Image;
            }
        }

        void shootBullet() {
            if (spacePressd){
                //Shoot bullet------------------------
                if (bulletCount < maxBulletCount){
                    sp.Play();
                    bulletCount++;
                    spacePressd = false;

                    if (!doubleShoot){
                        //createObject-----------------------
                        PictureBox bull = createGameObject("bullet", Settings.LaserImage,
                        new Size(40, 100),
                        new Point(SpaceShip_pictureBox1.Location.X + (SpaceShip_pictureBox1.Width / 2),
                        SpaceShip_pictureBox1.Top));
                        this.Controls.Add(bull);
                 }
                    if (doubleShoot){
                        bulletCount++;
                        doubleShooting();
                    }
                    }
                    //====================================
            }
            findGameObject();
        }
        void doubleShooting(){
            //Create-First-Bullet-------------------------
            PictureBox bull1 = createGameObject("bullet",Settings.LaserImage,
            new Size(40, 100),
            new Point(SpaceShip_pictureBox1.Location.X,
            SpaceShip_pictureBox1.Top));
            //=============================================
            //Create-Second-Bullet-------------------------
            PictureBox bull2 = createGameObject("bullet", Settings.LaserImage,
            new Size(40, 100),
            new Point(SpaceShip_pictureBox1.Location.X + SpaceShip_pictureBox1.Width,
            SpaceShip_pictureBox1.Top));
            //=============================================

            this.Controls.Add(bull1);
            this.Controls.Add(bull2);
        }
        int removeGameObject(PictureBox met) {
            this.Controls.Remove(met);
            return -1;
        }
       
        private void coin_rotate_timer1_Tick(object sender, EventArgs e)
        {
            
        }

        void findGameObject(){
            foreach (Control p in this.Controls){
                if (p is RoundPictureBox || p is PictureBox){
                    if (p.Tag == "coin"){
                       
                        coinFound(p as RoundPictureBox);
                    }
                    if (p.Tag == "heart_item"){
                        
                            heart_itemFound(p as RoundPictureBox);
                    }

                    if (p.Tag == "bullet")
                            bulletFound(p as PictureBox);
                        if (p.Tag == "asteroid")
                            asteroidFound(p as PictureBox);}
        }  

         void coinFound(RoundPictureBox coin){
                
                if (this.SpaceShip_pictureBox1.Bounds.IntersectsWith(coin.Bounds)){
                    coinCollect.Play();
                    this.Controls.Remove(coin);
                    Settings.CoinCount++;
                }
        }
           

            void heart_itemFound(RoundPictureBox heart){
                if (this.SpaceShip_pictureBox1.Bounds.IntersectsWith(heart.Bounds))
                {
                    shieldUp.Play();
                    if (heartcount < 3)
                {
                    
                    VisibleHearts();
                    heartcount = 3;
                }
                    this.Controls.Remove(heart);
                
                }
            }

                void bulletFound(PictureBox p){
                    p.Location = new Point(p.Location.X, p.Location.Y - bulletSpeed);
                    checkifbulletBounds(p);
                    if (p.Location.Y < 0) {
                        bulletCount--;
                        this.Controls.Remove(p); }
                }

                void removeItems(){
                    foreach (Control p in this.Controls){
                    if (p is RoundPictureBox)
                    {
                        if (p.Tag == "coin" || p.Tag == "heart_item")
                        {
                            this.Controls.Remove(p);
 
                        }

                    }
                }
                    //Stop-Moving----------------------
                    goLeft = false;
                    goRight = false;
                    goUp = false;
                    goDown = false;
                    //=================================
                }

                void asteroidFound(PictureBox p){
                    p.Location = new Point(p.Location.X, p.Location.Y + asteroidSpeed);
                    shipBoundsinAsteroid(p);
                    if (p.Location.Y > this.Height){
                        asteroidCount += removeGameObject(p);}
                }
                void shipBoundsinAsteroid(PictureBox asteroid) {
                    int score;
                if (protection_timer1.Enabled){
                    asteroidCount += removeGameObject(asteroid);
                    return;}

                if (asteroid.Bounds.IntersectsWith(SpaceShip_pictureBox1.Bounds)){
                    //Remove-live-----------------------
                    if (heartcount > 0){
                        shieldDown.Play();
                        this.Controls.Remove(asteroid);
                        asteroidCount--;
                        removeHearts();
                        heartcount--;}
                    //==================================

                    //Check-if-Game-finished------------
                    if (heartcount == 0){
                        VisibleHearts();
                        Int32.TryParse(this.score_label1.Text, out score);
                        Settings.Score = score;
                        this.game_timer1.Enabled = false;
                        heartcount = 3;
                        showScoreForm();
                        game_timer1.Enabled = true;}}
                //==================================
             }
             void VisibleHearts(){
                heartcount++;
                this.heart_pictureBox1.Visible = true;
                this.heart_pictureBox2.Visible = true;
                this.heart_pictureBox3.Visible = true;}

                void showScoreForm(){
                    Spave_SHooter.Forms.score_form sf = new Forms.score_form();
                    sf.score_label1.Text = "0";
                    sf.ShowDialog();
                    checkDialogResult(sf.DialogResult);}

                void checkDialogResult(DialogResult d){
                    if (d == DialogResult.OK){
                        //Reset-Score----------------------
                        Settings.Score = 0;
                        score_label1.Text = 0.ToString();
                        //=================================
                        removeItems();
                        // New Spaceship Location
                        this.SpaceShip_pictureBox1.Location = new Point(this.Width / 2,
                        this.Height - 200);
                        //=====================
                        this.protection_timer1.Enabled = true;
                        this.game_timer1.Enabled = true;
                        doubleShoot = false;
                }
                    if (d == DialogResult.Cancel){
                        this.Close();}}}

        void loadSettings(){
            Settings.LaserImage = Spave_SHooter.Properties.Resources.laserBlue16;
        }
        void removeHearts(){
            if (heart_pictureBox1.Visible){
                heart_pictureBox1.Visible = false;return;}

            if (heart_pictureBox2.Visible){
                heart_pictureBox2.Visible = false; return;}

            if (heart_pictureBox3.Visible){
                heart_pictureBox3.Visible = false; return;}}

    }

    } 
