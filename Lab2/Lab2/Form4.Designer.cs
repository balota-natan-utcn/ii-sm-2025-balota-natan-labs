namespace Lab2
{
    partial class Form4
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

        private Dictionary<string, string> itemImages = new Dictionary<string, string>()
        {
            {"Audi", "audi.jpg"},
            {"BMW", "bmw.jpg"},
            {"Mercedes", "mercedes.jpg"},
            {"Athens", "athens.jpg"},
            {"Bucharest", "bucharest.jpg"},
            {"Tokyo", "tokyo.jpg"}
        };

        private void PopulateListBox()
        {
            listItems.Items.AddRange(new string[] { "Audi", "BMW", "Mercedes", "Athens", "Bucharest", "Tokyo" });
        }

        private void listItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listItems.SelectedItem == null) return;

            string selectedItem = listItems.SelectedItem.ToString();
            if (itemImages.ContainsKey(selectedItem))
            {
                string imagePath = itemImages[selectedItem];
                if (System.IO.File.Exists(imagePath))
                {
                    pictureBox.Image = Image.FromFile(imagePath);
                }
                else
                {
                    MessageBox.Show("Image not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnShowSelection_Click(object sender, EventArgs e)
        {
            string selectedOption1 = "";
            string selectedOption2 = "";

            foreach (RadioButton rb in groupBox1.Controls)
            {
                if (rb.Checked) selectedOption1 = rb.Text;
            }

            foreach (RadioButton rb in groupBox2.Controls)
            {
                if (rb.Checked) selectedOption2 = rb.Text;
            }

            if (string.IsNullOrEmpty(selectedOption1) || string.IsNullOrEmpty(selectedOption2))
            {
                MessageBox.Show("Please select one option from each group.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show($"Selected: {selectedOption1} & {selectedOption2}", "Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            pictureBox = new PictureBox();
            listItems = new ListBox();
            tabPage2 = new TabPage();
            btnShowSelection = new Button();
            groupBox2 = new GroupBox();
            radioOption2_2 = new RadioButton();
            radioOption2_1 = new RadioButton();
            groupBox1 = new GroupBox();
            radioOption1_2 = new RadioButton();
            radioOption1_1 = new RadioButton();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            tabPage2.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1159, 1100);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(pictureBox);
            tabPage1.Controls.Add(listItems);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1151, 1072);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Items & Images";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(224, 8);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(600, 400);
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            pictureBox.Click += pictureBox_Click;
            // 
            // listItems
            // 
            listItems.FormattingEnabled = true;
            listItems.ItemHeight = 15;
            listItems.Location = new Point(8, 8);
            listItems.Name = "listItems";
            listItems.Size = new Size(165, 394);
            listItems.TabIndex = 0;
            listItems.SelectedIndexChanged += listItems_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnShowSelection);
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1151, 1072);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Radio Buttons";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnShowSelection
            // 
            btnShowSelection.Location = new Point(506, 6);
            btnShowSelection.Name = "btnShowSelection";
            btnShowSelection.Size = new Size(75, 23);
            btnShowSelection.TabIndex = 2;
            btnShowSelection.Text = "Show Selection";
            btnShowSelection.UseVisualStyleBackColor = true;
            btnShowSelection.Click += btnShowSelection_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioOption2_2);
            groupBox2.Controls.Add(radioOption2_1);
            groupBox2.Location = new Point(256, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(244, 404);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // radioOption2_2
            // 
            radioOption2_2.AutoSize = true;
            radioOption2_2.Location = new Point(6, 63);
            radioOption2_2.Name = "radioOption2_2";
            radioOption2_2.Size = new Size(94, 19);
            radioOption2_2.TabIndex = 0;
            radioOption2_2.TabStop = true;
            radioOption2_2.Text = "radioButton3";
            radioOption2_2.UseVisualStyleBackColor = true;
            // 
            // radioOption2_1
            // 
            radioOption2_1.AutoSize = true;
            radioOption2_1.Location = new Point(6, 38);
            radioOption2_1.Name = "radioOption2_1";
            radioOption2_1.Size = new Size(94, 19);
            radioOption2_1.TabIndex = 0;
            radioOption2_1.TabStop = true;
            radioOption2_1.Text = "radioButton3";
            radioOption2_1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioOption1_2);
            groupBox1.Controls.Add(radioOption1_1);
            groupBox1.Location = new Point(5, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(245, 402);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // radioOption1_2
            // 
            radioOption1_2.AutoSize = true;
            radioOption1_2.Location = new Point(1, 61);
            radioOption1_2.Name = "radioOption1_2";
            radioOption1_2.Size = new Size(106, 19);
            radioOption1_2.TabIndex = 0;
            radioOption1_2.TabStop = true;
            radioOption1_2.Text = "radioOption1_2";
            radioOption1_2.UseVisualStyleBackColor = true;
            // 
            // radioOption1_1
            // 
            radioOption1_1.AutoSize = true;
            radioOption1_1.Location = new Point(1, 36);
            radioOption1_1.Name = "radioOption1_1";
            radioOption1_1.Size = new Size(106, 19);
            radioOption1_1.TabIndex = 0;
            radioOption1_1.TabStop = true;
            radioOption1_1.Text = "radioOption1_1";
            radioOption1_1.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 861);
            Controls.Add(tabControl1);
            Name = "Form4";
            Text = "Form4";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            tabPage2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);

            PopulateListBox();
            listItems.SelectedIndexChanged += listItems_SelectedIndexChanged;
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private PictureBox pictureBox;
        private ListBox listItems;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private RadioButton radioOption1_1;
        private RadioButton radioOption1_2;
        private GroupBox groupBox2;
        private RadioButton radioOption2_1;
        private Button btnShowSelection;
        private RadioButton radioOption2_2;
    }
}