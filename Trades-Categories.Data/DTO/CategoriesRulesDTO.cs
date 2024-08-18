using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trades_Categories.Data.DTO
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    namespace Trades_Categories.Domain.Entities
    {
        public class CategoriesRulesDTO
        {
            public CategoriesRulesDTO() { }

            [Key]
            public int ID { get; set; }

            public decimal InitialValue { get; set; }

            public decimal FinalValue { get; set; }

            public string Description { get; set; }

            public int SectorId { get; set; }

        }
    }
}
