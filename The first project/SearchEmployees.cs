using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace The_first_project
{
    public partial class SearchEmployees : Form
    {
        public SearchEmployees()
        {
            InitializeComponent();
        }

        private void buttonSearchEmployees_Click(object sender, EventArgs e)
        {
            if (textSearchEmployees.Text != "")
            {
                /*
                int SID = int.Parse(textSearchEmployees.Text);
                Int64 telephone = Int64.Parse(textSearchEmployees.Text);
                float salary = float.Parse(textSearchEmployees.Text);
                */
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "data source = DESKTOP-LMDSTSF; database = gymMembership2; integrated security = True";
                SqlCommand command = new SqlCommand();
                command.Connection = connection;


                command.CommandText = "select * from NewStaff where SID = " + textSearchEmployees.Text + " ";
                /*
                command.CommandText = "select * from NewStaff where SID = " + SID + " " +
                   " or fName LIKE '%[" + textSearchEmployees.Text + "]%' " +
                   " or lName LIKE '%[" + textSearchEmployees.Text + "]%' " +
                   " or Gender LIKE '%[" + textSearchEmployees.Text + "]%' " +
                   " or DateTimePBD LIKE '%[" + textSearchEmployees.Text + "]%' " +
                   " or Telephone LIKE " + telephone + " " +
                   " or Email LIKE '%[" + textSearchEmployees.Text + "]%' " +
                   " or JoinDate LIKE '%[" + textSearchEmployees.Text + "]%' " +
                   " or StartingDate LIKE '%[" + textSearchEmployees.Text + "]%' " +
                   " or City LIKE '%[" + textSearchEmployees.Text + "]%' " +
                   " or Salary LIKE %[" + salary + "]% ";
                */
              

               SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);

                dataGridViewSearchEmployees.DataSource = dataSet.Tables[0];

            }
            else
            {
                MessageBox.Show("You must enter a value", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dataGridViewSearchEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void SearchEmployees_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "data source = DESKTOP-LMDSTSF; database = gymMembership2; integrated security = True";
            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            command.CommandText = "select * from NewStaff";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            dataGridViewSearchEmployees.DataSource = dataSet.Tables[0];
        }
    }
}
