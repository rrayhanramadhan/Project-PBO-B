using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pengumpulan_Poin_Versi_2
{
    public partial class Form1 : Form
    {
        private object userId;
        private object pointsToAdd;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        public void button16_Click(object sender, EventArgs e)
        {

        }

        public void button15_Click(object sender, EventArgs e)
        {
            

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            string connectionString = "your_connection_string";

            // Membuat koneksi ke basis data
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                // Membuat perintah SQL untuk menambahkan poin
                string sql = "UPDATE Users SET Points = Points + @pointsToAdd WHERE Id = @userId";

                // Membuat objek NpgsqlCommand
                using (var cmd = new NpgsqlCommand(sql, connection))
                {
                    // Menambahkan parameter ke perintah SQL
                    cmd.Parameters.AddWithValue("pointsToAdd", pointsToAdd);
                    cmd.Parameters.AddWithValue("userId", userId);

                    // Menjalankan perintah SQL
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
    
}
