using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Spave_SHooter
{
    public partial class Form1 : Form
    {
       
        SoundPlayer sp = new SoundPlayer(@"C:\Users\Nils\source\repos\cs_programming\Projects_cs\Spave_SHooter\Spave_SHooter\Sounds\laser1.wav");
        SoundPlayer  endGame = new SoundPlayer(@"C:\Users\Nils\source\repos\cs_programming\Projects_cs\Spave_SHooter\Spave_SHooter\Sounds\Game_End_Sound.wav");
        SoundPlayer damage = new SoundPlayer(@"C:\Users\Nils\source\repos\cs_programming\Projects_cs\Spave_SHooter\Spave_SHooter\Sounds\Explosion_01.wav");
        bool newLevel = false;
        int score = 0;
        int copyScore = 0;
        int meteoridspeed = 2;
        int spaseShipSpeed = 20;
        int level = 1;
        int laserDamage = 5;
        int heart_count = 3;
        bool gameOver = false;
        bool protectionActive = false;
        Random r = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                laser_timer1.Enabled = true;
                meteorid_timer1.Start();
                meteorid_timer2.Start();
                score_timer1.Start();
               
                gameOver = false;
            }
          
            if(e.KeyCode == Keys.A && gameOver == false)

            {

                if (SpaceShip_pictureBox.Location.X < 0)
                {
                    return;
                }
                SpaceShip_pictureBox.Left -= spaseShipSpeed;
            }
            if (e.KeyCode == Keys.D && gameOver == false)
            {
                if (SpaceShip_pictureBox.Location.X > 820)
                {
                    return;
                }

                SpaceShip_pictureBox.Left += spaseShipSpeed;
            }
            if (e.KeyCode == Keys.W && gameOver == false)
            {
            
                if (SpaceShip_pictureBox.Location.Y < 0)
                {
                    return;
                }
                SpaceShip_pictureBox.Top -= spaseShipSpeed;
            }
            if (e.KeyCode == Keys.S && gameOver == false)
            {
                if (SpaceShip_pictureBox.Location.Y > 720)
                {
                    return;
                }
                SpaceShip_pictureBox.Top += spaseShipSpeed;
            }
            if(e.KeyCode == Keys.Space && this.laser_timer1.Enabled == true)
            {
                if(Laser_pictureBox1.Location.Y < 0)
                {
                    LaserInvinsible(Laser_pictureBox1);
                    LaserInvinsible(Laser_pictureBox2);
                }
                if ( !this.Laser_pictureBox1.Visible)
                {

                    try { sp.Play(); } catch { }
                  
                    this.Laser_pictureBox1.Visible = true;
                    this.Laser_pictureBox1.Enabled = true;
                    this.Laser_pictureBox1.Location = new Point(SpaceShip_pictureBox.Location.X + 100 ,
                                                                SpaceShip_pictureBox.Location.Y + 10);
                    this.Laser_pictureBox2.Visible = true;
                    this.Laser_pictureBox2.Enabled = true;
                    this.Laser_pictureBox2.Location = new Point(SpaceShip_pictureBox.Location.X + 30,
                                                                SpaceShip_pictureBox.Location.Y + 10);


                }

          
            }
        }

        void LaserInvinsible(PictureBox p)
        {
           p.Visible = false;
           p.Enabled = false;
           p.Location = new Point(-100, 2000);
        }
        private void meteorid_timer1_Tick(object sender, EventArgs e)
        {
          //Spawn METEORId
            moveMeteorid(pictureBox2, r.Next(350, 550), r.Next(-200, 0));
            moveMeteorid(pictureBox3, r.Next(650, 800), r.Next(-200,  0));
            moveMeteorid(pictureBox1, r.Next(50, 200), r.Next(-200, 0));
        
           
        }
        
         void moveMeteorid(PictureBox p, int xLocation,int yLocation)
        {
            if (p.Bounds.IntersectsWith(SpaceShip_pictureBox.Bounds) && gameOver == false)
            {
                if (protectionActive)
                {
                    p.Location = new Point(xLocation, yLocation);
                    return;
                }
              
                heart_count--;
                removeExtraLife();
                SpaceShip_pictureBox.Location = new Point(469, 597);

                if (heart_count > 0){
                    try { damage.Play(); } catch { }
                   
                    protectionActive = true;
                    wait_timer1.Enabled = true;
                }
                if (heart_count == 0)
                {
                    try {
                        endGame.Play();
                    }
                    catch { }



                    gameOver = true;
                    DiableEnableItems(false);
                    resetAllMetheoridLocation();
                    this.end_panel1.Visible = true;

                    load_Score_timer1.Enabled = true;
                    this.end_score_label2.Text = copyScore.ToString();
                    skip_label1.Visible = true;
                    heart_panel1.Visible = false;
                    if (score > Spave_SHooter.Properties.Settings.Default.highScore)
                    {
                        Spave_SHooter.Properties.Settings.Default.highScore = score;
                        new_high_score_label1.Visible = true;
                        Spave_SHooter.Properties.Settings.Default.Save();
                    }
                }
               
               
                copyScore = 0;

                }
                if (p.Location.Y > this.Height || !p.Visible)
                {
                    p.Visible = true;
                    p.Location = new Point(xLocation, yLocation);

                }
                if (this.Laser_pictureBox1.Bounds.IntersectsWith(p.Bounds) || this.Laser_pictureBox2.Bounds.IntersectsWith(p.Bounds))
                {
                    LaserInvinsible(Laser_pictureBox1);
                    LaserInvinsible(Laser_pictureBox2);
                protectionActive = false;
                if (protectionActive)
                {
                    wait_timer1.Enabled = false;
                }
                    p.Location = new Point(xLocation, yLocation);
                    score += laserDamage;
                }
            
            p.Top += meteoridspeed;
        }

        void removeExtraLife()
        {
            if(heart_count == 2)
            {
                this.heart_pictureBox3.Visible = false;
            }
            if (heart_count == 1)
            {
                this.heart_pictureBox2.Visible = false;
            }
            if (heart_count == 0)
            {
                this.heart_pictureBox1.Visible = false;
            }
        }
        void visibleLifes()
        {
            heart_pictureBox1.Visible = true;
            heart_pictureBox2.Visible = true;
            heart_pictureBox3.Visible = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void laser_timer1_Tick(object sender, EventArgs e)
        {
            this.Laser_pictureBox2.Top -= 25;
            this.Laser_pictureBox1.Top -= 25;
      
        }

        private void score_timer1_Tick(object sender, EventArgs e)
        {
            this.scorelabel1.Text = score.ToString();


            checkScore();
           
            
        }


        void checkScore() {

            int copylevel = level;

            checkNextLevel();
            //Check lEVEL
          
            if (copylevel != level)
            {
              
                Next_Level();
            }
            this.level_label1.Text = "Level " + level;

        }


        void checkNextLevel()
        {

            if (score >= 50)
            {
                level = 2;
                meteoridspeed = 2;

            }


            if (score >= 100)
            {
                level = 3;
                meteorid_timer2.Enabled = true;
            }


            if (score >= 150)
            {
                level = 4;
                meteoridspeed = 3;
            }


            if (score >= 200)
            {
                level = 5;
                meteorid_timer3.Enabled = true;
            }

            if (score >= 250)
            {
                level = 6;
                meteoridspeed = 4;
            }


            if (score >= 300)
            {
                level = 7;
                //new Meteorid;
            }
            if (score >= 350)
            {
                level = 8;
                //new Meteorid;
                meteoridspeed = 5;
            }
            if (score >= 400)
            {
                level = 9;
                //new Meteorid;
            }
            if (score >= 450)
            {
                level = 10;
                meteoridspeed = 6;

            }
        }
            private void meteorid_timer2_Tick(object sender, EventArgs e)
        {
            moveMeteorid(pictureBox4, r.Next(450, 600), r.Next(-700, -500));
            moveMeteorid(pictureBox5, r.Next(650, 800), r.Next(-700, -500));
            moveMeteorid(pictureBox6,r.Next(150, 250), r.Next(-700, -500));
         
            if(level >= 9)
            {
              
                    moveMeteorid(pictureBox13, r.Next(50, 350), r.Next(-4000, -2000));
                    moveMeteorid(pictureBox14, r.Next(400, 600), r.Next(-4000, -2000));
                    moveMeteorid(pictureBox15, r.Next(600, 800), r.Next(-4000, 2000));
                
            }
        }

     
     
    

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

      

      

        void resetAllMetheoridLocation()
        {
            pictureBox1.Location = new Point(r.Next(50, 200), r.Next(-200, 0));
            pictureBox2.Location = new Point(r.Next(350, 550), r.Next(-200, 0));
            pictureBox3.Location = new Point(r.Next(650, 800), r.Next(-200, 0));
           
            pictureBox4.Location = new Point(r.Next(450, 600), r.Next(-700, -500));
            pictureBox5.Location = new Point(r.Next(650, 800), r.Next(-700, -500));
            pictureBox6.Location = new Point(r.Next(150, 250), r.Next(-700, -500));


            pictureBox7.Location = new Point (r.Next(100, 300), r.Next(-1500, -800));
            pictureBox8.Location = new Point(r.Next(400, 600), r.Next(-1500, -800));
            pictureBox9.Location = new Point(r.Next(600, 800), r.Next(-1500, -800));

            pictureBox10.Location = new Point(r.Next(50, 350), r.Next(-4000, -2000));
            pictureBox11.Location = new Point (r.Next(400, 600), r.Next(-4000, -2000));
            pictureBox12.Location = new Point (r.Next(600, 800), r.Next(-4000, 2000));

            pictureBox13.Location = new Point(r.Next(50, 350), r.Next(-4000, -2000));
            pictureBox14.Location = new Point(r.Next(400, 600), r.Next(-4000, -2000));
            pictureBox15.Location = new Point(r.Next(600, 800), r.Next(-4000, 2000));

           
        }

    

     

        private void SpaceShip_pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void start_label1_Click(object sender, EventArgs e)
        {

            Form1 form1 = new Form1();
           
            meteoridspeed = 2;
            level = 1;
            DiableEnableItems(true);
            heart_panel1.Visible = true;
           
            this.exit_label1.Visible = false;
            this.start_label1.Visible = false;
           
           
            form1.Focus();
            gameOver = false;
        }


        void DiableEnableItems(bool dOrE)
        {
            laser_timer1.Enabled = dOrE;
            meteorid_timer1.Enabled = dOrE;
            if (level >= 3)
            {
                meteorid_timer2.Enabled = dOrE;
            }
            if(level >= 5)
            {
                meteorid_timer3.Enabled = dOrE;
            }
            score_timer1.Enabled = dOrE;
            SpaceShip_pictureBox.Enabled = dOrE;
        }
        private void exit_label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            heart_count = 3;
            visibleLifes();
             
            score = 0;
            endGame.Stop();
            this.SpaceShip_pictureBox.Image = Spave_SHooter.Properties.Resources.spaceShipbest;
          load_Score_timer1.Enabled = false;
            this.end_panel1.Visible = false;
            this.exit_label1.Visible = true;
            this.start_label1.Visible = true;
            this.new_high_score_label1.Visible = false;
        }

        void Next_Level(){
           
            this.level_label1.Visible = true;
         
            this.level_label1.Location = new Point(430, 430);
            wait_timer1.Enabled = true;
        }

        private void load_Score_timer1_Tick(object sender, EventArgs e)
        {
           
            if (copyScore <= score) {

               
                this.end_score_label2.Text = copyScore.ToString();

                copyScore++;
            }
            else
            {
                skip_label1.Visible = false;
                load_Score_timer1.Enabled = false;
            }
        
        }

        private void wait_timer1_Tick(object sender, EventArgs e)
        {
            this.level_label1.Visible = false;
            protectionActive = false;
            wait_timer1.Enabled = false;
        }

        private void meteorid_timer3_Tick(object sender, EventArgs e)
        {
            moveMeteorid(pictureBox7, r.Next(100, 300), r.Next(-1500, -800));
            moveMeteorid(pictureBox8, r.Next(400, 600), r.Next(-1500, -800));
            moveMeteorid(pictureBox9, r.Next(600, 800), r.Next(-1500, -800));
            if(level >= 7)
            {
                moveMeteorid(pictureBox10, r.Next(50, 350), r.Next(-4000, -2000));
                moveMeteorid(pictureBox11, r.Next(400, 600), r.Next(-4000, -2000));
                moveMeteorid(pictureBox12, r.Next(600, 800), r.Next(-4000, 2000));
            }
        }

        private void skip_label1_Click(object sender, EventArgs e)
        {
           
            this.load_Score_timer1.Enabled = false;
            this.end_score_label2.Text = score.ToString();
        }
    }
}
