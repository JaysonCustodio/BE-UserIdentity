public static class DbInitializer
{
    public static void Initialize(AppDbContext context)
    {
        if (context.UserIdentities.Any()) return;

        context.UserIdentities.Add(new UserIdentity
        {
            Id = 1,
            UserId = "user-test-id-123",
            FullName = "Jayson Custodio",
            Email = "custodiojay123@gmail.com",
            SourceSystem = "Basic User Portal",
            LastUpdated = DateTime.UtcNow,
            IsActive = true
        });

        context.SaveChanges();
    }
}
