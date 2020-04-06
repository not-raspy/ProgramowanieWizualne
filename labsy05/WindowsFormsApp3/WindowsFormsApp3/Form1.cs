using System; // Jakub Malinowski 39591
using System.Collections.Generic; // lab05
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //uruchom zapytanie
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=komis;";
            string query = "SELECT * FROM samochody";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();

                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("Udało się!");
                    dataGridView1.Rows.Clear();
                    while (reader.Read())
                    {

                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5) };

                        dataGridView1.Rows.Add(row);

                    }
                    
                }
                else
                {
                    MessageBox.Show("Brak rekordów!");
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) // dodaj pojazd
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=komis;";

            if ((tb_Kolor.Text == "") && (tb_Model.Text == "") && (tb_Nazwa.Text == "") && (tb_Przebieg.Text == "") && (tb_Wartosc.Text == ""))
            {
                MessageBox.Show("Brak danych!");
            }
            else
            {
                string query = "INSERT INTO `samochody` (`id`, `Nazwa`, `Model`, `Wartosc`, `Kolor`, `Przebieg`) VALUES(NULL, '"+tb_Nazwa.Text+"','"+tb_Model.Text+"','"+tb_Wartosc.Text+"','"+tb_Kolor.Text+"','"+tb_Przebieg.Text+"');";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;

                databaseConnection.Open();
                commandDatabase.ExecuteNonQuery();
                databaseConnection.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e) // usun pojazd
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=komis;";

            if ((tb_ID.Text == ""))
            {
                MessageBox.Show("Brak danych!");
            }
            else
            {
                string query = "DELETE FROM `samochody` WHERE id = '"+Int32.Parse(tb_ID.Text)+"' ;";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;

                databaseConnection.Open();
                commandDatabase.ExecuteNonQuery();
                databaseConnection.Close();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
