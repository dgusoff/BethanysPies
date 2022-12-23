using BethanysPiesWeb.Models;

var builder = WebApplication.CreateBuilder(args);

//register services
builder.Services.AddScoped<ICategoryRepository, MockCategoryRepository>();
builder.Services.AddScoped<IPieRepository, MockPieRepository>();

builder.Services.AddControllersWithViews();

var app = builder.Build();

// middleware pipeline

app.UseStaticFiles();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

// endpoint middleware
app.MapDefaultControllerRoute();

app.Run();
