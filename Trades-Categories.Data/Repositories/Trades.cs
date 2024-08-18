using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Trades_Categories.Data.DTO;
using Trades_Categories.Data.Interfaces;
using Trades_Categories.InfraStructure.Context;

namespace Trades_Categories.Data.Repositories
{
    public class Trades : ITrade
    {
        public decimal Value { get; set; }
        public int ClientSector { get; set; }

        private readonly Context _context;
        public Trades(Context context)
        {
            _context = context;
        }
        public List<TradesViewModel> GetTrades(IEnumerable<TradesDTO> trades)
        {
            var cTrades = from trade in trades
                          join cr in _context.CategoriesRules on trade.ClientSector equals cr.SectorId
                          join s in _context.Sector on trade.ClientSector equals s.ID
                          where trade.Value >= cr.InitialValue && trade.Value < cr.FinalValue
                          select new TradesViewModel()
                          {
                              Id = trade.Id,
                              Value = trade.Value,
                              ClientSector = s.Description,
                              Risk = cr.Description
                          };
                         
            return cTrades.ToList();
        }
    }
}
