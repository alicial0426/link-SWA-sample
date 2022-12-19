using Microsoft.AspNetCore.Mvc;

namespace link_SWA_sample.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HokuimoController : ControllerBase
    {
        private readonly ILogger<HokuimoController> _logger;

        public HokuimoController(ILogger<HokuimoController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return DoHokuimo();
        }

        private string DoHokuimo()
        {
            // ホクイモからランダムな2文字をピックする関数
            // 毎回新規GUIDでOrderByすることでランダム出力となる
            var hkim = "ホクイモ".OrderBy(x => Guid.NewGuid()).Take(2);
            // 仕込んだ関数を実行して選ばれた2文字A
            var hk = string.Join("", hkim);
            // 仕込んだ関数を実行して選ばれた2文字B
            var im = string.Join("", hkim);
            // 出力
            return $"{hk}{hk}の{im}";
        }
    }
}