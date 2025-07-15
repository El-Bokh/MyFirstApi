using Microsoft.EntityFrameworkCore;
using MyFirstApi.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

// ✅ تعديل الاتصال هنا إلى MySQL الحقيقي
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(
        "Server=193.203.168.53;Port=3306;Database=u915267143_qaid;Uid=u915267143_qaid;Pwd=Un@01024600209;",
        new MySqlServerVersion(new Version(8, 0, 36))
    )
);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseCors("AllowAll");

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    try
    {
        if (db.Database.CanConnect())
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("✅ Sucss! Connected to Online DB");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("⚠️ لم يتم الاتصال بقاعدة البيانات، تأكد من البيانات.");
        }
    }
    catch (Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("❌ Faild to Connect:");
        Console.WriteLine(ex.Message);
    }
    finally
    {
        Console.ResetColor();
    }
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
