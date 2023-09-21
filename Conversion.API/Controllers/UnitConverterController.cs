using Conversion.API.Models.DTO;
using Conversion.API.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Conversion.API.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class UnitConverterController : ControllerBase
    {
        private readonly IUnitMasterRepository unitMasterRepository;

        public UnitConverterController(IUnitMasterRepository unitMasterRepository)
        {
            this.unitMasterRepository = unitMasterRepository;
        }

        [HttpGet]
        [Route("api/UnitConverter/GetMTICelsiusToFahrenheit/{ValueToConvert}")]
        public async Task<IActionResult> GetMTICelsiusToFahrenheit(string ValueToConvert)
        {
            try
            {
                var ConverterValue = await unitMasterRepository.GetByUnitType("CelsiusToFahrenheit");
                if (ConverterValue is null)
                {
                    return NotFound();
                }

                var response = new ConvertedResponseDto
                {
                    ConvertedValue = Convert.ToDecimal((Convert.ToDecimal(ValueToConvert) * 9 / 5) + ConverterValue.MetricToImperial)
                };

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("api/UnitConverter/GetITMFahrenheitToCelsius/{ValueToConvert}")]
        public async Task<IActionResult> GetITMFahrenheitToCelsius(string ValueToConvert)
        {
            try
            {
                var ConverterValue = await unitMasterRepository.GetByUnitType("FahrenheitToCelsius");
                if (ConverterValue is null)
                {
                    return NotFound();
                }

                var response = new ConvertedResponseDto
                {
                    ConvertedValue = Convert.ToDecimal((Convert.ToDecimal(ValueToConvert) - ConverterValue.ImperialToMetric) * 5 / 9)
                };

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("api/UnitConverter/GetMTIMetersToInches/{ValueToConvert}")]
        public async Task<IActionResult> GetMTIMetersToInches(string ValueToConvert)
        {
            try
            {
                var ConverterValue = await unitMasterRepository.GetByUnitType("MetersToInches");
                if (ConverterValue is null)
                {
                    return NotFound();
                }

                var response = new ConvertedResponseDto
                {
                    ConvertedValue = Convert.ToDecimal(Convert.ToDecimal(ValueToConvert) * ConverterValue.MetricToImperial)
                };

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("api/UnitConverter/GetITMInchesToMeters/{ValueToConvert}")]
        public async Task<IActionResult> GetITMInchesToMeters(string ValueToConvert)
        {
            try
            {
                var ConverterValue = await unitMasterRepository.GetByUnitType("InchesToMeters");
                if (ConverterValue is null)
                {
                    return NotFound();
                }

                var response = new ConvertedResponseDto
                {
                    ConvertedValue = Convert.ToDecimal(Convert.ToDecimal(ValueToConvert) * ConverterValue.ImperialToMetric)
                };

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("api/UnitConverter/GetMTIKgsToPounds/{ValueToConvert}")]
        public async Task<IActionResult> GetMTIKgsToPounds(string ValueToConvert)
        {
            try
            {
                var ConverterValue = await unitMasterRepository.GetByUnitType("KgToPounds");
                if (ConverterValue is null)
                {
                    return NotFound();
                }

                var response = new ConvertedResponseDto
                {
                    ConvertedValue = Convert.ToDecimal(Convert.ToDecimal(ValueToConvert) * ConverterValue.MetricToImperial)
                };

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("api/UnitConverter/GetITMPoundsToKg/{ValueToConvert}")]
        public async Task<IActionResult> GetITMPoundsToKg(string ValueToConvert)
        {
            try
            {
                var ConverterValue = await unitMasterRepository.GetByUnitType("PoundsToKg");
                if (ConverterValue is null)
                {
                    return NotFound();
                }

                var response = new ConvertedResponseDto
                {
                    ConvertedValue = Convert.ToDecimal(Convert.ToDecimal(ValueToConvert) * ConverterValue.ImperialToMetric)
                };

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("api/UnitConverter/GetTemperatureMTI")]
        public async Task<IActionResult> GetTemperatureMTI()
        {
            return Ok();
        }
    }
}
