using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CET301_Project.Forms
{
    public partial class FormTypes : Form
    {
        
        
        public FormTypes()
        {
            InitializeComponent();
           
        }
        SqlConnection connectToDB = new SqlConnection("Data Source=DESKTOP-178E3AR;Initial Catalog=library;Integrated Security=True");

        SqlCommand command;
        void DatabaseLoad()
        {
            command = new SqlCommand();
            command.Connection = connectToDB;
            command.CommandText = "SELECT * FROM types";

            DataTable data = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);

            dataGridViewTypes.DataSource = data;
        }




        private void FormTypes_Load(object sender, EventArgs e)
        {
            DatabaseLoad();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO types(name) VALUES (@name)";
            command = new SqlCommand(query, connectToDB);
            command.Parameters.AddWithValue("@name", textBox2.Text);
            connectToDB.Open();
            command.ExecuteNonQuery();
            connectToDB.Close();
            DatabaseLoad();
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM types WHERE typeId=@typeId";
            command = new SqlCommand(query, connectToDB);
            command.Parameters.AddWithValue("@typeId", textBox1.Text);
            connectToDB.Open();
            command.ExecuteNonQuery();
            connectToDB.Close();
            DatabaseLoad();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string query = "UPDATE types SET name = @name WHERE typeId=@typeId";
            command = new SqlCommand(query, connectToDB);
            command.Parameters.AddWithValue("@typeId", textBox1.Text);
            command.Parameters.AddWithValue("@name", textBox2.Text);
            connectToDB.Open();
            command.ExecuteNonQuery();
            connectToDB.Close();
            DatabaseLoad();
        }

        private void dataGridViewTypes_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridViewTypes.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridViewTypes.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
