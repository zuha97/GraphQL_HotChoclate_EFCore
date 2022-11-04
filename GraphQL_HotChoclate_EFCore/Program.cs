using GraphQL_HotChoclate_EFCore.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGraphQLServer().AddQueryType<EmployeeService>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
