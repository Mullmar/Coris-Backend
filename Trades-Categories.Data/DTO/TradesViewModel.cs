using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trades_Categories.Data.DTO
{
    public class TradesViewModel
    {
        public int Id { get; set; }
        public decimal Value { get; set; }
        public string ClientSector { get; set; }

        public string Risk { get; set; }
    }
}
