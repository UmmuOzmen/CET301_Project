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
    public partial class FormBooks : Form
    {
        public FormBooks()
        {
            InitializeComponent();
        }

        SqlConnection connectToDB = new SqlConnection("Data Source=DESKTOP-178E3AR;Initial Catalog=library;Integrated Security=True");
        SqlCommand command;
        void DatabaseLoad()
        {
            command = new SqlCommand();
            command.Connection = connectToDB;
            command.CommandText = "SELECT * FROM books";

            DataTable data = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);

            dataGridViewBooks.DataSource = data;
        }
        private void FormBooks_Load(object sender, EventArgs e)
        {
            DatabaseLoad();
        }

        private void dataGridViewBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO books(name,pagecount,point,authorId,typeId) VALUES (@name, @pagecount, @point, @authorId, @typeId)";
            command = new SqlCommand(query, connectToDB);
            command.Parameters.AddWithValue("@name", textBoxName.Text);
            command.Parameters.AddWithValue("@pagecount", textBoxPageCount.Text);
            command.Parameters.AddWithValue("@point", textBoxPoint.Text);
            command.Parameters.AddWithValue("@authorId", textBoxAuthorId.Text);
            command.Parameters.AddWithValue("@typeId", textBoxTypeId.Text);
            connectToDB.Open();
            command.ExecuteNonQuery();
            connectToDB.Close();
            DatabaseLoad();
        }
    }
}
