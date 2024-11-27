using MySql.Data.MySqlClient;
using Project2025.ProjectClass;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Project2025
{

    public partial class Log_In : Form
    {
        public Log_In()
        {
            InitializeComponent();
            AddIntoMemory();
        }
        public static User user;

        MySqlConnection connection = new MySqlConnection("Server=localhost;" +
   "Database=dsa_database;UserName= root;" +
   "Password=Cedric43210$");
       
        Dictionary<string, string> mapList = new Dictionary<string, string>();
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }

        private void AddIntoMemory()
        {
            if (mapList.Count > 0) return;
            try
            {
                connection.Open();
                string query = "SELECT first_name, last_name FROM data ";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                         string userName = reader.GetString("first_name").Trim();
                         string passWord = reader.GetString("last_name"); 

                        mapList.Add(userName, passWord);
 
                    }
                }
            }

            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            finally { connection.Close(); }
        }
        private bool LoggedIn(string username, string password)
        {

            string sanitizedUsername = username;
            string sanitizedPassword = mapList[username];
            user = new User(1,sanitizedUsername, sanitizedPassword);

            // Hash the entered password
            string hashedPassword = HashPassword(sanitizedPassword);

            // Check if username exists and passwords match
            if (mapList.TryGetValue(sanitizedUsername, out string storedHash))
            {
                return storedHash == sanitizedPassword;
            }

            return false;
        }


        private void Enter_Button_Click(object sender, EventArgs e)
        {
            // Load data into memory if not already loaded
           

            // Get sanitized inputs
            string sanitizedUsername = UserName_txtbox.Text.Trim();
            string sanitizedPassword = PassWord_txtbox.Text.Trim();

            // Check if the user can log in
            if (LoggedIn(sanitizedUsername, sanitizedPassword))
            {
              
                this.Hide();   
                MainWindowForm mwf = new MainWindowForm();
                mwf.Show();
            }
            else
            {
                MessageBox.Show("Wrong username or password.");
            }
        }

        private void UserName_txtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
