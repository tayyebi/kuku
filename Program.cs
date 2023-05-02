using Microsoft.EntityFrameworkCore;
using Api.Models;
using Api.Repositories;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

// Add custom configuration
builder.Configuration.AddJsonFile($"{Environment.CurrentDirectory}/appsecrets.json");

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Data Layer
builder.Services.AddDbContext<DatabaseContext>(opt => opt.UseInMemoryDatabase("Api"));
// Dependency Injection
builder.Services.AddScoped<UnitOfWork>();
builder.Services.AddScoped<IProjectRepository, ProjectRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseRouting();
app.UseHttpsRedirection();
app.UseAuthorization();

app.UseDefaultFiles(new DefaultFilesOptions { FileProvider = new PhysicalFileProvider(Path.Combine(builder.Environment.ContentRootPath, "wwwroot")), RequestPath = "" });
app.UseStaticFiles(new StaticFileOptions { FileProvider = new PhysicalFileProvider(Path.Combine(builder.Environment.ContentRootPath, "wwwroot")), RequestPath = "" });

app.MapControllers();
app.Run();
