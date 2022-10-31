using Wallet.NFT.Domain;
using Wallet.NFT.Domain.Entity.Dto;
using Wallet.NFT.Domain.Paging;
using Wallet.NFT.Domain.Response;
using Wallet.NFT.DAL.Interfaces;
using Wallet.NFT.Service.Interfaces;
using Wallet.NFT.DAL.Repository;

namespace Wallet.NFT.Service.Implementations
{
    public class LancamentoService //: ILancamentoService
    {/*
        private ILancamentoRepository _lancamentoRep;
        public LancamentoService(ILancamentoRepository lancamentoRep)=> _lancamentoRep = lancamentoRep;
        public async Task<IBaseResponse<LancamentoDto>> CreateServiceAsync(LancamentoDto model)
        {
            var baseResponse = new BaseResponse<LancamentoDto>();
            var lancamento = await _lancamentoRep.CreateAsync(model);
            
            if (lancamento is null)
            {
                baseResponse.DisplayMessage = "Книга создана.";
            }
            else
            {
                baseResponse.DisplayMessage = "Книга не создана.";
            }
            
            baseResponse.Result = book;
            return baseResponse;
        }

        public async Task<IBaseResponse<PagedList<LancamentoDto>>> GetServiceAsync(PagingQueryParameters paging, string author)
        {
            var baseResponse = new BaseResponse<PagedList<LancamentoDto>>();
            IEnumerable<LancamentoDto> lancamentos = await _lancamentoRep.GetByAuthorAsync(author);
            if (lancamentos is null)
            {
                baseResponse.DisplayMessage = $"Книги под именем автора [{author}] не найдены.";
            }
            else
            {
                baseResponse.DisplayMessage = $"Вывод книг под именем автора [{author}].";
            }
            baseResponse.Result = PagedList<LancamentoDto>.ToPagedList(lancamentos, paging.PageNumber, paging.PageSize);
            return baseResponse;
        }
        public async Task<IBaseResponse<LancamentoDto>> GetByIdServiceAsync(int id)
        {
            var baseResponse = new BaseResponse<LancamentoDto>();
            LancamentoDto lancamento = await _lancamentoRep.GetByIdAsync(id);
            if (lancamento is null)
            {
                baseResponse.DisplayMessage = $"Книга под id [{id}] не найдена";
            }
            else
            {
                baseResponse.DisplayMessage = $"Вывод книги под id [{id}]";
            }
            baseResponse.Result = lancamento;
            return baseResponse;
        }
        public async Task<IBaseResponse<PagedList<LancamentoDto>>> GetServiceAsync(PagingQueryParameters paging)
        {
            var baseResponse = new BaseResponse<PagedList<LancamentoDto>>();
            var lancamentos = await _bookRep.GetAsync();
            if (lancamentos is null)
            {
                baseResponse.DisplayMessage = "Список всех книг пуст.";
            }
            else
            {
                baseResponse.DisplayMessage = "Список всех книг.";
            }
            baseResponse.Result = PagedList<LancamentoDto>.ToPagedList(lancamentos, paging.PageNumber, paging.PageSize);
            return baseResponse;
        }
        */
    }
}