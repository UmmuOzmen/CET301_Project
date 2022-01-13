﻿using System;
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
    public partial class FormAuthors : Form
    {
        public FormAuthors()
        {
            InitializeComponent();
           
        }
        SqlConnection connectToDB = new SqlConnection("Data Source=DESKTOP-178E3AR;Initial Catalog=library;Integrated Security=True");
        SqlCommand command;

        void DatabaseLoad()
        {
            command = new SqlCommand();
            command.Connection = connectToDB;
            command.CommandText = "SELECT * FROM authors";

            DataTable data = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);

            dataGridViewAuthors.DataSource = data;
        }
        private void FormAuthors_Load(object sender, EventArgs e)
        {
            DatabaseLoad();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO authors(name , surname) VALUES (@name, @surname)";
            command = new SqlCommand(query,connectToDB);
            command.Parameters.AddWithValue("@name", textBoxName.Text);
            command.Parameters.AddWithValue("@surname", textBoxSurname.Text);
            connectToDB.Open();
            command.ExecuteNonQuery();
            connectToDB.Close();
            DatabaseLoad();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM authors WHERE authorId=@authorId";
            command = new SqlCommand(query, connectToDB);
            command.Parameters.AddWithValue("@authorId",Convert.ToInt32(textBoxId.Text));
            connectToDB.Open();
            command.ExecuteNonQuery();
            connectToDB.Close();
            DatabaseLoad();
        }
    }
}
