namespace PolicyIQ.AdminPortal.Models;

public sealed record PolicyComplianceItem(
    Guid PolicyVersionId, 
    string PolicyTitle, 
    int VersionNumber,
    DateTime DueDate, 
    int RemainingCount
);
