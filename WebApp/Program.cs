using Application.Interfaces;
using Application.Services;
using Infrastructure.Data;
using Infrastructure.Data.Repositories;
using Infrastructure.Helpers;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Data.Interfaces.User;
using Infrastructure.Data.Repositories.User;
using Application.Interfaces.User;
using Application.Services.User;
using Infrastructure.Data.Interfaces.User;
using Infrastructure.Data.Repositories.User;


var builder = WebApplication.CreateBuilder(args);

// Register Repositories
builder.Services.AddScoped<IMenuDao, MenuDao>();

// Register Services
builder.Services.AddScoped<IMenuService, MenuService>();

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add logging
builder.Services.AddLogging(logging =>
{
    logging.AddConsole();
    logging.AddDebug();
});

// Register Infrastructure services
builder.Services.AddScoped<DbManager>();
builder.Services.AddScoped<ClsGeneral>();
builder.Services.AddScoped<ClsTransaction>();


// Add session support
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

// Add memory cache
builder.Services.AddMemoryCache();

// Add HTTP context accessor
builder.Services.AddHttpContextAccessor();

// Configure CORS if needed
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseSession();

app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Add custom middleware for logging requests
app.Use(async (context, next) =>
{
    var logger = context.RequestServices.GetRequiredService<ILogger<Program>>();
    logger.LogInformation("Request: {Method} {Path}", context.Request.Method, context.Request.Path);
    await next();
});

// Add custom middleware for handling exceptions
app.Use(async (context, next) =>
{
    try
    {
        await next();
    }
    catch (Exception ex)
    {
        var logger = context.RequestServices.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "Unhandled exception occurred");
        
        if (!context.Response.HasStarted)
        {
            context.Response.StatusCode = 500;
            await context.Response.WriteAsync("An error occurred while processing your request.");
        }
    }
});

app.Run();
