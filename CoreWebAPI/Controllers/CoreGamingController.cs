using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;
using CoreWebAPI.CoreWebAPI;

namespace CoreWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoreGamingController : ControllerBase
    {
        //Private Variable
        private ICoreGaming _coreWebAPI;

        //Public Constructor
        public CoreGamingController(ICoreGaming coreWebAPI)
        {
            _coreWebAPI = coreWebAPI;
        }

        //API - /CoreGaming/StartGaming?num=5&guess=bar
        [Route("StartGaming")]
        [HttpGet]
        public IActionResult StartGaming(int num, string guess)
        {
            try
            {

                if (string.IsNullOrEmpty(guess) || num <= 0)
                {
                    return BadRequest();
                }

                 bool result = _coreWebAPI.StartGaming(num, guess);
                if (result)
                    return Ok(new { StatusCode = 200});
                return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
