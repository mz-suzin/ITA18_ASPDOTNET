using LaboratorioRestApi.Database;
using LaboratorioRestApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
using (var db = new DatabaseContext())
{
    db.Database.EnsureCreated();
    db.SaveChanges();
}

builder.Services.AddScoped<IAutorRepositorio, AutorRepositorio>();
// builder.Services.AddSingleton<ILivroRepositorio, LivroRepositorio>();
// builder.Services.AddSingleton<IEmprestimoRepositorio, EmprestimoRepositorio>();

builder.Services.AddControllers();
builder.Services.AddDbContext<DatabaseContext>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
