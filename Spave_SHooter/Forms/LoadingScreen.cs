using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Spave_SHooter.Forms
{
    public partial class LoadingScreen : Form
    {
        public LoadingScreen()
        {
            InitializeComponent();
        }

        private void load_timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value < 100)
            {
                progressBar1.Value += 10;
            }
            else
            {
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
                load_timer1.Enabled = false;
            }
            
        }

        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            
        }
    }
}
