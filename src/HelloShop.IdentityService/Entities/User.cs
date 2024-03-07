﻿// Copyright (c) HelloShop Corporation. All rights reserved.
// See the license file in the project root for more information.

using Microsoft.AspNetCore.Identity;

namespace HelloShop.IdentityService.Entities
{
    public class User: IdentityUser<int>
    {
        public DateTimeOffset CreationTime { get; init; } = TimeProvider.System.GetUtcNow();
    }
}
