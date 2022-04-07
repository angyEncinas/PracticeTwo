﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace practiceTwo2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok();
        }
        [HttpPost]
        public IActionResult PostUsers()
        {
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteUsers()
        {
            return Ok();
        }
        [HttpPut]
        public IActionResult PutUsers()
        {
            return Ok();
        }
    }
}
