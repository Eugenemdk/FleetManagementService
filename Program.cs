using FleetManagement.Services;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGrpcService<ManagementService>();


app.Run();
