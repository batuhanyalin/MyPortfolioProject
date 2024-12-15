using FluentValidation.AspNetCore;
using FluentValidation;
using System.Reflection;
using MyPortfolioProject.EntityLayer.Concrete;
using MyPortfolioProject.DataAccessLayer.Context;
using MyPortfolioProject.BusinessLayer.Abstract;
using MyPortfolioProject.BusinessLayer.Concrete;
using MyPortfolioProject.DataAccessLayer.Abstract;
using MyPortfolioProject.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using MyPortfolioProject.DtoLayer.ContactDtos;
using MyPortfolioProject.BusinessLayer.ValidationRules;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);



//***FLUENT VALIDATON**
builder.Services.AddFluentValidationAutoValidation().AddFluentValidationClientsideAdapters().AddValidatorsFromAssemblyContaining<Program>();
//**FLUENT VALIDATON**

builder.Services.AddControllersWithViews();



builder.Services.AddDbContext<MyPortfolioContext>();

builder.Services.AddIdentity<AppUser, AppRole>().AddTokenProvider<DataProtectorTokenProvider<AppUser>>(TokenOptions.DefaultProvider).AddEntityFrameworkStores<MyPortfolioContext>().AddErrorDescriber<CustomIdentityValidator>().AddEntityFrameworkStores<MyPortfolioContext>(); //Þifremi unuttum mu kýsmý için Token iþlemi


builder.Services.AddScoped<IAboutService, AboutManager>();
builder.Services.AddScoped<IAboutDAL, EFAboutDAL>();
builder.Services.AddScoped<IContactService, ContactManager>();
builder.Services.AddScoped<IContactDAL, EFContactDAL>();
builder.Services.AddScoped<IContactInfoService, ContactInfoManager>();
builder.Services.AddScoped<IContactInfoDAL, EFContactInfoDAL>();
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

builder.Services.AddAutoMapper(typeof(Program)); //Automapper
// Add services to the container.


//Proje seviyesinde Authorization uyguluyoruz.
builder.Services.AddMvc(config =>
{
    var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
    config.Filters.Add(new AuthorizeFilter(policy));
});
builder.Services.ConfigureApplicationCookie(options =>
{
    options.ExpireTimeSpan = TimeSpan.FromMinutes(10);
    options.AccessDeniedPath = "/Default/error403";
    options.LoginPath = new PathString("/Login/Index");
    options.LogoutPath = new PathString("/Login/LogOut");
});

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

app.UseAuthorization();
app.UseAuthentication();

app.UseStatusCodePagesWithReExecute("/Default/error{0}");



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Default}/{action=Index}/{id?}");

app.Run();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});
