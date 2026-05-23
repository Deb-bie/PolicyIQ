namespace PolicyIQ.AdminPortal.Models;


public sealed record PolicyDto(
    Guid Id, 
    string Title, 
    string Description, 
    string Department,
    IReadOnlyList<string> ApplicabilityScope, 
    string CreatedBy, 
    DateTime CreatedAt
);