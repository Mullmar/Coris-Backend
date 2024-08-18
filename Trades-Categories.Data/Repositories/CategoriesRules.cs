using AutoMapper;
using Trades_Categories.Data.DTO.Trades_Categories.Domain.Entities;
using Trades_Categories.Data.Interfaces;
using Trades_Categories.Domain.Entities;
using Trades_Categories.InfraStructure.Context;

namespace Trades_Categories.Data.Repositories
{
    public class CategoriesRules : ICategoriesRules
    {
        private readonly Context _context;
        private readonly IMapper _mapper;
        public CategoriesRules(Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public void AddRules(CategoriesRulesDTO dto)
        {
            var rulesDTO = _mapper.Map<Rules>(dto);
            _context.CategoriesRules.Add(rulesDTO);
        }

        public void EditRule(CategoriesRulesDTO dto)
        {
            var rulesDTO = _mapper.Map<Rules>(dto);
            _context.CategoriesRules.Update(rulesDTO);
        }

        public List<Rules> GetRules() {

            return _context.CategoriesRules.ToList();
        }

        public void Remove(int id)
        {
            Rules rule = new Rules
            {
                ID = id
            };
            _context.CategoriesRules.Remove(rule);
        }
    }
}