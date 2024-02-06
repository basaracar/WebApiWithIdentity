namespace WebApiSolution.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string? QuestionItem { get; set; }
        public string Wrong1 { get; set; }
        public string Wrong2 { get; set; }
        public string Wrong3 { get; set; }
        public string Answer { get; set; }
        public int level { get; set; }
    }
}
