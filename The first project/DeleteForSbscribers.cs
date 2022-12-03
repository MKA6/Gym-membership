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
    public partial class DeleteForSbscribers : Form
    {
        public DeleteForSbscribers()
        {
            InitializeComponent();
        }

        private void DeleteForSbscribers_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "data source = DESKTOP-LMDSTSF; database = gymMembership2; integrated security = True";
            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            command.CommandText = "select * from NewMomber";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            dataGridViewDeleteSubscribers.DataSource = dataSet.Tables[0];
        }

        private void buttonSearcEquipment_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure to delete this data?" , "Delete Data" , MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

            

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "data source = DESKTOP-LMDSTSF; database = gymMembership2; integrated security = True";
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
             
            command.CommandText = "delete from NewMomber where MID = " +textDeleteSubscribers.Text + " ";
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

                command.CommandText = "select * from NewMomber";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                dataGridViewDeleteSubscribers.DataSource = dataSet.Tables[0];

            }
        }
    }
}
