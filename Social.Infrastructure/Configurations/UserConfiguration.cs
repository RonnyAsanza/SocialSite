﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Social.Domain.Entities.Auth;

namespace Social.Infrastructure.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("ss_user");
            builder.HasMany(c => c.Roles)
                .WithOne(e => e.User);
            builder.Property(t => t.Username)
                .HasMaxLength(20);
            builder.Property(t => t.Email)
                  .HasMaxLength(50);
            builder.Property(t => t.PhoneNumber)
                .HasMaxLength(20);
        }
    }
}
