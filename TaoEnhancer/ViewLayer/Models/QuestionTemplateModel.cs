using DomainModel;

namespace ViewLayer.Models
{
    public class QuestionTemplateModel : PageModel
    {
        private QuestionTemplate questionTemplate;
        private string testNameIdentifier;
        private string testNumberIdentifier;
        private string[] subquestionTypeTextArray;
        private SubquestionTemplate subquestionTemplate;

        public QuestionTemplate QuestionTemplate { get { return questionTemplate; } set { questionTemplate = value; } }
        public string TestNameIdentifier { get { return testNameIdentifier; } set { testNameIdentifier = value; } }
        public string TestNumberIdentifier { get { return testNumberIdentifier; } set { testNumberIdentifier = value; } }
        public string[] SubquestionTypeTextArray { get { return subquestionTypeTextArray; } set { subquestionTypeTextArray = value; } }
        public SubquestionTemplate SubquestionTemplate { get { return subquestionTemplate; } set { subquestionTemplate = value; } }
    }
}
