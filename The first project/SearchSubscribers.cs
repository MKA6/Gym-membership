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
    public partial class SearchSubscribers : Form
    {
        public SearchSubscribers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textSearchSubscribers.Text != "")
            {
                /*
                int MID = int.Parse(textSearchSubscribers.Text);
                Int64 telephone = Int64.Parse(textSearchSubscribers.Text);
                */
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "data source = DESKTOP-LMDSTSF; database = gymMembership2; integrated security = True";
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "select * from NewStaff where SID = " + textSearchSubscribers.Text + " ";
                 
                /*
                command.CommandText = "select * from NewMomber where MID LIKE %[" + MID + "]% " +
                    " or fName LIKE '%[" + textSearchSubscribers.Text + "]%' " +
                    " or Lname LIKE '%[" + textSearchSubscribers.Text + "]%' " +
                    " or Gender LIKE '%[" + textSearchSubscribers.Text + "]%' " +
                    " or dateTimePBD LIKE '%[" + textSearchSubscribers.Text + "]%' " +
                    " or telephone LIKE %[" + telephone + "]% " +
                    " or Email LIKE '%[" + textSearchSubscribers.Text + "]%' " +
                    " or JoinDate LIKE '%[" + textSearchSubscribers.Text + "]%' " +
                    " or GymTime LIKE '%[" + textSearchSubscribers.Text + "]%' " +
                    " or Address LIKE '%[" + textSearchSubscribers.Text + "]%' " +
                    " or MembershipTime LIKE '%[" + textSearchSubscribers.Text + "]%' ";
                */

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);

                dataGridViewSearchSubscribers.DataSource = dataSet.Tables[0];

            }
            else
            {
                MessageBox.Show("You must enter a value", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void SearchSubscribers_Load(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "data source = DESKTOP-LMDSTSF; database = gymMembership2; integrated security = True";
            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            command.CommandText = "select * from NewMomber";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            dataGridViewSearchSubscribers.DataSource = dataSet.Tables[0];

        }
    }
}
