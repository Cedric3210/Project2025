namespace Project2025
{
    partial class MainWindowForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainWindowPanel = new System.Windows.Forms.Panel();
            this.Post_Button = new System.Windows.Forms.Button();
            this.Post_RichtxtBox = new System.Windows.Forms.RichTextBox();
            this.Profile_Button = new System.Windows.Forms.Button();
            this.Log_Out_Button = new System.Windows.Forms.Button();
            this.MainWindowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainWindowPanel
            // 
            this.MainWindowPanel.AutoScroll = true;
            this.MainWindowPanel.Controls.Add(this.Post_Button);
            this.MainWindowPanel.Controls.Add(this.Post_RichtxtBox);
            this.MainWindowPanel.Location = new System.Drawing.Point(136, 81);
            this.MainWindowPanel.Name = "MainWindowPanel";
            this.MainWindowPanel.Size = new System.Drawing.Size(667, 368);
            this.MainWindowPanel.TabIndex = 0;
            // 
            // Post_Button
            // 
            this.Post_Button.Location = new System.Drawing.Point(556, 21);
            this.Post_Button.Name = "Post_Button";
            this.Post_Button.Size = new System.Drawing.Size(75, 23);
            this.Post_Button.TabIndex = 1;
            this.Post_Button.Text = "Post";
            this.Post_Button.UseVisualStyleBackColor = true;
            this.Post_Button.Click += new System.EventHandler(this.Post_Click);
            // 
            // Post_RichtxtBox
            // 
            this.Post_RichtxtBox.Location = new System.Drawing.Point(169, 3);
            this.Post_RichtxtBox.Name = "Post_RichtxtBox";
            this.Post_RichtxtBox.Size = new System.Drawing.Size(381, 149);
            this.Post_RichtxtBox.TabIndex = 0;
            this.Post_RichtxtBox.Text = "";
            this.Post_RichtxtBox.TextChanged += new System.EventHandler(this.Post_RichtxtBox_TextChanged);
            // 
            // Profile_Button
            // 
            this.Profile_Button.Location = new System.Drawing.Point(28, 204);
            this.Profile_Button.Name = "Profile_Button";
            this.Profile_Button.Size = new System.Drawing.Size(75, 23);
            this.Profile_Button.TabIndex = 1;
            this.Profile_Button.Text = "Go to Profile";
            this.Profile_Button.UseVisualStyleBackColor = true;
            this.Profile_Button.Click += new System.EventHandler(this.Profile_Button_Click);
            // 
            // Log_Out_Button
            // 
            this.Log_Out_Button.Location = new System.Drawing.Point(28, 254);
            this.Log_Out_Button.Name = "Log_Out_Button";
            this.Log_Out_Button.Size = new System.Drawing.Size(75, 23);
            this.Log_Out_Button.TabIndex = 2;
            this.Log_Out_Button.Text = "Log Out";
            this.Log_Out_Button.UseVisualStyleBackColor = true;
            this.Log_Out_Button.Click += new System.EventHandler(this.Log_Out_Button_Click);
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Log_Out_Button);
            this.Controls.Add(this.Profile_Button);
            this.Controls.Add(this.MainWindowPanel);
            this.Name = "MainWindowForm";
            this.Text = "MainWindowForm";
            this.MainWindowPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainWindowPanel;
        private System.Windows.Forms.Button Post_Button;
        private System.Windows.Forms.RichTextBox Post_RichtxtBox;
        private System.Windows.Forms.Button Profile_Button;
        private System.Windows.Forms.Button Log_Out_Button;
    }
}