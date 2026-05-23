namespace PolicyIQ.AdminPortal.Models;


public sealed record AuditTrailPage(
    IReadOnlyList<AuditEntryDto> Items, 
    int TotalCount, 
    int Page, 
    int PageSize
);