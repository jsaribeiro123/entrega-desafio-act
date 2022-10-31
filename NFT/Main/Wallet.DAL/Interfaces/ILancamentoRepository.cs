using Wallet.NFT.Domain.Entity.Dto;

namespace Wallet.NFT.DAL.Interfaces
{
    public interface ILancamentoRepository: IBaseRepository<LancamentoDto>
    {
        //Task<LancamentoDto> GetByIdAsync(int id);
    }
}
