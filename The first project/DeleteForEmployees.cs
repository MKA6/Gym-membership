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

namespace The_first_project
{
    public partial class DeleteForEmployees : Form
    {
        public DeleteForEmployees()
        {
            InitializeComponent();
        }

        private void buttonSearcEmployees_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this data?", "Delete Data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {



                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "data source = DESKTOP-LMDSTSF; database = gymMembership2; integrated security = True";
                SqlCommand command = new SqlCommand();
                command.Connection = connection;

                command.CommandText = "delete from NewStaff where SID = " + textDeleteEmployees.Text + " ";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                MessageBox.Show("The data has been deleted successfully");

            }
            else
            {
                this.Activate();
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "data source = DESKTOP-LMDSTSF; database = gymMembership2; integrated security = True";
                SqlCommand command = new SqlCommand();
                command.Connection = connection;

                command.CommandText = "select * from NewStaff";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                dataGridViewDeleteEmployees.DataSource = dataSet.Tables[0];

            }
        }

        private void DeleteForEmployees_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "data source = DESKTOP-LMDSTSF; database = gymMembership2; integrated security = True";
            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            command.CommandText = "select * from NewStaff";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            dataGridViewDeleteEmployees.DataSource = dataSet.Tables[0];
        }
    }
}
