using Company_System.Data;
using Company_System.Models;
using Company_System.Repositories.Implementations;
using Company_System.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<CompanyDbContext>(options =>
    options.UseSqlServer("Server=.\\SQLEXPRESS;Database=CompanyDB;Trusted_Connection=True;TrustServerCertificate=True;"));

builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
{
    options.Password.RequireDigit = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 6;
})
    .AddEntityFrameworkStores<CompanyDbContext>()
    .AddDefaultTokenProviders();

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Account/Login";
    options.LogoutPath = "/Account/Logout";
    options.AccessDeniedPath = "/Account/AccessDenied";
});

builder.Services.AddScoped<ICourseRepository, CourseRepository>();
builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddScoped<IStudentCourseRepository, StudentCourseRepository>();

builder.Services.AddScoped<CourseBL>();
builder.Services.AddScoped<StudentBL>();
builder.Services.AddScoped<DepartmentBL>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "departmentDetails",
    pattern: "Department/Details/{id:int}",
    defaults: new { controller = "Department", action = "GetById" });

app.MapControllerRoute(
    name: "courseDegrees",
    pattern: "Course/{courseId:int}/Student/{studentId:int}/Degree",
    defaults: new { controller = "Course", action = "ShowDegree" });

app.MapControllerRoute(
    name: "studentActions",
    pattern: "Students/{action=ShowAll}/{id?}",
    defaults: new { controller = "Student" });

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");



app.Run();
