namespace AppQuizz.Api.Configurations
{
    public class ConnectionString
    {
        public string? Connection { get; set; } = "mongodb://localhost:27017";
        public string? DataBase { get; set; } = "QuizzDB";
    }
}
