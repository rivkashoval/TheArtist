using ArtBL;
using ArtDL;
using ArtDL.Modelsa;
using ArtDTO;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(AutoMapping));
builder.Services.AddScoped<IUsersBL, UsersBL>();
builder.Services.AddScoped<IUsersDL, UsersDL>();
builder.Services.AddScoped<ILevelsBL, LevelsBL>();
builder.Services.AddScoped<ILevelsDL, LevelsDL>();
builder.Services.AddScoped<IGaleryMasterDL, GaleryMasterDL>();
builder.Services.AddScoped<IGaleryMasterBL, GaleryMasterBL>();
builder.Services.AddScoped<IGaleryJuniorDL, GaleryJuniorDL>();
builder.Services.AddScoped<IGaleryJuniorBL, GaleryJuniorBL>();
builder.Services.AddScoped<IContactsDL, ContactsDL>();
builder.Services.AddScoped<IContactsBL, ContactsBL>();
builder.Services.AddScoped<ICommentsGaleryJuniorDL, CommentsGaleryJuniorDL>();
builder.Services.AddScoped<ICommentsGaleryJuniorBL, CommentsGaleryJuniorBL>();
builder.Services.AddScoped<ArtProjectContext>();

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
