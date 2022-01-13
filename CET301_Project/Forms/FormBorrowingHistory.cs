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
    }
}
