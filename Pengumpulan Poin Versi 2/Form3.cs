using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Pengumpulan_Poin_Versi_2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void guna1Button10_Click(object sender, EventArgs e, NpgsqlCommand cmd)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=123; Database=jecation"))
            {
                conn.Open();
                NpgsqlCommand npgsqlCommand = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT id_faq, pertanyaan_faq, jawaban_faq FROM faq";
                cmd.CommandType = CommandType.Text;
                NpgsqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int labelIndex = 1; // Indeks Label pertama

                    do
                    {
                        string kolomValue = reader.GetString(0); // Ubah indeks sesuai dengan posisi kolom pada SELECT

                        // Cari Label berdasarkan indeks
                        Label label = this.Controls.Find("faq_1, faq_2, faq_3, faq_4, faq_5, faq_6" + labelIndex, true).FirstOrDefault() as Label;

                        if (label != null)
                        {
                            // Set nilai data pada Label
                            label.Text = kolomValue;
                        }

                        // Tingkatkan indeks Label untuk baris berikutnya
                        labelIndex++;
                    }
                    while (reader.Read());
                }
                reader.Close();
                conn.Close();
            }
        }

        private void guna1Button10_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Panel5_Paint(object sender, PaintEventArgs e)
        {
        }
            class Program
        {
            static void Main()
            {
                string smtpServer = "smtp.example.com";
                int smtpPort = 587;
                string email = "your_email@example.com";
                string password = "your_password";

                Console.WriteLine("Email Sender");

                Console.Write("To: ");
                string to = Console.ReadLine();

                Console.Write("Subject: ");
                string subject = Console.ReadLine();

                Console.Write("Body: ");
                string body = Console.ReadLine();

                try
                {
                    using (SmtpClient client = new SmtpClient(smtpServer, smtpPort))
                    {
                        client.EnableSsl = true;
                        client.Credentials = new NetworkCredential(email, password);

                        using (MailMessage mailMessage = new MailMessage())
                        {
                            mailMessage.From = new MailAddress(email);
                            mailMessage.To.Add(to);
                            mailMessage.Subject = subject;
                            mailMessage.Body = body;

                            client.Send(mailMessage);
                            Console.WriteLine("Email sent successfully!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }

                Console.ReadLine();
            }
        }
    }
    
}


