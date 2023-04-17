using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheGreatestApiInTheWorldTribute.Entities.Models;

namespace TheGreatestApiInTheWorldTribute.Repository.Configuration
{
    public class BandConfiguration : IEntityTypeConfiguration<Band>
    {
        public void Configure(EntityTypeBuilder<Band> builder)
        {
            builder.HasData(
                new Band 
                { 
                    Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), 
                    Name = "Tenacious D", 
                    Hometown = "Los Angeles, CA"
                }, 
                new Band 
                { 
                    Id = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), 
                    Name = "Red Hot Chili Peppers", 
                    Hometown = "Los Angeles, CA"
                }
            );
        }
    }
}
