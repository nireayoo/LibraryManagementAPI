﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public string GetAll()
        {
            return "Hello from Get";
        }
        [HttpGet("get-file1")]
        public string Get1()
        {
            return "Hello from Get1";
        }
    }
}
