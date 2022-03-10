using System.Collections.Generic;

namespace Factory.FactorySample2.Abstract
{
    /// <summary>
    /// The 'Creator' abstract class
    /// </summary>
    internal abstract class Document
    {
        private List<Page> _pages = new List<Page>();

        // Factory Method
        protected abstract void CreatePages();

        // Constructor calls abstract Factory method
        protected Document()
        {
            CreatePages();
        }

        public List<Page> Pages
        {
            get
            {
                return _pages;
            }
        }
    }
}
