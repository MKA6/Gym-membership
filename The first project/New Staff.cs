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
    public partial class New_Staff : Form
    {
        public New_Staff()
        {
            InitializeComponent();
        }

        private void textLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String fName = textFName.Text;
            String lName = textLName.Text;
            String gender = "";
            bool isChacked = radioButton1.Checked;
            if (isChacked)
            {
                gender = radioButton1.Text;
            }
            else
            {
                gender = radioButton2.Text;
            }
            String dateTimePBD = dateTimePBirthDate.Text;
            Int64 telephone = Int64.Parse(text_Telephone.Text);
            String email = text_Email.Text;
            String joinDate = dateTimePJoinDate.Text;
            String startingDate = textStartingDate.Text;
            String city = textCity.Text;
            float salary = float.Parse(textSalary.Text);

            if (fName == "" || lName == "" || gender == "" || dateTimePBD == "" || email == ""
                || joinDate == "" || city == "" )
            {
                MessageBox.Show("All data must be filled out");
            }
            else
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "data source = DESKTOP-LMDSTSF; database = gymMembership2; integrated security = True";
                SqlCommand command = new SqlCommand();
                command.Connection = connection;

                command.CommandText = "insert into NewStaff (fName,lName,Gender,DateTimePBD,Telephone,Email,JoinDate,StartingDate,City,Salary) values ('" + fName + "' , '" + lName + "' , '" + gender + "','" + dateTimePBD + "', '" + telephone + "','" + email + "','" + joinDate + "','" + startingDate + "','" + city + "','" + salary + "' )";

                SqlDataAdapter DA = new SqlDataAdapter(command);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                MessageBox.Show("Data Add.");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textFName.Clear();
            textLName.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            dateTimePBirthDate.Value = DateTime.Now;
            text_Telephone.Clear();
            text_Email.Clear();
            dateTimePJoinDate.Value = DateTime.Now;
            textStartingDate.Clear();
            textCity.Clear();
            textSalary.Clear();
        }
    }
}
