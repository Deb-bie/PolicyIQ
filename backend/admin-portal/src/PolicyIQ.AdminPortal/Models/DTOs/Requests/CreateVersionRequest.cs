namespace PolicyIQ.AdminPortal.Models;


public sealed record CreateVersionRequest(
    string Content, 
    string CreatedBy, 
    DateTime? EffectiveDate
);
