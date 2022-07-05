using HttpStatusCode.Infrastructure.Contex;
using HttpStatusCode.Infrastructure.Repository.Abstract;
using HttpStatusCode.Infrastructure.Repository.Concrete;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<SqlDbcontext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("WebApiDb"));
});
builder.Services.AddScoped<ICategoryDAL, CategoryDAL>();
builder.Services.AddScoped<ISehirDAL, SehirDAL>();
builder.Services.AddScoped<IilceDAL, IlceDAL>();

//Cors Ayarlarinin eklenmesi
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(p => p.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
//Corsu MiddleWare icerisine ekliyoruz.
app.UseCors();
app.UseAuthorization();

app.MapControllers();

app.Run();