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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        // Veritabanı bağlantısı için SqlConnection nesnesi oluşturdum.
        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MESDb;Integrated Security=True;Encrypt=True");

        private void Form4_Load(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MESDb;Integrated Security=True;Encrypt=True"))
            {
                baglanti.Open();
                SqlCommand command = new SqlCommand("SELECT CihazAdı, CihazTuru FROM Cihazlar", baglanti);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewCihazGoruntule.DataSource = dataTable;
                dataGridViewCihazGoruntule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewCihazGoruntule.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridViewCihazGoruntule.ReadOnly = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewCihazGoruntule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
