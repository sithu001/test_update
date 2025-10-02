using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using MOCDEMSNEW.Data;
using MOCDEMSNEW.Middleware;
using MOCDEMSNEW.Repository;
using MOCDEMSNEW.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DemsContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.
builder.Services.AddControllersWithViews();

// Authentication
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/Account/Login";        // redirect if unauthenticated
        options.AccessDeniedPath = "/Account/AccessDenied";
        options.ExpireTimeSpan = TimeSpan.FromHours(1);
        options.SlidingExpiration = true;          // refresh cookie on activity

        // Force session cookies (deleted on browser close)
        options.Cookie.IsEssential = true;
        options.Cookie.HttpOnly = true;
        options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
        options.Cookie.SameSite = SameSiteMode.Lax;

    });

// Register repository 
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IAccountService, AccountService>();
builder.Services.AddScoped<ITwoFactorService, TwoFactorService>();
builder.Services.AddScoped<IEmployeeTwoFactorRepository, EmployeeTwoFactorRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseMiddleware<SubdomainAuthMiddleware>();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "admin",
    pattern: "{controller=Admin}/{action=Index}/{id?}",
    constraints: new { host = "admin.localhost" }
);

app.Run();
