using FluentValidation.AspNetCore;
using FluentValidation;
using System.Reflection;
using MyPortfolioProject.EntityLayer.Concrete;
using MyPortfolioProject.DataAccessLayer.Context;
using MyPortfolioProject.BusinessLayer.Abstract;
using MyPortfolioProject.BusinessLayer.Concrete;
using MyPortfolioProject.DataAccessLayer.Abstract;
using MyPortfolioProject.DataAccessLayer.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

//** FLUENT VALIDATON **
//Burada validation .net 6.0 a uygun bir yöntemle dahil ediliyor.
builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddFluentValidationClientsideAdapters();
builder.Services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
//*** FLUENT VALIDATON **

builder.Services.AddIdentity<AppUser,AppRole>().AddEntityFrameworkStores<MyPortfolioContext>();
builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Login/Index";
    options.ExpireTimeSpan = TimeSpan.FromMinutes(5);
    options.LogoutPath = "/Login/LogOut";
});

builder.Services.AddScoped<IAboutService, AboutManager>();
builder.Services.AddScoped<IAboutDAL, EFAboutDAL>();
builder.Services.AddScoped<IContactService, ContactManager>();
builder.Services.AddScoped<IContactDAL, EFContactDAL>();
builder.Services.AddScoped<IContactInfoService, ContactInfoManager>();
builder.Services.AddScoped<IContactInfoDAL, EFContactInfoDAL>();
builder.Services.AddScoped<ICVService, CVManager>();
builder.Services.AddScoped<ICVDAL, EFCVDAL>();
builder.Services.AddScoped<IProjectService, ProjectManager>();
builder.Services.AddScoped<IProjectDAL, EFProjectDAL>();
builder.Services.AddScoped<IResumeService, ResumeManager>();
builder.Services.AddScoped<IResumeDAL, EFResumeDAL>();
builder.Services.AddScoped<IServiceService, ServiceManager>();
builder.Services.AddScoped<IServiceDAL, EFServiceDAL>();
builder.Services.AddScoped<ISkillService, SkillManager>();
builder.Services.AddScoped<ISkillDAL, EFSkillDAL>();
builder.Services.AddScoped<ISocialMediaService, SocialMediaManager>();
builder.Services.AddScoped<ISocialMediaDAL, EFSocialMediaDAL>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/Default/error404", "?code={0}");
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseAuthentication();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});
