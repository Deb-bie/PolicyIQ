namespace PolicyIQ.AdminPortal.Models;


public sealed record CreatePolicyRequest(
    string Title, 
    string Description, 
    string Department,
    IReadOnlyList<string> ApplicabilityScope, 
    string CreatedBy
);