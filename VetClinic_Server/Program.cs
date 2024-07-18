using Microsoft.EntityFrameworkCore;
using VetClinic_Server.Data;
using VetClinic_Server.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Components.Authorization;
using BlazorIdentityDemo.Areas.Identity;
using VetClinic_Server.Data.DbInitializer;
using VetClinic_Server.Services;
using Radzen;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<AppUser>>();
builder.Services.AddDbContextFactory<VetClinicDbContext>(
    opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("VetClinicDb")));
//builder.Services.AddDefaultIdentity<AppUser>(options => options.SignIn.RequireConfirmedAccount = true)
//    .AddRoles<IdentityRole>()
//    .AddEntityFrameworkStores<VetClinicDbContext>();
builder.Services.AddIdentity<AppUser, IdentityRole>()
                .AddEntityFrameworkStores<VetClinicDbContext>().AddDefaultTokenProviders()
                .AddDefaultUI();

builder.Services.AddRadzenComponents();
builder.Services.AddScoped<StateContainer>();
builder.Services.AddScoped<DialogService>();

var app = builder.Build();

// Don't do this in production, just useful for development
await EnsureDatabaseIsMigrated(app.Services);

async Task EnsureDatabaseIsMigrated(IServiceProvider services)
{
    using var scope = services.CreateScope();
    using var context = scope.ServiceProvider.GetService<VetClinicDbContext>();
    if (context != null)
    {
        await context.Database.MigrateAsync();
    }
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

var scope = app.Services.CreateScope();
var context = scope.ServiceProvider.GetRequiredService<VetClinicDbContext>();
var userManager = scope.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();
try
{
    context.Database.Migrate();
    await DbInitializer.Initialize(context, userManager, roleManager);
} catch (Exception ex)
{
    logger.LogError(ex, "A problem occurred during migration");
}

app.Run();
