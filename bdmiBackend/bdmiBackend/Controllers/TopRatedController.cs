using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using DataAccessLibrary.DataAccess;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace bdmiBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TopRatedController : ControllerBase
    {
        private readonly ILogger<TopRatedController> _logger;
        private readonly MovieContext _db;

        public TopRatedController(ILogger<TopRatedController> logger, MovieContext db)
        {
            _logger = logger;
            _db = db;
        }

        [HttpGet]
        public async Task<List<int>> Get()
        {
            return null;
        }
    }
}
