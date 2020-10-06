using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2;

namespace projecte1
{
    public partial class Splash : Form
    {
        private int timeLeft;

        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        { 
            TEMPO.Start();
            timeLeft = 20;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void TEMPO_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                progressBar1.Value = progressBar1.Value + 5;
            } else { 
            TEMPO.Stop();
            new Login().Show();
            this.Hide();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        { 

        }
    }
}
