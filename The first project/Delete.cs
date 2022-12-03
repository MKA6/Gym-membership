using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_first_project
{
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteForSbscribers deleteForSbscribers = new DeleteForSbscribers();
            deleteForSbscribers.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteForEmployees deleteForEmployees = new DeleteForEmployees();
            deleteForEmployees.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteForEquipment deleteForEquipment = new DeleteForEquipment();
            deleteForEquipment.Show();
        }
    }
}
