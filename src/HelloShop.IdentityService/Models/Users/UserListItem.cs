﻿namespace HelloShop.IdentityService;

public class UserListItem
{
    public int Id { get; init; }

    public required string UserName { get; init; }

    public string? PhoneNumber { get; set; }

    public bool PhoneNumberConfirmed { get; set; }

    public string? Email { get; set; }

    public bool EmailConfirmed { get; set; }

    public DateTimeOffset CreationTime { get; init; }
}
