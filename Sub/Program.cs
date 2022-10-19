var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .PublishSchemaDefinition(c => c
        .SetName("publish")
        .IgnoreRootTypes()
        .AddTypeExtensionsFromFile("./Stitching.graphql"));

var app = builder.Build();

app.MapGraphQL();

app.Run();
