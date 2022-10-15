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
    public partial class score_form : Form
    {
        int copyScore = 0;
        public score_form(){
            InitializeComponent();
        }

        private void continue_button1_Click(object sender, EventArgs e){
            Settings.CoinCount = 0;
            this.new_HighSCore_label1.Visible = false;
            this.DialogResult = DialogResult.OK;
        }

        private void score_form_Load(object sender, EventArgs e){
            if(Settings.Score > Spave_SHooter.Properties.Settings.Default.HighScore){
                this.new_HighSCore_label1.Visible = true;
                Spave_SHooter.Properties.Settings.Default.HighScore = Settings.Score;
                Spave_SHooter.Properties.Settings.Default.Save();
            }
            this.score_label1.Text = "0";
            load_score_timer1.Enabled = true;
        }

        private void exit_button1_Click(object sender, EventArgs e){

            this.DialogResult = DialogResult.Cancel;
        }

        private void load_score_timer1_Tick(object sender, EventArgs e){
            if (copyScore < Settings.Score){
                copyScore++;
                score_label1.Text = copyScore.ToString();
            }
            else{
                skip_button1.Visible = false;
                load_score_timer1.Enabled = false;
            }
        }

        private void skip_button1_Click(object sender, EventArgs e){
            copyScore = Settings.Score;
            score_label1.Text = copyScore.ToString();
            skip_button1.Visible=false;
            load_score_timer1.Enabled = false;
        }
    }
}
