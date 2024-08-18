using System.ComponentModel.DataAnnotations;

namespace Trades_Categories.Data.DTO
{
    public class CategoriesRulesViewModel
    {
        public CategoriesRulesViewModel() { }

        [Key]
        public int ID { get; set; }

        public decimal InitialValue { get; set; }

        public decimal FinalValue { get; set; }

        public string Description { get; set; }

        public string SectorName { get; set;}

    }
}
