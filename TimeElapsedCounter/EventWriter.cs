using System;
using System.Collections.Generic;

namespace TimeElapsedCounter
{
    public class EventWriter : IEventWriter
    {

        private const string future = "sucederá en";
        private const string past = "ocurrio hace";
        private IDateStringBuilder _stringBuilder;
        public EventWriter(IDateStringBuilder stringBuilder)
        {
            _stringBuilder = stringBuilder;
        }

        public void Printconsole(List<IEvent> events)
        {
            foreach (IEvent @event in events)
            {
                string valueToPrint = $"El evento {@event.Title} {EvaluateTime(@event)} {_stringBuilder.GetPredicated(@event)} ";
                Console.WriteLine(valueToPrint);
            }
        }

        private string EvaluateTime(IEvent @event)
        {
            return Convert.ToInt64(@event.ElapsedMissing.TotalMilliseconds) > 0 ? past : future;
        }
    }
}
