using App.Domain.AppServices.BaseService;
using App.Domain.Core.BaseService.Contracts.IAppServices;
using App.Domain.Core.BaseService.Contracts.IRepositories;
using App.Domain.Core.BaseService.Contracts.IServices;
using App.Domain.Services.BaseService;
using App.Infrastructures.Database.SqlServer.Data;
using App.Infrastructures.Repositories.EfCore.BaseService;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServerConnection"));
});
#region BaseService
//MainCategory Services
builder.Services.AddScoped<IMainCategoryAppService, MainCategoryAppService>();
builder.Services.AddScoped<IMainCategoryService, MainCategoryService>();
builder.Services.AddScoped<IMainCategoryCommandRepository, MainCategoryCommandRepository>();
builder.Services.AddScoped<IMainCategoryQueryRepository, MainCategoryQueryRepository>();
//SecondaryCategory Services
builder.Services.AddScoped<ISecondaryCategoryAppService, SecondaryCategoryAppService>();
builder.Services.AddScoped<ISecondaryCategoryService, SecondaryCategoryService>();
builder.Services.AddScoped<ISecondaryCategoryCommandRepository, SecondaryCategoryCommandRepository>();
builder.Services.AddScoped<ISecondaryCategoryQueryRepository, SecondaryCategoryQueryRepository>();
//ThirdCategory Services
builder.Services.AddScoped<IThirdCategoryAppService, ThirdCategoryAppService>();
builder.Services.AddScoped<IThirdCategoryService, ThirdCategoryService>();
builder.Services.AddScoped<IThirdCategoryCommandRepository, ThirdCategoryCommandRepository>();
builder.Services.AddScoped<IThirdCategoryQueryRepository, ThirdCategoryQueryRepository>();

#endregion
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

app.MapControllerRoute(
    name: "default",
    pattern: "{area=Customer}/{controller=Home}/{action=Index}/{id?}");

app.Run();
