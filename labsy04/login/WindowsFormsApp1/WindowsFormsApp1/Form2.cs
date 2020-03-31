using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Random rng = new Random();
            int liczba = rng.Next(1,6);
            randomizer.Text = liczba.ToString();
        }
        

        private void CopyThat(object sender, EventArgs e)
        {
            Clipboard.SetText(randomizer.Text);
        }

        private void Key_r(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'r') button1_Click(sender,e);
        }
    }
}
