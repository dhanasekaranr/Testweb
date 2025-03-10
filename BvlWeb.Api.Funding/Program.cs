
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using BvlWeb.Modules.Funding.Services;
using BvlWeb.Api.Funding.Controllers;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using BvlWeb.Modules.Funding.Repositories;
using BvlWeb.Services.Common.Middleware;
using BvlWeb.Modules.Funding.Interfaces;
using BvlWeb.Services.Data.DbContexts;


var builder = WebApplication.CreateBuilder(args);

// Add IHttpContextAccessor to allow factory to access HttpContext
builder.Services.AddHttpContextAccessor();

// Configure the two Oracle DbContexts with connection strings from appsettings.json
builder.Services.AddDbContext<FirstOracleDbContext>(options =>
    options.UseOracle(builder.Configuration.GetConnectionString("FirstOracleConnection")));
builder.Services.AddDbContext<SecondOracleDbContext>(options =>
    options.UseOracle(builder.Configuration.GetConnectionString("SecondOracleConnection")));



// Register the DbContext factory
builder.Services.AddScoped<IDbContextFactory, OracleDbContextFactory>();

// Register module-specific services and repositories
builder.Services.AddScoped<FundingRepository>();
builder.Services.AddScoped<IFundingService, FundingService>();

// Configure authentication using JWT Bearer
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.Authority = builder.Configuration["Auth:Authority"];
        options.Audience = builder.Configuration["Auth:Audience"];
        options.RequireHttpsMetadata = true;
    });


// Add controllers and register module controllers via Application Parts
builder.Services.AddControllers().AddApplicationPart(typeof(FundingController).Assembly);

// Register controllers, Swagger, etc.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
// Register our custom middleware to intercept and select the DbContext
app.UseMiddleware<DbContextSelectionMiddleware>();
app.Run();