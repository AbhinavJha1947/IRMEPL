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
using Infrastructure.Services;
using Application.Services.Core;
using Application.ServiceInterfaces.Core;
using Application.RepositoryInterfaces.Core;
using Infrastructure.Data.Repositories.Core;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IMenuService, MenuService>();
builder.Services.AddScoped<Application.Interfaces.User.IUSRUserMasterService, Application.Services.User.USRUserMasterService>();
builder.Services.AddScoped<Application.Interfaces.User.IUSRRoleMasterService, Application.Services.User.USRRoleMasterService>();
builder.Services.AddScoped<Application.Interfaces.User.ICORPrivilegeMasterService, Application.Services.User.CORPrivilegeMasterService>();


builder.Services.AddScoped<DbHelper>();
builder.Services.AddScoped<FileUploadService>();

builder.Services.AddControllersWithViews();
builder.Services.AddLogging(logging =>
{
    logging.AddConsole();
    logging.AddDebug();
});

// Register Infrastructure services
builder.Services.AddScoped<DbManager>();
builder.Services.AddScoped<GeneralHelper>();
builder.Services.AddScoped<ClsTransaction>();
builder.Services.AddScoped<ICORCompanyMasterService, CORCompanyMasterService>();
builder.Services.AddScoped<ICORCenterMasterService, CORCenterMasterService>();
builder.Services.AddScoped<IControlDetailMasterService, ControlDetailMasterService>();

builder.Services.AddScoped<ICORFunctionalityHDRMSTService, CORFunctionalityHDRMSTService>();
builder.Services.AddScoped<ICORPrivilegeMasterService, CORPrivilegeMasterService>();
builder.Services.AddScoped<ICORScreenMasterService, CORScreenMasterService>();
builder.Services.AddScoped<IMenuService, MenuService>();
builder.Services.AddScoped<IUSRRoleMasterService, USRRoleMasterService>();
builder.Services.AddScoped<IUSRUserRoleMasterService, USRUserRoleMasterService>();
builder.Services.AddScoped<IUSRUserMasterService, USRUserMasterService>();
builder.Services.AddScoped<IUSRRoleHDRMSTService, USRRoleHDRMSTService>();

// Register DAO classes
builder.Services.AddScoped<IUSRUserRoleMasterDao, USRUserRoleMasterDao>();
builder.Services.AddScoped<IUSRUserMasterDao, USRUserMasterDao>();
builder.Services.AddScoped<IUSRRoleMasterDao, USRRoleMasterDao>();
builder.Services.AddScoped<ICORPrivilegeMasterDao, CORPrivilegeMasterDao>();
builder.Services.AddScoped<IUSRRoleHDRMSTDao, USRRoleHDRMSTDao>();
builder.Services.AddScoped<ICORScreenMasterDao, CORScreenMasterDao>();
builder.Services.AddScoped<ICORFunctionalityHDRMSTDao, CORFunctionalityHDRMSTDao>();
builder.Services.AddScoped<IMenuDao, MenuDao>();

builder.Services.AddScoped<IControlDetailMasterDao, ControlDetailMasterDao>();
builder.Services.AddScoped<ICORCenterMasterDao, CORCenterMasterDao>();
builder.Services.AddScoped<ICORCompanyMasterDao, CORCompanyMasterDao>();


builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});
builder.Services.AddMemoryCache();
builder.Services.AddHttpContextAccessor();
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
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseStaticFiles();

app.UseSession();

app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Index}/{id?}");

app.Use(async (context, next) =>
{
    var logger = context.RequestServices.GetRequiredService<ILogger<Program>>();
    logger.LogInformation("Request: {Method} {Path}", context.Request.Method, context.Request.Path);
    await next();
});

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
