var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedisContainer("cache");

builder.AddProject<Projects.DVC_CleanArchitecture_Web>("web")
    .WithReference(cache);

builder.Build().Run();
