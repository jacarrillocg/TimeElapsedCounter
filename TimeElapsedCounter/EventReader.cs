using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TimeElapsedCounter
{
    public class EventReader : IEventReader
    {
        private string _txtRoute;
        private char _separator;
        public EventReader(string txtRoute, char separatorChar)
        {
            _txtRoute = txtRoute;
        }

        public List<IEvent> ReadEventDocument()
        {
            var path = _txtRoute;

            string[] lines = File.ReadAllLines(path, Encoding.UTF8);
            List<IEvent> Events = new List<IEvent>();

            foreach (string line in lines)
            {
                CreateEvent(Events, line);
            }

            return Events;
        }

        private void CreateEvent(List<IEvent> Events, string line)
        {
            string[] splitedArray = line.Split(_separator);
            if (splitedArray.Length > 0)
            {
                Event @event = new Event();
                @event.Title = splitedArray[0].ToStringNotEmpty();
                @event.EventDate = splitedArray[1].ToDateTime();

                @event.Elapsedtime = GetElapsedTime();
                @event.Missingtime = GetMissingtime();

                Events.Add(@event);
            }
        }

        private DateTime GetMissingtime()
        {
            throw new NotImplementedException();
        }

        private DateTime GetElapsedTime()
        {
            throw new NotImplementedException();
        }
    }

}
