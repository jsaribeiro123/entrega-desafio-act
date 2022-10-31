using AutoMapper;
using Wallet.NFT.Domain.Entity;
using Wallet.NFT.Domain.Entity.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wallet.NFT.Test.Helpers
{
    internal class SourceMappingProfile : Profile
    {
        public SourceMappingProfile()
        {
            CreateMap<Lancamento, LancamentoDto>().ReverseMap();
        }
    }
}
