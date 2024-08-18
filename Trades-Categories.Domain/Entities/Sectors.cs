using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trades_Categories.Domain.Entities
{
    [Table("Sector")]
    public class Sectors
    {
        [Key]
        public int ID { get; set; }
        public string Description { get; set; }
    }
}
