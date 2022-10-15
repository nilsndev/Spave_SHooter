using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Spave_SHooter.Class;
namespace Spave_SHooter.Forms
{
    public partial class Settings_Form : Form
    {
        public Settings_Form()
        {
            InitializeComponent();
        }

        private void Settings_Form_Load(object sender, EventArgs e)
        {
          
        }

        private void exit_button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void select_spaceship_pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void finished_button1_Click(object sender, EventArgs e){
            Form1 f1 = new Form1();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ship1_pb1_Click(object sender, EventArgs e){
            this.selected_ship_PB.Image = ship1_pb1.Image;
        }

        private void ship5_pb1_Click(object sender, EventArgs e){
            this.selected_ship_PB.Image = ship5_pb1.Image;
        }

        private void ship2_pb_Click(object sender, EventArgs e){
            this.selected_ship_PB.Image = ship2_pb.Image;
        }

        private void ship4_pictureBox1_Click(object sender, EventArgs e){
            this.selected_ship_PB.Image = ship4_pictureBox1.Image;
        }

        private void ship3_pb1_Click(object sender, EventArgs e){
            this.selected_ship_PB.Image = ship3_pb1.Image;
        }

        private void laser1_pictureBox3_Click(object sender, EventArgs e){
            this.selected_laser_pictureBox2.Image = laser1_pictureBox3.Image;
        }

        private void laser2_pictureBox2_Click(object sender, EventArgs e){
            this.selected_laser_pictureBox2.Image = laser2_pictureBox2.Image;
        }

        private void laser3_pictureBox2_Click(object sender, EventArgs e){
            this.selected_laser_pictureBox2.Image = laser3_pictureBox2.Image;
        }
    }
}
