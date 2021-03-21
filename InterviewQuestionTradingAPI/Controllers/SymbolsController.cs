using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MockTradingApi;

namespace InterviewQuestionTradingAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SymbolsController : ControllerBase
    {
        private readonly ILogger<SymbolsController> _logger;

        public SymbolsController(ILogger<SymbolsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Symbol> Get()
        {
            throw new NotImplementedException();
        }
    }
}
