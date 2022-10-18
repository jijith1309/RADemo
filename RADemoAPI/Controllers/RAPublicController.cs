using Microsoft.AspNetCore.Mvc;
using RADemoAPI.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RADemoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RAPublicController : ControllerBase
    {
       
        [HttpPost]
        public async Task<IActionResult> ScanInsurance([FromBody] ScanInsuranceRequestDto request)
        {
            //Encounter not found
            if (1==2)
            {
                return NotFound("Encounter does not exist");
            }
            //Success case
            var successResponse = new ScanInsuranceResponseDto();
            return Ok(successResponse);
        }
        [HttpPost]
        public async Task<IActionResult> SaveInsurance([FromBody] SaveInsuranceRequestDto request)
        {
            //Encounter not found
            if (1 == 2)
            {
                return NotFound("Encounter does not exist");
            }
            //Success case
            var successResponse = new ScanInsuranceResponseDto();
            return Ok(successResponse);
        }
    }
}
