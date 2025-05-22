namespace Lab2
{
    partial class Form3
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

        private void PerformOperation(char op)
        {
            //validate input
            if (!double.TryParse(txtNumber1.Text, out double num1) || !double.TryParse(txtNumber2.Text, out double num2))
            {
                MessageBox.Show("Please enter valid numbers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double result = 0;
            switch (op)
            {
                case '+': result = num1 + num2; break;
                case '-': result = num1 - num2; break;
                case '*': result = num1 * num2; break;
                case '/':
                    if (num2 == 0)
                    {
                        MessageBox.Show("Cannot divide by zero!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    result = num1 / num2;
                    break;
            }

            //display result
            txtResult.Text = result.ToString();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e) => PerformOperation('+');
        private void subtractToolStripMenuItem_Click(object sender, EventArgs e) => PerformOperation('-');
        private void multiplyToolStripMenuItem_Click(object sender, EventArgs e) => PerformOperation('*');
        private void divideToolStripMenuItem_Click(object sender, EventArgs e) => PerformOperation('/');

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNumber1 = new TextBox();
            txtNumber2 = new TextBox();
            txtResult = new TextBox();
            menuStrip1 = new MenuStrip();
            operatorsToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            substractToolStripMenuItem = new ToolStripMenuItem();
            multiplyToolStripMenuItem = new ToolStripMenuItem();
            divideToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNumber1
            // 
            txtNumber1.Location = new Point(12, 157);
            txtNumber1.Name = "txtNumber1";
            txtNumber1.Size = new Size(225, 23);
            txtNumber1.TabIndex = 1;
            // 
            // txtNumber2
            // 
            txtNumber2.Location = new Point(263, 157);
            txtNumber2.Name = "txtNumber2";
            txtNumber2.Size = new Size(225, 23);
            txtNumber2.TabIndex = 2;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(563, 157);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(225, 23);
            txtResult.TabIndex = 3;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { operatorsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // operatorsToolStripMenuItem
            // 
            operatorsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem, substractToolStripMenuItem, multiplyToolStripMenuItem, divideToolStripMenuItem });
            operatorsToolStripMenuItem.Name = "operatorsToolStripMenuItem";
            operatorsToolStripMenuItem.Size = new Size(71, 20);
            operatorsToolStripMenuItem.Text = "Operators";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(180, 22);
            addToolStripMenuItem.Text = "Add";
            addToolStripMenuItem.Click += addToolStripMenuItem_Click_1;
            // 
            // substractToolStripMenuItem
            // 
            substractToolStripMenuItem.Name = "substractToolStripMenuItem";
            substractToolStripMenuItem.Size = new Size(180, 22);
            substractToolStripMenuItem.Text = "Substract";
            substractToolStripMenuItem.Click += substractToolStripMenuItem_Click;
            // 
            // multiplyToolStripMenuItem
            // 
            multiplyToolStripMenuItem.Name = "multiplyToolStripMenuItem";
            multiplyToolStripMenuItem.Size = new Size(180, 22);
            multiplyToolStripMenuItem.Text = "Multiply";
            multiplyToolStripMenuItem.Click += multiplyToolStripMenuItem_Click_1;
            // 
            // divideToolStripMenuItem
            // 
            divideToolStripMenuItem.Name = "divideToolStripMenuItem";
            divideToolStripMenuItem.Size = new Size(180, 22);
            divideToolStripMenuItem.Text = "Divide";
            divideToolStripMenuItem.Click += divideToolStripMenuItem_Click_1;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtResult);
            Controls.Add(txtNumber2);
            Controls.Add(txtNumber1);
            Controls.Add(menuStrip1);
            Name = "Form3";
            Text = "Form3";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNumber1;
        private TextBox txtNumber2;
        private TextBox txtResult;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem operatorsToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem substractToolStripMenuItem;
        private ToolStripMenuItem multiplyToolStripMenuItem;
        private ToolStripMenuItem divideToolStripMenuItem;
    }
}