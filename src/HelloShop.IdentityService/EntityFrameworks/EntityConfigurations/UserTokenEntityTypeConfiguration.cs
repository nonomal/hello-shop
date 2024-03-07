﻿// Copyright (c) HelloShop Corporation. All rights reserved.
// See the license file in the project root for more information.

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace HelloShop.IdentityService.EntityFrameworks.EntityConfigurations
{
    public class UserTokenEntityTypeConfiguration : IEntityTypeConfiguration<IdentityUserToken<int>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserToken<int>> builder)
        {
            builder.ToTable("UserTokens");

            builder.Property(ut => ut.Name).HasMaxLength(16);
            builder.Property(ut => ut.LoginProvider).HasMaxLength(16);
        }
    }
}
