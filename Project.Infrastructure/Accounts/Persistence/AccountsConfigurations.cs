using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Domain.Accounts;

namespace Project.Infrastructure.Accounts.Persistence;

public class AccountsConfigurations : IEntityTypeConfiguration<Account>
{
    public void Configure(EntityTypeBuilder<Account> builder)
    {
        builder.HasKey(a => a.Id);
        builder.Property(a => a.Id).ValueGeneratedOnAdd();
        builder.Property("Name").HasColumnName("Name"); // this is the way if property is private
        builder.Property(a => a.Type).HasColumnName("Type")
            .HasConversion(
                accountType => accountType.Value,
                value => AccountType.FromValue(value));
    }
}