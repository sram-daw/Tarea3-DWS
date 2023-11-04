using Microsoft.EntityFrameworkCore;
using RamiloAlonsoSaraTarea3.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AsignaturasContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("ConexionTarea3")));

builder.Services.AddDbContext<EstudiantesContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("ConexionTarea3")));

builder.Services.AddDbContext<LoginsContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("ConexionTarea3")));

builder.Services.AddDbContext<MatriculasContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("ConexionTarea3")));

builder.Services.AddDbContext<ProfesoresContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("ConexionTarea3")));


builder.Services.AddControllersWithViews();

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

//Asignaturas
app.MapControllerRoute(
    name: "AsignaturaLista",
    pattern: "Asignatura/Lista",
    defaults: new { controller = "Asignaturas", action = "Index" }
    );

app.MapControllerRoute(
    name: "AsignaturaId",
    pattern: "Asignatura/Detalles/{id}",
    defaults: new { controller = "Asignaturas", action = "Detalles" }
    );

//Estudiantes
app.MapControllerRoute(
    name: "EstudiantesLista",
    pattern: "Estudiante/Lista",
    defaults: new { controller = "Estudiantes", action = "Index" }
    );

app.MapControllerRoute(
    name: "EstudianteId",
    pattern: "Estudiante/Detalles/{id}",
    defaults: new { controller = "Estudiantes", action = "Detalles" }
    );

//Profesores
app.MapControllerRoute(
    name: "ProfesoresLista",
    pattern: "Profesor/Lista",
    defaults: new { controller = "Profesores", action = "Index" }
    );

app.MapControllerRoute(
    name: "ProfesorId",
    pattern: "Profesor/Detalles/{id}",
    defaults: new { controller = "Profesores", action = "Detalles" }
    );



app.MapControllerRoute(
    name: "ProfesorId",
    pattern: "Profesor/Detalles/{id}",
    defaults: new { controller = "Profesores", action = "Detalles" }
    );


app.MapControllerRoute(
    name: "CvRoute",
    pattern: "Login/MiCurriculum",
    defaults: new { controller = "MiCurriculum", action = "MiCurriculum" }
    );

//Login
app.MapControllerRoute(
    name: "login",
    pattern: "Login/Logueate",
    defaults: new { controller = "Logins", action = "Index" }
    );

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Logins}/{action=Index}");

app.UseStaticFiles();

app.Run();
