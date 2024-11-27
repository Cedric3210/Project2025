using MySql.Data.MySqlClient;
using Project2025.ProjectClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2025
{
    public partial class User_Profile : Form
    {
        public User_Profile()
        {
            InitializeComponent();
            showInfo();
        }
        MySqlConnection connection = new MySqlConnection("Server=localhost;" +
        "Database=dsa_database;UserName= root;" +
        "Password=Cedric43210$");
        private void Back_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainWindowForm mwf = new MainWindowForm();
            mwf.Show();
   
        }

        private void showInfo()
        {
            label1.Text = Log_In.user.Name + " " + Log_In.user.Lastname;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddFriend_Button_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void User_Profile_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void AppliedJobs_Button(object sender, EventArgs e)
        {
            PendingWindow pw = new PendingWindow();
            this.Hide(); pw.Show();
        }
    }
}
