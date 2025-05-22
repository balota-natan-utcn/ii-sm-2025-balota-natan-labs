using Microsoft.AspNetCore.Mvc;

namespace TemperatureConversionService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TemperatureController : ControllerBase
    {
        [HttpGet("fahrenheit-to-celsius/{fahrenheit}")]
        public ActionResult<double> FahrenheitToCelsius(double fahrenheit)
        {
            try
            {
                double celsius = (fahrenheit - 32) * 5 / 9;
                return Ok(Math.Round(celsius, 2));
            }
            catch (Exception ex)
            {
                return BadRequest($"Error converting temperature: {ex.Message}");
            }
        }

        [HttpGet("celsius-to-fahrenheit/{celsius}")]
        public ActionResult<double> CelsiusToFahrenheit(double celsius)
        {
            try
            {
                double fahrenheit = (celsius * 9 / 5) + 32;
                return Ok(Math.Round(fahrenheit, 2));
            }
            catch (Exception ex)
            {
                return BadRequest($"Error converting temperature: {ex.Message}");
            }
        }

        [HttpPost("convert")]
        public ActionResult<TemperatureResult> ConvertTemperature([FromBody] TemperatureRequest request)
        {
            try
            {
                double result;
                string resultUnit;

                if (request.FromUnit.ToLower() == "fahrenheit" && request.ToUnit.ToLower() == "celsius")
                {
                    result = (request.Value - 32) * 5 / 9;
                    resultUnit = "Celsius";
                }
                else if (request.FromUnit.ToLower() == "celsius" && request.ToUnit.ToLower() == "fahrenheit")
                {
                    result = (request.Value * 9 / 5) + 32;
                    resultUnit = "Fahrenheit";
                }
                else
                {
                    return BadRequest("Invalid conversion units. Use 'Fahrenheit' or 'Celsius'.");
                }

                return Ok(new TemperatureResult
                {
                    OriginalValue = request.Value,
                    OriginalUnit = request.FromUnit,
                    ConvertedValue = Math.Round(result, 2),
                    ConvertedUnit = resultUnit
                });
            }
            catch (Exception ex)
            {
                return BadRequest($"Error converting temperature: {ex.Message}");
            }
        }
    }

    public class TemperatureRequest
    {
        public double Value { get; set; }
        public string FromUnit { get; set; } = string.Empty;
        public string ToUnit { get; set; } = string.Empty;
    }

    public class TemperatureResult
    {
        public double OriginalValue { get; set; }
        public string OriginalUnit { get; set; } = string.Empty;
        public double ConvertedValue { get; set; }
        public string ConvertedUnit { get; set; } = string.Empty;
    }
}