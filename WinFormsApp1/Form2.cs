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

namespace ERP_MES;

public partial class Form2 : Form
{
    public Form2()
    {
        InitializeComponent();
    }

    private void Form2_Load(object sender, EventArgs e)
    {
        //database bağlantısını bu method içinde yaptım. 
        string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=MESDb;Trusted_Connection=True";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            String query = "SELECT * FROM Cihazlar";
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

    private void label1_Click(object sender, EventArgs e)
    {

    }

    //veritabından verileri çekip DataGridView'a doldurmak için kullanılan metot
    //veritabanından verileri tablo şeklinde çekeceksen buu method kullanılması gerekiyormuş 
    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        Form4 form4 = new Form4();
        form4.Show();
    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {
        Form5 form5 = new Form5();
        form5.Show();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        Form6 form6 = new Form6();
        form6.Show();
    }

    private void button4_Click(object sender, EventArgs e)
    {
        Form7 form7 = new Form7();
        form7.Show();
    }
}
