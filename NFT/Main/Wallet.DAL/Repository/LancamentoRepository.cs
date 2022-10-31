using AutoMapper;
using Wallet.NFT.DAL.Interfaces;
using Wallet.NFT.Domain.Entity;
using Wallet.NFT.Domain.Entity.Dto;
using Microsoft.EntityFrameworkCore;

namespace Wallet.NFT.DAL.Repository
{
    public class LancamentoRepository : ILancamentoRepository
    {
        private readonly ApplicationDbContext _db;
        private IMapper _mapper;
        public LancamentoRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        /*
        public async Task<LancamentoDto> CreateAsync(LancamentoDto entity)
        {
           Lancamento lancamento = _mapper.Map<LancamentoDto, Lancamento>(entity);
            _db.Lancamento.Add(lancamento);
            await _db.SaveChangesAsync();
            return _mapper.Map<Lancamento, LancamentoDto>(lancamento);
        }

        public async Task<IEnumerable<LancamentoDto>> GetAsync() =>
            _mapper.Map<IEnumerable<LancamentoDto>>(await _db.Lancamento);

        public async Task<LancamentoDto> GetByIdAsync(int id) =>
            _mapper.Map<LancamentoDto>(await _db.Lancamento.Include(x => x.LancamentoId == id));
*/
    }
}
