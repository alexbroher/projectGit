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
            tbDNI.
        }

        private void tbDNI_TextChanged(object sender, EventArgs e)
        {
            if (tbDNI.Text.Length == 8)
            {
                int DNI = Convert.ToInt32(tbDNI.Text);
                char letter = getletter(DNI);
                tbLetter.Text = letter.ToString();
            }
        }

        private char getletter(int DNI)
        {
            char letter = 'A';

            return letter;
        }

    }


}
