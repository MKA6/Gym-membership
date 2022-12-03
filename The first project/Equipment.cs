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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace The_first_project
{
    public partial class Equipment : Form
    {
        public Equipment()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String equipmentName = textEquipmentName.Text;
            String description = richTeDescription.Text;
            String musclesUsed = textMusclesUsed.Text;
            String DeliveryDate = dateTimePickerDeliveryDate.Text;
            float cost = float.Parse(textCost.Text);

            if (equipmentName == "" || description == "" || musclesUsed == "" || DeliveryDate == "")
            {
                MessageBox.Show("All data must be filled out");
            }
            else
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "data source = DESKTOP-LMDSTSF; database = gymMembership2; integrated security = True";
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "insert into Equipment1 (EquipmentName,Description,MusclesUsed,DeliveryDate,Cost) values ('" + equipmentName + "' , '" + description + "' , '" + musclesUsed + "','" + DeliveryDate + "'," + cost + ")";

                SqlDataAdapter DA = new SqlDataAdapter(command);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                MessageBox.Show("Equipment Add.", "Inserted" , MessageBoxButtons.OK , MessageBoxIcon.Information);
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textEquipmentName.Clear();
            richTeDescription.Clear();
            textMusclesUsed.Clear();
            dateTimePickerDeliveryDate.Value = DateTime.Now;
            textCost.Clear();
        }

        private void buttonViewEquipment_Click(object sender, EventArgs e)
        {
            ViewEquipment viewEquipment = new ViewEquipment();
            viewEquipment.Show();
        }
    }
}
