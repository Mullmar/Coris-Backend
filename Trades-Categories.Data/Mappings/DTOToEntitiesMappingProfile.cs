using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trades_Categories.Data.DTO.Trades_Categories.Domain.Entities;
using Trades_Categories.Domain.Entities;

namespace Trades_Categories.Data.Mappings
{
    public class DTOToEntitiesMappingProfile : Profile
    {
        public DTOToEntitiesMappingProfile() {
            CreateMap<CategoriesRulesDTO, Rules>().ReverseMap();
        }
    }
}
