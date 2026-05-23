namespace PolicyIQ.AdminPortal.Models;

public sealed record AdminPublishRequest(
    Guid VersionId,
    string PublishedBy
);