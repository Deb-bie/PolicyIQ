namespace PolicyIQ.AdminPortal.Models;

public sealed record AdminCreatePolicyRequest(
    string Title,
    string? Description,
    string Department,
    IReadOnlyList<string> ApplicabilityScope,
    string CreatedBy);

