namespace AppQuizz.Api.Models.Views
{
    public class QuestionViewList
    {
        public string? Title { get; set; }
        public string? ComponentName { get; set; }
        public int? CountResponse { get; set; }
        List<AnswerViewList>? AnswerViewLists { get; set; }
    }
}
