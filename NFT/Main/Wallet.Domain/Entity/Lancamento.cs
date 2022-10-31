using System.ComponentModel.DataAnnotations;
using Wallet.NFT.Domain;

namespace Wallet.NFT.Domain.Entity
{
    public class Lancamento
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
