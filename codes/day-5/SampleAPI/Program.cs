using SampleAPI.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


//before build configure all service dependencies
builder.Services.AddDbContext<EmployeeDbContext>((builder) =>
{
    builder.UseSqlServer(@"Data Source=joydip-pc\sqlexpress;Initial Catalog=employeedb;User ID=sa;Password=SqlServer@2022;Encrypt=False");
});
builder.Services.AddControllers();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
