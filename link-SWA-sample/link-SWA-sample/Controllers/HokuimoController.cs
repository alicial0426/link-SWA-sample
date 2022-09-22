using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace link_SWA_sample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HokuimoController : ControllerBase
    {
        private readonly ILogger<HokuimoController> _logger;

        public HokuimoController(ILogger<HokuimoController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetHokuimo")]
        public string Get()
        {
            return DoHokuimo();
        }

        private string DoHokuimo()
        {
            var hkim = "ホクイモ".OrderBy(x => Guid.NewGuid()).Take(2);
            var hk = string.Join("", hkim);
            var im = string.Join("", hkim);
            return $"{hk}{hk}の{im}";
        }
    }
}