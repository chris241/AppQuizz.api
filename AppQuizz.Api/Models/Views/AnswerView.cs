namespace AppQuizz.Api.Models.Views
{
    public class AnswerView
    {
        public string? Value { get; set; }
        public bool? IsExact { get; set; }
        public string? QuestionId { get; set; }  
    }
}
