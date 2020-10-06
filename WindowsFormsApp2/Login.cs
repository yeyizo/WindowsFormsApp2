using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projecte1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BotonRandom_Click(object sender, EventArgs e)
        {
            var keypadArrayList = new ArrayList();
            Random rnd = new Random();
            keypadArrayList.add(0);
            keypadArrayList.add(1);
            keypadArrayList.add(2);
            keypadArrayList.add(3);
            keypadArrayList.add(4);
            keypadArrayList.add(5);
            keypadArrayList.add(6);
            keypadArrayList.add(7);
            keypadArrayList.add(8);
            keypadArrayList.add(9);


            for (int i = 0; i < keypadArrayList.Lenght; i++)
            {
                for (int i = array.Length - 1; i > 0; i--)
                {
                    int j = rnd.Next(i);
                    int k = array[j];
                    array[j] = array[i - 1];
                    array[i - 1] = k;
                }

            }
        }

        private void CajaTextoRandom_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
