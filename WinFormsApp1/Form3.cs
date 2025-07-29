using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace ERP_MES
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //database bağlantısını bu method içinde yaptım. 
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=MESDb;Trusted_Connection=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                String query = "SELECT s.SiparisNo , S.Olusturan, s.SiparisMiktarı, s.SiparisOT, s.SiparisSTT, c.CihazAdı " +
                    "FROM Siparisler s INNER JOIN Cihazlar c ON s.CihazId = c.CihazId;";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                //çekilen verileri DataGridView'a atamak için 
                dataGridView1.DataSource = dataTable;

                // tablonun tipini biraz düzeltiyorum
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.ReadOnly = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.ShowDialog();
        }
    }
}
