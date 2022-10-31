using Wallet.NFT.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Wallet.NFT.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Lancamento>? Lancamento { get; set; }
        public DbSet<Report>? Report { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
           /*
            modelBuilder.Entity<Lancamento>().HasData(new Lancamento
            {
                Id = 1,
                Name = "Туманность андромеды",
                Author= "Иван Ефремов",
                YearOfIssue = 1957,
                ISBN = "978-0-82851856-7",
                ImageUrl = "https://azbukivedia.ru/wa-data/public/shop/products/26/52/25226/images/63362/63362.750x0.jpg",
                Description = "Первая линия сюжета: рассказывает о 37-й звёздной экспедиции звездолёта «Тантра», несколько лет находившегося в межзвёздном пространстве, под началом командира корабля Эрга Ноора. Выполнив все задачи своей экспедиции к планете Зирда в созвездии Змееносца, которая погибла от радиационного излучения в результате «неосторожных опытов» местной цивилизации с ядерной энергией, звездолёт возвращается к Земле.\n Вторая линия сюжета: примерно, в это же время, на планете Земля, у Дара Ветра, заведующего Внешними Станциями, обнаруживается серьёзная психологическая болезнь — «приступы равнодушия к работе и жизни» (эмоциональное выгорание). Будучи не в состоянии справляться со своими обязанностями, он принимает приглашение своей подруги историка Веды Конг (возлюбленной Эрга Ноора), поучаствовать в археологических раскопках кургана скифов в приалтайских степях."
            });
            */
        }
    }
}
