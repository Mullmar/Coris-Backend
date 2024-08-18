using Microsoft.AspNetCore.Mvc;
using Trades_Categories.Data.DTO;
using Trades_Categories.Data.Interfaces;

namespace Trades_Categories.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TradesController : ControllerBase
    {
        private readonly ITrade _trades;

        public TradesController(ITrade trade)
        {
            _trades = trade;
        }
        [HttpPost(Name = "GetTrades")]
        public IActionResult GetTrades(IEnumerable<TradesDTO> trades)
        {
            var rTrades = _trades.GetTrades(trades);
            
            return Ok(rTrades);
        }
    }
}
