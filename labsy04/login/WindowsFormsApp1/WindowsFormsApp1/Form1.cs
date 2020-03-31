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
    public partial class Form1 : Form
    {
        private String[] login = new String[] { "admin", "nauczyciel", "student" };
        private String[] pass = new string[] { "admin", "pwsz", "39591" } ;
        private bool thrower = true; 
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            Form2 s = new Form2();
            Form3 t = new Form3();
            Form1 r = new Form1();
            for (int i = 0; i <= 2; i++)
            {
                
                if (textBox1.Text == login[i] && textBox2.Text == pass[i])
                {
                    s.Show();
                    thrower = false;
                }
            }
            if (thrower == true)
            {
                t.Show();
            }
            else {
                r.Close(); // próbowałem wykminić jak zamknąć okno początkowe
            }
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) //login
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) //pass
        {

        }
    }
}
