using System;
using Factory.FactorySample2.Abstract;
using Factory.FactorySample2.Concrete;

namespace Factory.FactorySample2
{
    public class Sample2
    {
        public void Show()
        {
            // Note: constructors call Factory Method
            Document[] documents = new Document[2];
            documents[0] = new Resume();
            documents[1] = new Report();

            // Display document pages
            foreach (Document document in documents)
            {
                Console.WriteLine("\n" + document.GetType().Name + "--");

                foreach (Page page in document.Pages)
                {
                    Console.WriteLine(" " + page.GetType().Name);
                }
            }
        }
    }
}
