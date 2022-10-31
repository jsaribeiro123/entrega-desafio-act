using Wallet.NFT.Domain.Paging;
using Wallet.NFT.Domain.Response;

namespace Wallet.NFT.Service.Interfaces
{
    public interface IBaseService<T>
    {
        Task<IBaseResponse<PagedList<T>>> GetServiceAsync(PagingQueryParameters paging);
        Task<IBaseResponse<T>> CreateServiceAsync(T entity);
    }
}
