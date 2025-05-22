using System;
using System.Drawing;
using System.Windows.Forms;

namespace RGBColorChanger
{
    public partial class Form1 : Form
    {
        private Panel colorPanel;
        private TrackBar redTrackBar;
        private TrackBar greenTrackBar;
        private TrackBar blueTrackBar;
        private NumericUpDown redNumeric;
        private NumericUpDown greenNumeric;
        private NumericUpDown blueNumeric;
        private Label redLabel;
        private Label greenLabel;
        private Label blueLabel;
        private Label hexLabel;
        private TextBox hexTextBox;
        private Button presetButton1;
        private Button presetButton2;
        private Button presetButton3;
        private Button presetButton4;
        private Button randomButton;
        private Label titleLabel;
        private GroupBox controlsGroupBox;
        private GroupBox presetGroupBox;

        private void InitializeComponent()
        {
            this.SuspendLayout();

            // Form properties
            this.Text = "RGB Color Changer";
            this.Size = new Size(600, 500);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Title Label
            this.titleLabel = new Label();
            this.titleLabel.Text = "RGB Color Changer";
            this.titleLabel.Font = new Font("Arial", 16, FontStyle.Bold);
            this.titleLabel.Location = new Point(20, 20);
            this.titleLabel.Size = new Size(200, 30);
            this.titleLabel.ForeColor = Color.DarkBlue;

            // Color Display Panel
            this.colorPanel = new Panel();
            this.colorPanel.Location = new Point(20, 60);
            this.colorPanel.Size = new Size(250, 200);
            this.colorPanel.BorderStyle = BorderStyle.FixedSingle;
            this.colorPanel.BackColor = Color.Black;

            // Controls GroupBox
            this.controlsGroupBox = new GroupBox();
            this.controlsGroupBox.Text = "RGB Controls";
            this.controlsGroupBox.Location = new Point(290, 60);
            this.controlsGroupBox.Size = new Size(280, 200);

            // Red controls
            this.redLabel = new Label();
            this.redLabel.Text = "Red: 0";
            this.redLabel.Location = new Point(15, 25);
            this.redLabel.Size = new Size(60, 20);
            this.redLabel.ForeColor = Color.Red;
            this.redLabel.Font = new Font("Arial", 9, FontStyle.Bold);

            this.redTrackBar = new TrackBar();
            this.redTrackBar.Location = new Point(15, 45);
            this.redTrackBar.Size = new Size(180, 45);
            this.redTrackBar.Maximum = 255;
            this.redTrackBar.Minimum = 0;
            this.redTrackBar.Value = 0;
            this.redTrackBar.TickFrequency = 25;
            this.redTrackBar.ValueChanged += TrackBar_ValueChanged;

            this.redNumeric = new NumericUpDown();
            this.redNumeric.Location = new Point(210, 50);
            this.redNumeric.Size = new Size(60, 20);
            this.redNumeric.Maximum = 255;
            this.redNumeric.Minimum = 0;
            this.redNumeric.Value = 0;
            this.redNumeric.ValueChanged += Numeric_ValueChanged;

            // Green controls
            this.greenLabel = new Label();
            this.greenLabel.Text = "Green: 0";
            this.greenLabel.Location = new Point(15, 75);
            this.greenLabel.Size = new Size(60, 20);
            this.greenLabel.ForeColor = Color.Green;
            this.greenLabel.Font = new Font("Arial", 9, FontStyle.Bold);

            this.greenTrackBar = new TrackBar();
            this.greenTrackBar.Location = new Point(15, 95);
            this.greenTrackBar.Size = new Size(180, 45);
            this.greenTrackBar.Maximum = 255;
            this.greenTrackBar.Minimum = 0;
            this.greenTrackBar.Value = 0;
            this.greenTrackBar.TickFrequency = 25;
            this.greenTrackBar.ValueChanged += TrackBar_ValueChanged;

            this.greenNumeric = new NumericUpDown();
            this.greenNumeric.Location = new Point(210, 100);
            this.greenNumeric.Size = new Size(60, 20);
            this.greenNumeric.Maximum = 255;
            this.greenNumeric.Minimum = 0;
            this.greenNumeric.Value = 0;
            this.greenNumeric.ValueChanged += Numeric_ValueChanged;

            // Blue controls
            this.blueLabel = new Label();
            this.blueLabel.Text = "Blue: 0";
            this.blueLabel.Location = new Point(15, 125);
            this.blueLabel.Size = new Size(60, 20);
            this.blueLabel.ForeColor = Color.Blue;
            this.blueLabel.Font = new Font("Arial", 9, FontStyle.Bold);

            this.blueTrackBar = new TrackBar();
            this.blueTrackBar.Location = new Point(15, 145);
            this.blueTrackBar.Size = new Size(180, 45);
            this.blueTrackBar.Maximum = 255;
            this.blueTrackBar.Minimum = 0;
            this.blueTrackBar.Value = 0;
            this.blueTrackBar.TickFrequency = 25;
            this.blueTrackBar.ValueChanged += TrackBar_ValueChanged;

            this.blueNumeric = new NumericUpDown();
            this.blueNumeric.Location = new Point(210, 150);
            this.blueNumeric.Size = new Size(60, 20);
            this.blueNumeric.Maximum = 255;
            this.blueNumeric.Minimum = 0;
            this.blueNumeric.Value = 0;
            this.blueNumeric.ValueChanged += Numeric_ValueChanged;

            // Hex color display
            this.hexLabel = new Label();
            this.hexLabel.Text = "Hex Color:";
            this.hexLabel.Location = new Point(20, 280);
            this.hexLabel.Size = new Size(70, 20);
            this.hexLabel.Font = new Font("Arial", 9, FontStyle.Bold);

            this.hexTextBox = new TextBox();
            this.hexTextBox.Location = new Point(100, 278);
            this.hexTextBox.Size = new Size(100, 20);
            this.hexTextBox.ReadOnly = true;
            this.hexTextBox.BackColor = Color.White;
            this.hexTextBox.Font = new Font("Courier New", 9);

            // Preset GroupBox
            this.presetGroupBox = new GroupBox();
            this.presetGroupBox.Text = "Color Presets";
            this.presetGroupBox.Location = new Point(20, 320);
            this.presetGroupBox.Size = new Size(550, 80);

            // Preset buttons
            this.presetButton1 = new Button();
            this.presetButton1.Text = "Red";
            this.presetButton1.Location = new Point(20, 30);
            this.presetButton1.Size = new Size(80, 30);
            this.presetButton1.BackColor = Color.Red;
            this.presetButton1.ForeColor = Color.White;
            this.presetButton1.Click += PresetButton1_Click;

            this.presetButton2 = new Button();
            this.presetButton2.Text = "Green";
            this.presetButton2.Location = new Point(120, 30);
            this.presetButton2.Size = new Size(80, 30);
            this.presetButton2.BackColor = Color.Green;
            this.presetButton2.ForeColor = Color.White;
            this.presetButton2.Click += PresetButton2_Click;

            this.presetButton3 = new Button();
            this.presetButton3.Text = "Blue";
            this.presetButton3.Location = new Point(220, 30);
            this.presetButton3.Size = new Size(80, 30);
            this.presetButton3.BackColor = Color.Blue;
            this.presetButton3.ForeColor = Color.White;
            this.presetButton3.Click += PresetButton3_Click;

            this.presetButton4 = new Button();
            this.presetButton4.Text = "Purple";
            this.presetButton4.Location = new Point(320, 30);
            this.presetButton4.Size = new Size(80, 30);
            this.presetButton4.BackColor = Color.Purple;
            this.presetButton4.ForeColor = Color.White;
            this.presetButton4.Click += PresetButton4_Click;

            this.randomButton = new Button();
            this.randomButton.Text = "Random";
            this.randomButton.Location = new Point(420, 30);
            this.randomButton.Size = new Size(80, 30);
            this.randomButton.BackColor = Color.Orange;
            this.randomButton.ForeColor = Color.White;
            this.randomButton.Click += RandomButton_Click;

            // Add controls to form
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.colorPanel);
            this.Controls.Add(this.controlsGroupBox);
            this.Controls.Add(this.hexLabel);
            this.Controls.Add(this.hexTextBox);
            this.Controls.Add(this.presetGroupBox);

