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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchSubscribers searchSubscribers = new SearchSubscribers();
            searchSubscribers.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchEmployees searchEmployees = new SearchEmployees();
            searchEmployees.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SearchEquipment searchEquipment = new SearchEquipment();
            searchEquipment.Show();
        }
    }
}
