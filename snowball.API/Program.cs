
using snowball.API.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.RegisterBuilderServices(typeof(Program));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.RegisterPipelineComponents(typeof(Program));
app.Run();
