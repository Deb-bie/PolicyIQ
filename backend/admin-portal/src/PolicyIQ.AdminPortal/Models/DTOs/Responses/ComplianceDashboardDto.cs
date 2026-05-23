namespace PolicyIQ.AdminPortal.Models;


public sealed record ComplianceDashboardDto(
    string Department, 
    int TotalRequirements, 
    int CompletedCount,
    int PendingCount, 
    int OverdueCount, 
    double CompliancePercentage,
    IReadOnlyList<PolicyComplianceItem> PoliciesDue
    );