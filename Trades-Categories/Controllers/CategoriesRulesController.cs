using Microsoft.AspNetCore.Mvc;
using Trades_Categories.Data.DTO.Trades_Categories.Domain.Entities;
using Trades_Categories.Data.Interfaces;

namespace Trades_Categories.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriesRulesController : ControllerBase
    {
        
        private readonly ICategoriesRules _rules;
        private readonly IUnitOfWork _unitOfWork;
        public CategoriesRulesController(ICategoriesRules rules, IUnitOfWork unitOfWork)
        {
            _rules = rules;
            _unitOfWork = unitOfWork;

        }

        [HttpGet(Name = "GetAllCategoriesRules")]
        public async Task<IActionResult> GetAll()
        {
            var cRules = _rules.GetRules();
            return Ok(cRules);
        }

        [HttpPost("/Inserir")]
        public IActionResult Inserir(CategoriesRulesDTO dto) { 
            try
            {
                _rules.AddRules(dto);

                _unitOfWork.Commit();

                return Ok("Rule added successfully!");
            }
            catch
            {
                _unitOfWork?.Rollback();
                return null;
            }
        }

        [HttpDelete("/Delete/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _rules.Remove(id);

                _unitOfWork.Commit();

                return Ok("Rule deleted successfully!");
            }
            catch
            {
                _unitOfWork?.Rollback();
                return null;
            }



        }

        [HttpPut("/Update")]
        public IActionResult Update(CategoriesRulesDTO dto)
        {
            try
            {
                _rules.EditRule(dto);

                _unitOfWork.Commit();

                return Ok("Rule updated successfully!");
            }
            catch
            {
                _unitOfWork?.Rollback();
                return null;
            }
        }
    }
}
