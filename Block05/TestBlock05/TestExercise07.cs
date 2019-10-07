using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Exercise07;

namespace TestBlock05
{
    [TestClass]
    public class TestExercise07
    {
        [TestMethod]
        public void TestIBMObserver()
        {
            IbmObserver observer = new IbmObserver();
            ObservableQuote observable = new ObservableQuote();
            List<Quote> expQuotes = new List<Quote>();
            foreach (Quote quote in QuoteRepository.GetAllQuotes())
            {
                if (quote.Symbol == "IBM")
                {
                    expQuotes.Add(quote);
                }
            }

            observer.Subscribe(observable);
            for (int i = 0; i < expQuotes.Count; i++)
            {
                observable.GetQuotes();
                Assert.AreEqual(expQuotes[i].Price, observer.receivedQuotes[i].Price);
            }

            observer.Unsubscribe();
            Assert.AreEqual(0, observable.Observers.Count);
        }

        [TestMethod]
        public void TestDELLObserver()
        {
            DellObserver observer = new DellObserver();
            ObservableQuote observable = new ObservableQuote();
            List<Quote> expQuotes = new List<Quote>();
            foreach (Quote quote in QuoteRepository.GetAllQuotes())
            {
                if (quote.Symbol == "DELL")
                {
                    expQuotes.Add(quote);
                }
            }

            observer.Subscribe(observable);
            for (int i = 0; i < expQuotes.Count; i++)
            {
                observable.GetQuotes();
                Assert.AreEqual(expQuotes[i].Price, observer.receivedQuotes[i].Price);
            }

            observer.Unsubscribe();
            Assert.AreEqual(0, observable.Observers.Count);
        }
    }
}
