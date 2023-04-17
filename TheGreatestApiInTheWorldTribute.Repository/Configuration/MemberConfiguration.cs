﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheGreatestApiInTheWorldTribute.Entities.Models;

namespace TheGreatestApiInTheWorldTribute.Repository.Configuration
{
    public class MemberConfiguration : IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.HasData(
                new Member
                { 
                    Id = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), 
                    Name = "Jack Black", 
                    Age = 53,
                    Role = "Lead",
                    BandId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870") 
                }, 
                new Member
                { 
                    Id = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"), 
                    Name = "Anthony Kiedis", 
                    Age = 60,
                    Role = "Lead Vocalist",
                    BandId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3") 
                }, 
                new Member
                { 
                    Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), 
                    Name = "Chad Smith", 
                    Age = 61,
                    Role = "Drummer",
                    BandId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3") 
                }
            );
        }
    }
}
