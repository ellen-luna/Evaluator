using Evaluator;
using Evaluator.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
//using Utility;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
	builder.Configuration.GetConnectionString("DefaultConnection")
	));

builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddDefaultTokenProviders()
	.AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddScoped<DBInitializer>();
//builder.Services.AddSingleton<IEmailSender, EmailSender>();
//builder.Services.AddScoped<UnitOfWork>();
builder.Services.AddScoped<UnitOfWork>();


var app = builder.Build();

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

app.UseAuthorization();

app.MapRazorPages();
SeedDatabase();
app.Run();
void SeedDatabase()
{
	using var scope = app.Services.CreateScope();
	var dbInitializer = scope.ServiceProvider.GetRequiredService<DBInitializer>();
	dbInitializer.Initialize();
}
