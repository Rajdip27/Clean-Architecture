
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Numerics;
using TaskManagement.Models;
using TaskManagement.Shared;

namespace TaskManagement.DataAccess.Configuration;

internal class UsersConfiguration : IEntityTypeConfiguration<Users>
{
    public void Configure(EntityTypeBuilder<Users> builder)
    {
       builder.ToTable("User");
        builder.HasKey(x => x.Id);
        builder.HasIndex(x => new {x.FirstName, x.LastName});
        builder.HasIndex(x=>x.UserName).IsUnique();
        builder.HasData(new
        {
            Id = 1,
            FirstName = "Rajdip",
            LastName = "Raj",
            Email = "Srajdip920@gmail.com",
            Phone = "123315",
            Password = "456789",
            UserName = "SantanuRaj",
            CreateDate = DateTimeOffset.Now,
            CreateBy = "1",
            Status = EntityStatus.Created
        }) ;

    }
}
