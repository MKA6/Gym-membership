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
    public partial class SearchEquipment : Form
    {
        public SearchEquipment()
        {
            InitializeComponent();
        }

        private void buttonSearcEquipment_Click(object sender, EventArgs e)
        {
            


            if (textSearchEquipment.Text != "")
            {
                /*
                int ID = int.Parse(textSearchEquipment.Text);
                float cost = float.Parse(textSearchEquipment.Text);
                */

                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "data source = DESKTOP-LMDSTSF; database = gymMembership2; integrated security = True";
                SqlCommand command = new SqlCommand();
                command.Connection = connection;

                command.CommandText = "select * from NewStaff where SID = " + textSearchEquipment.Text + " ";
                /*
                command.CommandText = "select * from Equipment1 where" +
                    " ID LIKE %[" + ID + "]% " +
                    " or EquipmentName LIKE '%[" + textSearchEquipment.Text + "]%' " +
                    " or Description LIKE '%[" + textSearchEquipment.Text + "]%' " +
                    " or MusclesUsed LIKE '%[" + textSearchEquipment.Text + "]%' " +
                    " or DeliveryDate LIKE '%[" + textSearchEquipment.Text + "]%' " +
                    " or Cost LIKE %[" + cost + "]%' ";
                */
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);

                dataGridViewSearchEquipment.DataSource = dataSet.Tables[0];

            }
            else
            {
                MessageBox.Show("You must enter a value", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewSearchEquipment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchEquipment_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "data source = DESKTOP-LMDSTSF; database = gymMembership2; integrated security = True";
            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            command.CommandText = "select * from Equipment1";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            dataGridViewSearchEquipment.DataSource = dataSet.Tables[0];
        }
    }
}
