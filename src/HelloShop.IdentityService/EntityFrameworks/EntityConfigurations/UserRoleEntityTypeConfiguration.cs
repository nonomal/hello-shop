﻿// Copyright (c) HelloShop Corporation. All rights reserved.
// See the license file in the project root for more information.

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HelloShop.IdentityService.EntityFrameworks.EntityConfigurations
{
    public class UserRoleEntityTypeConfiguration : IEntityTypeConfiguration<IdentityUserRole<int>>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<IdentityUserRole<int>> builder)
        {
            builder.ToTable("UserRoles");
        }
    }
}
