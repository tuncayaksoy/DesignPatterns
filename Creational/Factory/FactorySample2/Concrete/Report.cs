using Factory.FactorySample2.Abstract;

namespace Factory.FactorySample2.Concrete
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    internal class Report : Document
    {
        // Factory Method implementation
        protected override void CreatePages()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ResultsPage());
            Pages.Add(new ConclusionPage());
            Pages.Add(new SummaryPage());
            Pages.Add(new BibliographyPage());
        }
    }
}
