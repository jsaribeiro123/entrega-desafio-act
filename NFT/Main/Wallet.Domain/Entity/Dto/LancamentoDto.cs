using System.ComponentModel.DataAnnotations;

namespace Wallet.NFT.Domain.Entity.Dto
{
    public class LancamentoDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Укажите название книги")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Укажите имя автора")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Длина строки должна быть от 2 до 50 символов")]
        public string? Author { get; set; }
        [Required(ErrorMessage = "Укажите название жанра(ов).")]
        public int YearOfIssue { get; set; }
        [Required(ErrorMessage = "Укажите ISBN книги")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "ISBN должен состоять из чисел")]
        [StringLength(13, MinimumLength = 10, ErrorMessage = "номер ISBN должен состоять из 10 или 13 чисел")]
        public string? ISBN { get; set; }
        public string? ImageUrl { get; set; }
        public string? Description { get; set; }
    }
}
