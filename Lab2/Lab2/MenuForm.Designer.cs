namespace Lab2
{
    partial class MenuForm
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

        private void openNewForm(Form form)
        {
            this.Hide(); //hide current form
            form.ShowDialog();
            this.Show();
        }

        private void btnEx2_Click(object sender, EventArgs e)
        {
            openNewForm(new Form2());
        }

        private void btnEx3_Click(object sender, EventArgs e)
        {
            openNewForm(new Form3());
        }

        private void btnEx4_Click(object sender, EventArgs e)
        {
            openNewForm(new Form4());
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEx2 = new Button();
            btnEx3 = new Button();
            btnEx4 = new Button();
            SuspendLayout();
            // 
            // btnEx2
            // 
            btnEx2.Location = new Point(57, 78);
            btnEx2.Name = "btnEx2";
            btnEx2.Size = new Size(99, 43);
            btnEx2.TabIndex = 0;
            btnEx2.Text = "Ex2";
            btnEx2.UseVisualStyleBackColor = true;
            btnEx2.Click += btnEx2_Click;
            // 
            // btnEx3
            // 
            btnEx3.Location = new Point(162, 78);
            btnEx3.Name = "btnEx3";
            btnEx3.Size = new Size(99, 43);
            btnEx3.TabIndex = 1;
            btnEx3.Text = "Ex3";
            btnEx3.UseVisualStyleBackColor = true;
            btnEx3.Click += btnEx3_Click;
            // 
            // btnEx4
            // 
            btnEx4.Location = new Point(267, 78);
            btnEx4.Name = "btnEx4";
            btnEx4.Size = new Size(99, 43);
            btnEx4.TabIndex = 2;
            btnEx4.Text = "Ex4";
            btnEx4.UseVisualStyleBackColor = true;
            btnEx4.Click += btnEx4_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEx4);
            Controls.Add(btnEx3);
            Controls.Add(btnEx2);
            Name = "MenuForm";
            Text = "MenuForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnEx2;
        private Button btnEx3;
        private Button btnEx4;
    }
}