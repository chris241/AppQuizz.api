namespace AppQuizz.Api.Models
{
    public class Questions : Base
    {
        public string? ComponentId { get; set; }
        public string? QuizzId { get; set; }
        public string? Title { get; set; }
        public int? CountResponse { get; set; }

    }
}
