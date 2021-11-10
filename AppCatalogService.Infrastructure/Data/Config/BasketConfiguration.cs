using AppCatalogService.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppCatalogService.Infrastructure.Data.Config
{
    public class ExampleEntityConfiguration : IEntityTypeConfiguration<ExampleEntity>
    {
        public void Configure(EntityTypeBuilder<ExampleEntity> builder)
        {
            //ToDo
            //Example Configuration below
            //var navigation = builder.Metadata.FindNavigation(nameof(Basket.Items));
            //navigation.SetPropertyAccessMode(PropertyAccessMode.Field);

            //builder.Property(b => b.BuyerId)
            //    .IsRequired()
            //    .HasMaxLength(256);
        }
    }
}