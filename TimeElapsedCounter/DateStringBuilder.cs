using System;
using System.Text;

namespace TimeElapsedCounter
{
    public class DateStringBuilder : IDateStringBuilder
    {
        public string GetPredicated(IEvent @event)
        {
            StringBuilder stringBuilder = new StringBuilder();
            GetMonts(@event, stringBuilder);
            GetDays(@event, stringBuilder);
            GetHours(@event, stringBuilder);
            GetMinutes(@event, stringBuilder);

            return stringBuilder.ToString();
        }

        private static void GetMinutes(IEvent @event, StringBuilder stringBuilder)
        {
            stringBuilder.Append(Math.Abs(@event.ElapsedMissing.Minutes) + " minutos ");
        }

        private static void GetHours(IEvent @event, StringBuilder stringBuilder)
        {
            stringBuilder.Append(Math.Abs(@event.ElapsedMissing.Hours) + " horas ");
        }

        private static void GetDays(IEvent @event, StringBuilder stringBuilder)
        {
            stringBuilder.Append(Math.Abs(@event.ElapsedMissing.Days) + " días ");
        }

        private static void GetMonts(IEvent @event, StringBuilder stringBuilder)
        {

            stringBuilder.Append(Math.Abs(@event.ElapsedMissing.GetMonths()) + " Meses ");

        }


    }
}