            // Add controls to groupboxes
            this.controlsGroupBox.Controls.Add(this.redLabel);
            this.controlsGroupBox.Controls.Add(this.redTrackBar);
            this.controlsGroupBox.Controls.Add(this.redNumeric);
            this.controlsGroupBox.Controls.Add(this.greenLabel);
            this.controlsGroupBox.Controls.Add(this.greenTrackBar);
            this.controlsGroupBox.Controls.Add(this.greenNumeric);
            this.controlsGroupBox.Controls.Add(this.blueLabel);
            this.controlsGroupBox.Controls.Add(this.blueTrackBar);
            this.controlsGroupBox.Controls.Add(this.blueNumeric);

            this.presetGroupBox.Controls.Add(this.presetButton1);
            this.presetGroupBox.Controls.Add(this.presetButton2);
            this.presetGroupBox.Controls.Add(this.presetButton3);
            this.presetGroupBox.Controls.Add(this.presetButton4);
            this.presetGroupBox.Controls.Add(this.randomButton);

            this.ResumeLayout(false);
        }

        private void TrackBar_ValueChanged(object sender, EventArgs e)
        {
            if (sender == redTrackBar)
            {
                redNumeric.Value = redTrackBar.Value;
            }
            else if (sender == greenTrackBar)
            {
                greenNumeric.Value = greenTrackBar.Value;
            }
            else if (sender == blueTrackBar)
            {
                blueNumeric.Value = blueTrackBar.Value;
            }
            UpdateColor();
        }

