namespace Project2025
{
    partial class Log_In
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
            this.UserName_txtbox = new System.Windows.Forms.TextBox();
            this.PassWord_txtbox = new System.Windows.Forms.TextBox();
            this.Enter_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserName_txtbox
            // 
            this.UserName_txtbox.Location = new System.Drawing.Point(260, 135);
            this.UserName_txtbox.Name = "UserName_txtbox";
            this.UserName_txtbox.Size = new System.Drawing.Size(100, 20);
            this.UserName_txtbox.TabIndex = 0;
            this.UserName_txtbox.TextChanged += new System.EventHandler(this.UserName_txtbox_TextChanged);
            // 
            // PassWord_txtbox
            // 
            this.PassWord_txtbox.Location = new System.Drawing.Point(260, 180);
            this.PassWord_txtbox.Name = "PassWord_txtbox";
            this.PassWord_txtbox.Size = new System.Drawing.Size(100, 20);
            this.PassWord_txtbox.TabIndex = 1;
            // 
            // Enter_Button
            // 
            this.Enter_Button.Location = new System.Drawing.Point(260, 216);
            this.Enter_Button.Name = "Enter_Button";
            this.Enter_Button.Size = new System.Drawing.Size(75, 23);
            this.Enter_Button.TabIndex = 2;
            this.Enter_Button.Text = "Log In";
            this.Enter_Button.UseVisualStyleBackColor = true;
            this.Enter_Button.Click += new System.EventHandler(this.Enter_Button_Click);
            // 
            // Log_In
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Enter_Button);
            this.Controls.Add(this.PassWord_txtbox);
            this.Controls.Add(this.UserName_txtbox);
            this.Name = "Log_In";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserName_txtbox;
        private System.Windows.Forms.TextBox PassWord_txtbox;
        private System.Windows.Forms.Button Enter_Button;
    }
}

