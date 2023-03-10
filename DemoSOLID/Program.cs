using DemoSOLID.Services;
using DemoSOLID.DataService;
using Microsoft.AspNetCore.OData;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddOData(options =>
options.Count().Filter().OrderBy().Expand().Select().SetMaxTop(null));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IOrganisationService, OrganisationService>();
builder.Services.AddScoped<IOrganisationDataService, OrganisationDataService>();
builder.Services.AddScoped<IFundsDataService, FundsDataService>();
builder.Services.AddScoped<IFundsService, FundsService>();
builder.Services.AddScoped<IAssetsDataService, AssetsDataService>();
builder.Services.AddScoped<IAssetsService, AssetsService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
