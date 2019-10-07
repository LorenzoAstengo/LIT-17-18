using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise07
{
    public class IbmObserver : IObserver<Quote>
    {
        private IDisposable unsubscriber;
        public string Type { get; set; }
        public List<Quote> receivedQuotes = new List<Quote>();

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
            if (quote.Symbol == "IBM")
            {
                receivedQuotes.Add(Ret(quote));
            }
        }

        public static Quote Ret(Quote quote)
        {
            return quote;
        }

        public IbmObserver() { }
    }
}
