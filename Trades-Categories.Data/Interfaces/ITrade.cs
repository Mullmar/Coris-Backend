using Trades_Categories.Data.DTO;

namespace Trades_Categories.Data.Interfaces
{
    public interface ITrade
    {
        public decimal Value { get; set; }
        public int ClientSector { get; set; }

        public List<TradesViewModel> GetTrades(IEnumerable<TradesDTO> trades);
    }
}