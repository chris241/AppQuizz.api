namespace AppQuizz.Api.Models
{
    public class Quizz : Base
    {
        public string? CategorieId { get; set; }
        public string? Title { get; set; }
        public string? Descriptions { get; set; }
        public int? Score { get; set; }

        public DateTime? CreatedDate { get; set; }
        public int?  QuestionCount { get; set; }    
       // public Time Times {get; set;}

    }
}
