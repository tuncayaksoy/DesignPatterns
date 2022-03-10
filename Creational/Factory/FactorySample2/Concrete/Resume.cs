using Factory.FactorySample2.Abstract;

namespace Factory.FactorySample2.Concrete
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    internal class Resume : Document
    {
        // Factory Method implementation
        protected override void CreatePages()
        {
            Pages.Add(new SkillsPage());
            Pages.Add(new EducationPage());
            Pages.Add(new ExperiencePage());
        }
    }
}
