using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise07
{
    public class ObservableQuote : IObservable<Quote>
    {
        private List<IObserver<Quote>> observers;
        public List<IObserver<Quote>> Observers
        {
            get { return observers; }
        }
        private List<Quote> quotes;

        public ObservableQuote()
        {
            observers = new List<IObserver<Quote>>();
            quotes = new List<Quote>();
            foreach(Quote quote in QuoteRepository.GetAllQuotes())
            {
                quotes.Add(quote);
            }
        }

        public IDisposable Subscribe(IObserver<Quote> observer)
        {
            // Check whether observer is already registered. If not, add it
            if (!observers.Contains(observer))
                observers.Add(observer);

            return new Unsubscriber(observers, observer);
        }

        private class Unsubscriber : IDisposable
        {
            private List<IObserver<Quote>> observers;
            private IObserver<Quote> observer;

            public Unsubscriber(List<IObserver<Quote>> observers, IObserver<Quote> observer)
            {
                this.observers = observers;
                this.observer = observer;
            }

            public void Dispose()
            {
                if (observers.Contains(observer))
                    observers.Remove(observer);
            }
        }

        public void GetQuotes()
        {
            foreach (IObserver<Quote> observer in observers)
            {
                foreach (Quote quote in quotes)
                {
                    if (quote.Symbol == null || quote.Price < 0)
                    {
                        observer.OnError(new ApplicationException("Bad Quote data"));
                    }
                    else
                        observer.OnNext(quote);
                }            
            }
        }
    }

    public class Observer : IObserver<Quote>
    {
        private IDisposable unsubscriber;
        public string Type { get; set; }
        public List<Quote> test1 = new List<Quote>();

        public virtual void Subscribe(IObservable<Quote> provider)
        {
            unsubscriber = provider.Subscribe(this);
        }

        public virtual void Unsubscribe()
        {
            unsubscriber.Dispose();
        }

        public virtual void OnCompleted()
        {
        }

        public virtual void OnError(Exception error)
        {
            throw new Exception();
        }

        public virtual void OnNext(Quote quote)
        {
            test1.Add(Ret(quote));
        }

        public static Quote Ret(Quote quote)
        {
            return quote;
        }
    }
}
