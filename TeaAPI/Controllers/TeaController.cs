using System;
using Microsoft.AspNetCore.Mvc;

namespace TeaApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class TeaController : ControllerBase
    {
        private static readonly string[] Teas = new[]
        {
            "Green", "Peppermint", "Earl Grey", "English Breakfast", "Camomile"
        };

        [HttpGet]
        public ActionResult Get()
        {
            var nrg = new Random();
            return Ok(Teas[nrg.Next(Teas.Length)]);
        }
    }   
}