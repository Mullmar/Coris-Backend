using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trades_Categories.Domain.Entities
{
    [Table("CategoriesRules")]
    public class Rules
    {
        public Rules() { }

        [Key]
        public int ID { get; set; }

        public decimal InitialValue { get; set; }

        public decimal FinalValue { get; set; }

        public string Description { get; set; }

        public int SectorId { get; set; }

    }
}