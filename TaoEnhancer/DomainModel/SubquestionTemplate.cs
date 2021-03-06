using System.ComponentModel.DataAnnotations;

namespace DomainModel
{
    public class SubquestionTemplate
    {
        [Key]
        public string SubquestionIdentifier { get; set; }
        public int SubquestionType { get; set; }
        public string SubquestionText { get; set; }
        public string ImageSource { get; set; }
        public string[] PossibleAnswerList { get; set; }
        public string[] CorrectAnswerList { get; set; }
        public string QuestionNumberIdentifier { get; set; }
        public QuestionTemplate QuestionTemplate { get; set; }
    }
}