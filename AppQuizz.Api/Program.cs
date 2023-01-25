using AppQuizz.Api.Configurations;
using AppQuizz.Api.Repositories;
using AppQuizz.Api.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<QuizzContextDB, QuizzContextDB>();

builder.Services.AddTransient<ICategorieRepositories, CategorieRepositories>();
builder.Services.AddTransient<IQuizzRepositories, QuizzRepositories>();
builder.Services.AddTransient<IQuestionRepositories, QuestionRepositories>();
builder.Services.AddTransient<IComponentTypeRepositories, ComponentTypeRepositories>();
builder.Services.AddTransient<IAnswerRepositories, AnswerRepositories>();

builder.Services.AddTransient<IQuestionService, QuestionService>();
builder.Services.AddTransient<IQuizzService, QuizzService>();
builder.Services.AddTransient<ICategorieService, CategorieService>();

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
