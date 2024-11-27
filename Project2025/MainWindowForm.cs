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
    public partial class MainWindowForm : Form
    {
        LinkedList<RichTextBox> posting = new LinkedList<RichTextBox>();
        private string message { get; set; }
        int counting = 0;
        public MainWindowForm()
        {
            InitializeComponent();
        }

        private void Post_Click(object sender, EventArgs e)
        {
            message = Post_RichtxtBox.Text;

            RichTextBox newPost = new RichTextBox();
            newPost.Location = new Point(20, 60 + (110 * counting));
            newPost.Size = new System.Drawing.Size(50, 50);
            newPost.Text = message;
            newPost.ReadOnly = true;
            counting++;

            Post_RichtxtBox.Clear();
            Post_RichtxtBox.Focus();
            this.Controls.Add(newPost);

            MainWindowPanel.Controls.Add(newPost);

            posting.AddFirst(newPost);
        }

        private void Profile_Button_Click(object sender, EventArgs e)
        {
            User_Profile user = new User_Profile();       
            user.Show();
            this.Hide();
        }

        private void Post_RichtxtBox_TextChanged(object sender, EventArgs e)
        {
            Post_Button.Enabled = !string.IsNullOrWhiteSpace(Post_RichtxtBox.Text);
        }

        private void Log_Out_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Log_In LI = new Log_In();
            LI.Show();
        }
    }
}

