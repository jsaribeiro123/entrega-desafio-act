using Wallet.NFT.Domain.Entity.Dto;
using Wallet.NFT.Domain.Paging;
using Wallet.NFT.Domain.Response;

namespace Wallet.NFT.Service.Interfaces
{
    public interface ILancamentoService : IBaseService <LancamentoDto>
    {
        Task<IBaseResponse<LancamentoDto>> GetByIdServiceAsync(int id);
        Task<IBaseResponse<PagedList<LancamentoDto>>> GetServiceAsync(PagingQueryParameters paging, string author);
    }
}
