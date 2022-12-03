using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace The_first_project
{
    public partial class NewMember : Form
    {
        public NewMember()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        String v;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            String fName = textFarstName.Text;
            String lName = textLastName.Text;
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
            String dateTimePBD = dateTimePickerBirthDate.Text;
            Int64 telephone = Int64.Parse(textTelephone.Text);
            String email = textEmail.Text;
            String joinDate = dateTimePickerJoinDate.Text;
            String gymTime = comboBGymTime.Text;
            String address = textAddress.Text;
            String membership = comboBoxMembership.Text;
            String subscriptionPrice = textSubscriptionPrice.Text;

            if (fName == "" || lName == "" || gender == "" || dateTimePBD == "" || email == ""
                || joinDate == "" || gymTime == "" || address == "" || membership == "")
            {
                MessageBox.Show("All data must be filled out");
            }
            else
            {
                switch (membership)
                {
                    case "1 Month":
                        subscriptionPrice = "50";
                        // كيف اخلى القيمة تظهر لما احدد مثل 1 شهر قبل ما اعمل اضافة
                       // Console.WriteLine("50");
                        break;
                    case "2 Month":
                        subscriptionPrice = "85";
                        //  Console.WriteLine("85");
                        break;
                    case "3 Month":
                        subscriptionPrice = "135";
                       // Console.WriteLine("135");
                        break;
                    case "6 Month":
                        subscriptionPrice = "250";
                        //Console.WriteLine("250");
                        break;
                    case "1 Year":
                        subscriptionPrice = "500";
                       // Console.WriteLine("500");
                        break;
                    default:
                       // MessageBox.Show("I'm sorry, I don't understand that!");
                        break;
                }

                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "data source = DESKTOP-LMDSTSF; database = gymMembership2; integrated security = True";
                SqlCommand command = new SqlCommand();
                command.Connection = connection;

                command.CommandText = "insert into NewMomber (fName,Lname,Gender,dateTimePBD,telephone,Email,JoinDate,GymTime,Address,MembershipTime,SubscriptionPrice) values ('" + fName + "' , '" + lName + "' , '" + gender + "','" + dateTimePBD + "', '" + telephone + "','" + email + "','" + joinDate + "','" + gymTime + "','" + address + "', '" + membership + "','" + subscriptionPrice + "' )";

                SqlDataAdapter DA = new SqlDataAdapter(command);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                MessageBox.Show("Data Add.");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textFarstName.Clear();
            textLastName.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            dateTimePickerBirthDate.Value = DateTime.Now;
            textTelephone.Clear();
            textEmail.Clear();
            dateTimePickerJoinDate.Value = DateTime.Now;
            comboBGymTime.ResetText();
            textAddress.Clear();
            comboBoxMembership.ResetText();

        }
    }
}
