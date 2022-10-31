using System.ComponentModel.DataAnnotations;

namespace Wallet.NFT.Domain.Entity
{
    public class Report
    {
        [Key]
        public int Id { get; set; }
        public int BookId { get; set; }
        public string? GenreName { get; set; }
    }
}
