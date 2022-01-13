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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM books WHERE bookId=@bookId";
            command = new SqlCommand(query, connectToDB);
            command.Parameters.AddWithValue("@bookId", textBoxıd.Text);
            connectToDB.Open();
            command.ExecuteNonQuery();
            connectToDB.Close();
            DatabaseLoad();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxAuthorId.Clear();
            textBoxName.Clear();
            textBoxPageCount.Clear();
            textBoxPoint.Clear();
            textBoxTypeId.Clear();
            textBoxıd.Clear();
            
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string query = "UPDATE books SET typeId=@typeId,authorId=@authorId,point=@point,pagecount=@pagecount,name=@name WHERE bookId=@bookId";
            command = new SqlCommand(query, connectToDB);
            command.Parameters.AddWithValue("@typeId", textBoxTypeId.Text);
            command.Parameters.AddWithValue("@authorId", textBoxAuthorId.Text);
            command.Parameters.AddWithValue("@point", textBoxPoint.Text);
            command.Parameters.AddWithValue("@pagecount", textBoxPageCount.Text);
            command.Parameters.AddWithValue("@name", textBoxName.Text);
            command.Parameters.AddWithValue("@bookId", textBoxıd.Text);
            connectToDB.Open();
            command.ExecuteNonQuery();
            connectToDB.Close();
            DatabaseLoad();
        }

        private void dataGridViewBooks_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBoxıd.Text = dataGridViewBooks.CurrentRow.Cells[0].Value.ToString();
            textBoxName.Text = dataGridViewBooks.CurrentRow.Cells[1].Value.ToString();
            textBoxPageCount.Text = dataGridViewBooks.CurrentRow.Cells[2].Value.ToString();
            textBoxPoint.Text = dataGridViewBooks.CurrentRow.Cells[3].Value.ToString();
            textBoxAuthorId.Text = dataGridViewBooks.CurrentRow.Cells[4].Value.ToString();
            textBoxTypeId.Text = dataGridViewBooks.CurrentRow.Cells[5].Value.ToString();
        }
    }
    }

