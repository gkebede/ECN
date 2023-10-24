

using Microsoft.EntityFrameworkCore;
using Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>( opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("MemebersDbConnection")));
builder.Services.AddCors( opt => { 
    opt.AddPolicy("CorsPolicy", policy => 
    {
      policy.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:3000");
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.UseHttpsRedirection();

app.UseCors("CorsPolicy");

app.UseAuthorization();

app.MapControllers();

using var scope = app.Services.CreateScope();

var services = scope.ServiceProvider;

try
{
    var context = services.GetRequiredService<DataContext>();
    await context.Database.MigrateAsync();
     await  Seed.SeedData(context);
                 
                 
}
catch (Exception ex)
{
    
    var logger = services.GetRequiredService<ILogger<Program>>();

    logger.LogError( ex, "An error occured during migration");
}

app.Run();


// NOT TO REFERENCE
// dotnet watch --no-hot-reload   -- to reload 
// github1s.com/


//====================
// …or create a new repository on the command line

// echo "# ECN" >> README.md
// git init
// git add README.md
// git commit -m "first commit"
// git branch -M main
// git remote add origin https://github.com/gkebede/ECN.git
// git push -u origin main

//====================

// …or push an existing repository from the command line

// git remote add origin https://github.com/gkebede/ECN.git
// git branch -M main
// git push -u origin main

//   cd client-app
//   npm install
//   npm run dev


// FOR LOWER VERSION 
// EntityFramwork 
 // 1- search for --- 