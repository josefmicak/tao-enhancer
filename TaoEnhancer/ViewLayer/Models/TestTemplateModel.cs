using DomainModel;

namespace ViewLayer.Models
{
    public class TestTemplateModel : PageModel
    {
        private TestTemplate testTemplate;

        public TestTemplate TestTemplate { get { return testTemplate; } set { testTemplate = value; } }
    }
}
