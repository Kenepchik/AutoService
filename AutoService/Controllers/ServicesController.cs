using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AutoService.Controllers
{
    [Route("api")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly CarsServiceContext context = new CarsServiceContext();
        [HttpGet("services")]
        public List<Services> GetServices()
        {
            var a = context.Services.Include("Masters").ToList();
            return a;
        }
    }
}
