namespace PolicyIQ.AdminPortal.Models;

public sealed record LoginResponse(
    string  Token,
    string  Email,
    string  DisplayName,
    string  Role,
    DateTime ExpiresAt,
    Guid?   EmployeeId   = null,
    string? EmployeeRole = null
);



