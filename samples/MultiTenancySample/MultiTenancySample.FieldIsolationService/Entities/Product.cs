﻿// Copyright (c) HelloShop Corporation. All rights reserved.
// See the license file in the project root for more information.

using System.Text.Json.Serialization;

namespace MultiTenancySample.FieldIsolationService.Entities
{
    public class Product : IMultiTenant
    {
        public Guid Id { get; set; }

        public required string Name { get; set; }

        [JsonIgnore]
        public string? TenantId { get; set; }
    }
}