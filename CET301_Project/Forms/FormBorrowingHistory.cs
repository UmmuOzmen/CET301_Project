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
    public partial class FormBorrowingHistory : Form
    {
        public FormBorrowingHistory()
        {
            InitializeComponent();
        }
        SqlConnection connectToDB = new SqlConnection("Data Source=DESKTOP-178E3AR;Initial Catalog=library;Integrated Security=True");

        SqlCommand command;
        void DatabaseLoad()
        {
            command = new SqlCommand();
            command.Connection = connectToDB;
            command.CommandText = "SELECT * FROM borrows";

            DataTable data = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);

            dataGridViewBorrows.DataSource = data;
        }

        private void FormBorrow_Load(object sender, EventArgs e)
        {
            DatabaseLoad();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO borrows(studentId,bookId,takenDate,broughtDate) VALUES (@studentId,@bookId,@takenDate,@broughtDate)";
            command = new SqlCommand(query, connectToDB);
            command.Parameters.AddWithValue("@studentId", textBoxStudId.Text);
            command.Parameters.AddWithValue("@bookId", textBoxBookId.Text);
            command.Parameters.AddWithValue("@takenDate", dateTimePickerTaken.Value);
            command.Parameters.AddWithValue("@broughtDate", dateTimePickerBrought.Value);
            connectToDB.Open();
            command.ExecuteNonQuery();
            connectToDB.Close();
            DatabaseLoad();
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM borrows WHERE borrowId=@borrowId";
            command = new SqlCommand(query, connectToDB);
            command.Parameters.AddWithValue("@borrowId", textBoxId.Text);
            connectToDB.Open();
            command.ExecuteNonQuery();
            connectToDB.Close();
            DatabaseLoad();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxId.Clear();
            textBoxBookId.Clear();
            textBoxStudId.Clear();
            dateTimePickerTaken.Value = DateTime.Now;
            dateTimePickerBrought.Value = DateTime.Now;

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string query = "UPDATE borrows SET studentId=@studentId,bookId=@bookId,takenDate=@takenDate,broughtDate=@broughtDate WHERE borrowId=@borrowId";
            command = new SqlCommand(query, connectToDB);
            command.Parameters.AddWithValue("@borrowId", textBoxId.Text);
            command.Parameters.AddWithValue("@studentId", textBoxStudId.Text);
            command.Parameters.AddWithValue("@bookId", textBoxBookId.Text);
            command.Parameters.AddWithValue("@takenDate", dateTimePickerTaken.Value);
            command.Parameters.AddWithValue("@broughtDate", dateTimePickerBrought.Value);
            connectToDB.Open();
            command.ExecuteNonQuery();
            connectToDB.Close();
            DatabaseLoad();
        }

        private void labelId_Click(object sender, EventArgs e)
        {

        }

        private void labelStudentId_Click(object sender, EventArgs e)
        {

        }

        private void labelBookId_Click(object sender, EventArgs e)
        {

        }

        private void labelTakenDate_Click(object sender, EventArgs e)
        {

        }

        private void labelBroughtdate_Click(object sender, EventArgs e)
        {

        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxStudId_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxBookId_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerTaken_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerBrought_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewBorrows_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBoxId.Text = dataGridViewBorrows.CurrentRow.Cells[0].Value.ToString();
            textBoxStudId.Text = dataGridViewBorrows.CurrentRow.Cells[1].Value.ToString();
            textBoxBookId.Text = dataGridViewBorrows.CurrentRow.Cells[2].Value.ToString();
            dateTimePickerTaken.Text = dataGridViewBorrows.CurrentRow.Cells[3].Value.ToString();
            dateTimePickerBrought.Text = dataGridViewBorrows.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
