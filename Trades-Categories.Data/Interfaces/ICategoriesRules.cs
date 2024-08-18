using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trades_Categories.Data.DTO.Trades_Categories.Domain.Entities;
using Trades_Categories.Data.Repositories;
using Trades_Categories.Domain.Entities;

namespace Trades_Categories.Data.Interfaces
{
    public interface ICategoriesRules
    {
        public void Remove(int id);

        public void EditRule(CategoriesRulesDTO dto);

        public List<Rules> GetRules();
        public void AddRules(CategoriesRulesDTO dto);
    }
}
