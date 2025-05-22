namespace Lab2
{
    partial class Form2
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

        private void LoadWords()
        {
            string filePath = "words.txt";
            if (!File.Exists(filePath))
            {
                MessageBox.Show("File not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //read file and populate list all
            listAll.Items.AddRange(File.ReadAllLines(filePath));
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            //move selected words to listSelected
            if (listAll.SelectedItems != null)
            {
                foreach (var item in listAll.SelectedItems.Cast<string>().ToList())
                {
                    listSelected.Items.Add(item);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listSelected.Items.Clear();
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listAll = new ListBox();
            listSelected = new ListBox();
            btnCopy = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // listAll
            // 
            listAll.FormattingEnabled = true;
            listAll.ItemHeight = 15;
            listAll.Location = new Point(13, 12);
            listAll.Name = "listAll";
            listAll.Size = new Size(558, 184);
            listAll.TabIndex = 0;
            // 
            // listSelected
            // 
            listSelected.FormattingEnabled = true;
            listSelected.ItemHeight = 15;
            listSelected.Location = new Point(13, 202);
            listSelected.Name = "listSelected";
            listSelected.Size = new Size(558, 184);
            listSelected.TabIndex = 1;
            // 
            // btnCopy
            // 
            btnCopy.Location = new Point(577, 188);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(75, 23);
            btnCopy.TabIndex = 2;
            btnCopy.Text = "Copy";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(496, 392);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(btnCopy);
            Controls.Add(listSelected);
            Controls.Add(listAll);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);

            LoadWords();

            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
        }

        #endregion

        private ListBox listAll;
        private ListBox listSelected;
        private Button btnCopy;
        private Button btnClear;
    }
}