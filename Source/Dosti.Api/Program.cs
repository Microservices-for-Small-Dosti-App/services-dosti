using Dosti.Api.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDependentServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
_ = app.ConfigureHttpRequestPipeline();

app.Run();