        private void Numeric_ValueChanged(object sender, EventArgs e)
        {
            if (sender == redNumeric)
            {
                redTrackBar.Value = (int)redNumeric.Value;
            }
            else if (sender == greenNumeric)
            {
                greenTrackBar.Value = (int)greenNumeric.Value;
            }
            else if (sender == blueNumeric)
            {
                blueTrackBar.Value = (int)blueNumeric.Value;
            }
            UpdateColor();
        }

        private void UpdateColor()
        {
            int red = redTrackBar.Value;
            int green = greenTrackBar.Value;
            int blue = blueTrackBar.Value;

            Color newColor = Color.FromArgb(red, green, blue);
            colorPanel.BackColor = newColor;

            // Update labels
            redLabel.Text = $"Red: {red}";
            greenLabel.Text = $"Green: {green}";
            blueLabel.Text = $"Blue: {blue}";

            // Update hex display
            hexTextBox.Text = $"#{red:X2}{green:X2}{blue:X2}";
        }

        private void SetColor(int red, int green, int blue)
        {
            redTrackBar.Value = red;
            greenTrackBar.Value = green;
            blueTrackBar.Value = blue;
            redNumeric.Value = red;
            greenNumeric.Value = green;
            blueNumeric.Value = blue;
            UpdateColor();
        }

        private void PresetButton1_Click(object sender, EventArgs e)
        {
            SetColor(255, 0, 0); // Red
        }

        private void PresetButton2_Click(object sender, EventArgs e)
        {
            SetColor(0, 255, 0); // Green
        }

        private void PresetButton3_Click(object sender, EventArgs e)
        {
            SetColor(0, 0, 255); // Blue
        }

        private void PresetButton4_Click(object sender, EventArgs e)
        {
            SetColor(128, 0, 128); // Purple
        }

        private void RandomButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            SetColor(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));
        }
    }
}