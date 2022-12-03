namespace The_first_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {/*
            toolStripMenuItem1.Image = Image.FromFile(@"G:\UCST\Name-48-50px\img2.jpg");
       */ }
        

        private void equipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Equipment equipment = new Equipment();
            equipment.Show();
        }

        private void newMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewMember newMemder = new NewMember();
            newMemder.Show();
        }

        private void newSaftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Staff new_Staff = new New_Staff();
            new_Staff.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to close the program", "Close" , MessageBoxButtons.YesNo , MessageBoxIcon.Error) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Welcome back to the application", "Welcome" , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Boolean isComplete = true;
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            /*
            if(isComplete == true)
            {
                menuStrip1.Dock = DockStyle.Left;
                isComplete = false;
                toolStripMenuItem1.Image = Image.FromFile(@"G:\UCST\Name-48-50px\img3.jpg");
            }
            else {
                menuStrip1.Dock = DockStyle.Top;
                isComplete = true;
                toolStripMenuItem1.Image = Image.FromFile(@"G:\UCST\Name-48-50px\img2.jpg");
            }
            */
        }

        private void deleteMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete();
            delete.Show();
        }

        private void searchMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure to exit the program", "LogOut" , MessageBoxButtons.OKCancel , MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
                Login login = new Login();
                login.Show();
            }
        }
    }
}