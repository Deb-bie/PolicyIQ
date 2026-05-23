namespace PolicyIQ.AdminPortal.Models;

public sealed class DemoUser
{
    public string  Email        { get; init; } = string.Empty;

    public string  Password     { get; init; } = string.Empty;

    public string  Role         { get; init; } = string.Empty;

    public string  DisplayName  { get; init; } = string.Empty;

    public Guid?   EmployeeId   { get; init; }

    public string? EmployeeRole { get; init; }
}
