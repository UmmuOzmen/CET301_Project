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
        SqlCommand command;
        void DatabaseLoad()
        {
            command = new SqlCommand();
            command.Connection = connectToDB;
            command.CommandText = "SELECT * FROM students";

            DataTable data = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);

            dataGridViewStudents.DataSource = data;
        }


        private void FormStudents_Load(object sender, EventArgs e)
        {
            DatabaseLoad();
        }

        private void labelBirthDate_Click(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO students(name, surname,birthdate, gender,class, point) VALUES (@name,@surname,@birthdate,@gender,@class,@point)";
            command = new SqlCommand(query, connectToDB);
            command.Parameters.AddWithValue("@name", textBoxName.Text);
            command.Parameters.AddWithValue("@surname", textBoxSurname.Text);
            command.Parameters.AddWithValue("@birthdate", textBoxBirthdate.Text);
            command.Parameters.AddWithValue("@gender", comboBox1.Text);
            command.Parameters.AddWithValue("@class", textBoxClass.Text);
            command.Parameters.AddWithValue("@point", textBoxPoint.Text);
            connectToDB.Open();
            command.ExecuteNonQuery();
            connectToDB.Close();
            DatabaseLoad();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM students WHERE studentId=@studentId";
            command = new SqlCommand(query, connectToDB);
            command.Parameters.AddWithValue("@studentId", textBoxID.Text);
            connectToDB.Open();
            command.ExecuteNonQuery();
            connectToDB.Close();
            DatabaseLoad();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxID.Clear();
            textBoxBirthdate.Clear();
            textBoxClass.Clear();
            textBoxName.Clear();
            textBoxPoint.Clear();
            textBoxSurname.Clear();
            comboBox1.Text = string.Empty;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string query = "UPDATE students SET name=@name,surname=@surname,birthdate=@birthdate,gender=@gender,class=@class,point=@point WHERE  studentId=@studentId";
            command = new SqlCommand(query, connectToDB);
            command.Parameters.AddWithValue("@name", textBoxName.Text);
            command.Parameters.AddWithValue("@surname", textBoxSurname.Text);
            command.Parameters.AddWithValue("@birthdate", textBoxBirthdate.Text);
            command.Parameters.AddWithValue("@gender", comboBox1.Text);
            command.Parameters.AddWithValue("@class", textBoxClass.Text);
            command.Parameters.AddWithValue("@point", textBoxPoint.Text);
            command.Parameters.AddWithValue("@studentId", textBoxID.Text);

            connectToDB.Open();
            command.ExecuteNonQuery();
            connectToDB.Close();
            DatabaseLoad();
        }

        private void dataGridViewStudents_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = dataGridViewStudents.CurrentRow.Cells[0].Value.ToString();
            textBoxName.Text = dataGridViewStudents.CurrentRow.Cells[1].Value.ToString();
            textBoxSurname.Text = dataGridViewStudents.CurrentRow.Cells[2].Value.ToString();
            textBoxBirthdate.Text = dataGridViewStudents.CurrentRow.Cells[3].Value.ToString();
            comboBox1.Text = dataGridViewStudents.CurrentRow.Cells[4].Value.ToString();
            textBoxClass.Text = dataGridViewStudents.CurrentRow.Cells[5].Value.ToString();
            textBoxPoint.Text = dataGridViewStudents.CurrentRow.Cells[6].Value.ToString();
        }
    }
    }
    

