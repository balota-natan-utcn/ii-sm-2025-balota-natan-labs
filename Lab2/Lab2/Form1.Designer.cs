namespace Lab2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(125, 103);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(229, 23);
            txtUsername.TabIndex = 0;
            txtUsername.Text = "user";
            txtUsername.TextChanged += textBox1_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(125, 166);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(229, 23);
            txtPassword.TabIndex = 1;
            txtPassword.Text = "pass";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(125, 225);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();

            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string filePath = "credentials.txt"; // Ensure this file is in the executable directory or use an absolute path

            if (IsValidCredentials(username, password, filePath))
            {
                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide(); // Hide Form1
                MenuForm menu = new MenuForm();
                menu.ShowDialog();
                this.Close(); // Close Form1 when menu form is open
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidCredentials(string username, string password, string filePath)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Credentials file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Read all lines and check for a match
            foreach (string line in File.ReadLines(filePath))
            {
                string[] parts = line.Split(':');
                if (parts.Length == 2)
                {
                    string storedUsername = parts[0].Trim();
                    string storedPassword = parts[1].Trim();

                    if (storedUsername == username && storedPassword == password)
                    {
                        return true; // Valid login
                    }
                }
            }

            return false; // No match found
        }
    }
}
