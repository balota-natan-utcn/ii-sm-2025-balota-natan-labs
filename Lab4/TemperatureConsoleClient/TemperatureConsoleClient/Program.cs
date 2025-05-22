using System.Text;
using System.Text.Json;

namespace TemperatureConsoleClient
{
    class Program
    {
        private static readonly HttpClient httpClient = new HttpClient();
        private static readonly string baseUrl = "https://localhost:7265/api/Temperature"; // Update port as needed

        static async Task Main(string[] args)
        {
            Console.WriteLine("Temperature Conversion Console Client");
            Console.WriteLine("====================================");

            while (true)
            {
                Console.WriteLine("\nChoose conversion type:");
                Console.WriteLine("1. Fahrenheit to Celsius");
                Console.WriteLine("2. Celsius to Fahrenheit");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice (1-3): ");

                string choice = Console.ReadLine() ?? "";

                switch (choice)
                {
                    case "1":
                        await ConvertFahrenheitToCelsius();
                        break;
                    case "2":
                        await ConvertCelsiusToFahrenheit();
                        break;
                    case "3":
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static async Task ConvertFahrenheitToCelsius()
        {
            Console.Write("Enter temperature in Fahrenheit: ");
            if (double.TryParse(Console.ReadLine(), out double fahrenheit))
            {
                try
                {
                    var response = await httpClient.GetAsync($"{baseUrl}/fahrenheit-to-celsius/{fahrenheit}");
                    if (response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        var celsius = JsonSerializer.Deserialize<double>(result);
                        Console.WriteLine($"{fahrenheit}°F = {celsius}°C");
                    }
                    else
                    {
                        Console.WriteLine($"Error: {response.ReasonPhrase}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        static async Task ConvertCelsiusToFahrenheit()
        {
            Console.Write("Enter temperature in Celsius: ");
            if (double.TryParse(Console.ReadLine(), out double celsius))
            {
                try
                {
                    var response = await httpClient.GetAsync($"{baseUrl}/celsius-to-fahrenheit/{celsius}");
                    if (response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        var fahrenheit = JsonSerializer.Deserialize<double>(result);
                        Console.WriteLine($"{celsius}°C = {fahrenheit}°F");
                    }
                    else
                    {
                        Console.WriteLine($"Error: {response.ReasonPhrase}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}