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
    public partial class FormStudents : Form
    {
        public FormStudents()
        {
            InitializeComponent();
        }
        SqlConnection connectToDB = new SqlConnection("Data Source=DESKTOP-178E3AR;Initial Catalog=library;Integrated Security=True");

        private void FormStudents_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connectToDB;
            command.CommandText = "SELECT * FROM students";

            DataTable data = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);

            dataGridViewStudents.DataSource = data;
        }

        private void labelBirthDate_Click(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }
    }
}
