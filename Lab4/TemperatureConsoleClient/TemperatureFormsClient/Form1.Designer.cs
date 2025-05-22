using System.Drawing;
using System.Net.Http;
using System;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace TemperatureFormsClient
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient httpClient = new HttpClient();
        private static readonly string baseUrl = "https://localhost:7265/api/Temperature"; // Update port as needed

        private void InitializeComponent()
        {
            this.txtInput = new TextBox();
            this.txtResult = new TextBox();
            this.rbFahrenheitToCelsius = new RadioButton();
            this.rbCelsiusToFahrenheit = new RadioButton();
            this.btnConvert = new Button();
            this.lblInput = new Label();
            this.lblResult = new Label();
            this.lblTitle = new Label();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            this.lblTitle.Location = new Point(50, 20);
            this.lblTitle.Size = new Size(200, 20);
            this.lblTitle.Text = "Temperature Converter";

            // lblInput
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new Point(50, 70);
            this.lblInput.Size = new Size(120, 15);
            this.lblInput.Text = "Enter Temperature:";

            // txtInput
            this.txtInput.Location = new Point(180, 67);
            this.txtInput.Size = new Size(100, 23);

            // rbFahrenheitToCelsius
            this.rbFahrenheitToCelsius.AutoSize = true;
            this.rbFahrenheitToCelsius.Checked = true;
            this.rbFahrenheitToCelsius.Location = new Point(50, 110);
            this.rbFahrenheitToCelsius.Size = new Size(140, 19);
            this.rbFahrenheitToCelsius.Text = "Fahrenheit to Celsius";
            this.rbFahrenheitToCelsius.UseVisualStyleBackColor = true;

            // rbCelsiusToFahrenheit
            this.rbCelsiusToFahrenheit.AutoSize = true;
            this.rbCelsiusToFahrenheit.Location = new Point(50, 140);
            this.rbCelsiusToFahrenheit.Size = new Size(140, 19);
            this.rbCelsiusToFahrenheit.Text = "Celsius to Fahrenheit";
            this.rbCelsiusToFahrenheit.UseVisualStyleBackColor = true;

            // btnConvert
            this.btnConvert.Location = new Point(50, 180);
            this.btnConvert.Size = new Size(75, 30);
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new EventHandler(this.btnConvert_Click);

            // lblResult
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new Point(50, 230);
            this.lblResult.Size = new Size(42, 15);
            this.lblResult.Text = "Result:";

            // txtResult
            this.txtResult.Location = new Point(100, 227);
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new Size(180, 23);

            // Form1
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(350, 300);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.rbCelsiusToFahrenheit);
            this.Controls.Add(this.rbFahrenheitToCelsius);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.lblTitle);
            this.Text = "Temperature Converter";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private TextBox txtInput;
        private TextBox txtResult;
        private RadioButton rbFahrenheitToCelsius;
        private RadioButton rbCelsiusToFahrenheit;
        private Button btnConvert;
        private Label lblInput;
        private Label lblResult;
        private Label lblTitle;

        private async void btnConvert_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtInput.Text, out double inputValue))
            {
                MessageBox.Show("Please enter a valid number.", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string endpoint;
                string resultText;

                if (rbFahrenheitToCelsius.Checked)
                {
                    endpoint = $"{baseUrl}/fahrenheit-to-celsius/{inputValue}";
                    var response = await httpClient.GetAsync(endpoint);

                    if (response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        var celsius = JsonSerializer.Deserialize<double>(result);
                        resultText = $"{celsius}°C";
                    }
                    else
                    {
                        resultText = "Error occurred";
                    }
                }
                else
                {
                    endpoint = $"{baseUrl}/celsius-to-fahrenheit/{inputValue}";
                    var response = await httpClient.GetAsync(endpoint);

                    if (response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        var fahrenheit = JsonSerializer.Deserialize<double>(result);
                        resultText = $"{fahrenheit}°F";
                    }
                    else
                    {
                        resultText = "Error occurred";
                    }
                }

                txtResult.Text = resultText;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Connection Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}