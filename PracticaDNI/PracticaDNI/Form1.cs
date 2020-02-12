using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaDNI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void tbDNI_TextChanged(object sender, EventArgs e)
        {
            if (tbDNI.Text.Length == 8)
            {
                try
                {
                    int DNI = Convert.ToInt32(tbDNI.Text);
                    char letter = getletter(DNI);
                    tbLetter.Text = letter.ToString();
                }
                catch
                {
                    MessageBox.Show("Tienes que escribir números");
                }
                
            }else if(tbDNI.Text.Length < 8)
            {
                tbLetter.Text = "";
            }
        }

        private char getletter(int DNI)
        {
            char[] letters = new char[]{ 'T','R','W','A','G','M','Y','F','P','D','X','B','N','J','Z','S','Q','V','H','L','C','K','E' };

            return letters[DNI % 23];
        }

    }


}
