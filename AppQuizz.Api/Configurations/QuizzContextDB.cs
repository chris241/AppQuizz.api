using AppQuizz.Api.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace AppQuizz.Api.Configurations
{
    public class QuizzContextDB
    {
        private readonly IMongoDatabase Db;
        public QuizzContextDB(IOptions<ConnectionString> options)
        {
            var client = new MongoClient(options.Value.Connection);
            Db = client.GetDatabase(options.Value.DataBase);
        }
        public IMongoCollection<Categories> CategorieContext => Db.GetCollection<Categories>("Categorie");
        public IMongoCollection<Quizz> QuizzContext => Db.GetCollection<Quizz>("Quizz");
        public IMongoCollection<Questions> QuestionContext => Db.GetCollection<Questions>("Question");
        public IMongoCollection<Answers> AnswerContext => Db.GetCollection<Answers>("Answer");
    }
}
