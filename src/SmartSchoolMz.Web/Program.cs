using SmartSchoolMz.Infrastructure;
using SmartSchoolMz.Infrastructure.Persistence;
using SmartSchoolMz.Application;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add session support
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromHours(2);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

// Add services to the container.
builder.Services.AddRazorPages(options =>
{
    // Disable Antiforgery for development (temporary fix for Data Protection issues)
    options.Conventions.ConfigureFilter(new IgnoreAntiforgeryTokenAttribute());
});
builder.Services.AddInfrastructureWeb(builder.Configuration);
builder.Services.AddApplication();

var app = builder.Build();

// Use session
app.UseSession();

// Seed data (commented out temporarily to avoid Data Protection issues during startup
// using (var scope = app.Services.CreateScope())
// {
//     await DbInitializer.Initialize(scope.ServiceProvider);
// }

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();
