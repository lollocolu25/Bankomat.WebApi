using Bankomat.WebApi.DbContent;
using Bankomat.WebApi.Repositories;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddControllers();

builder.Services.AddControllers(opts =>
{
    opts.ReturnHttpNotAcceptable = true;
});
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<InfoContext>
    (options =>
    {
        options.UseSqlServer(connectionString);
    });


//builder.Services.AddDbContext<PiadineInfoContext>(cfg =>
//{

//    var connectionString = "server=localhost;user=root;password=test123;database=some-piadinaDb2";


//    ServerVersion sv = ServerVersion.AutoDetect(connectionString);
//    var serverVersion = new MySqlServerVersion(sv.Version);

//    cfg.UseMySql(connectionString, serverVersion)
//        .LogTo(Console.WriteLine, LogLevel.Information)
//        .EnableSensitiveDataLogging()
//        .EnableDetailedErrors();
//});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<FileExtensionContentTypeProvider>();

builder.Services.AddSingleton<IBancheFunzionalitàRepository, BancheFunzionalitàRepository>();
builder.Services.AddSingleton<IFunzionalitàRepository, FunzionalitàRepository>();
builder.Services.AddSingleton<IUtentiRepository, UtentiRepository>();



//builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


//builder.Services.AddAuthentication("Bearer")
//    .AddJwtBearer(Options =>
//    {
//        Options.TokenValidationParameters = new()
//        {
//            ValidateIssuer = true,
//            ValidateAudience = true,
//            ValidateIssuerSigningKey = true,
//            ValidIssuer = builder.Configuration["Authentication:Issuer"],
//            ValidAudience = builder.Configuration["Authentication: Audience"],
//            IssuerSigningKey = new SymmetricSecurityKey(
//            Encoding.ASCII.GetBytes(builder.Configuration["Authentication : SecretForKey"]))
//        };
//    });

#if DEBUG
//builder.Services.AddTransient<IMailService, LocalMailService>();
#else
builder.Services.AddTransient<IMailService, CloudMailService>();
#endif

var app = builder.Build();
//configure the http request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});



app.Run();

//static void NewMethod(WebApplicationBuilder builder)
//{
//    builder.Services.AddScoped<IPiadineRepository, PiadineRepository>();
//    builder.Services.AddScoped<IBibiteRepository, BibiteRepository>();
//    builder.Services.AddScoped<ISnackRepository, SnackRepository>();
//}
