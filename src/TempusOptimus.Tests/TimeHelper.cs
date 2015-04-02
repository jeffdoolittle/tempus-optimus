using System;
using System.Text;

namespace TempusOptimus
{
    public class TimeHelper
    {
        private void AddTime(StringBuilder sb, TimeSpan ts)
        {
            TimeSpan utcOffset = TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now);
            DateTime dateTime = DateTime.Today.Add(ts);
            dateTime = dateTime.Subtract(utcOffset);
            TimeSpan timeOfDay = dateTime.TimeOfDay;
            dateTime = DateTime.Today.Add(ts);
            sb.AppendFormat("{0} = {1}", dateTime.ToString("hh:mm:ss tt"), OptimaTime.Convert(timeOfDay)).AppendLine();
        }

        public void Run()
        {
            var stringBuilder = new StringBuilder();
            AddTime(stringBuilder, TimeSpan.FromHours(0));
            AddTime(stringBuilder, TimeSpan.FromHours(24));
            AddTime(stringBuilder, TimeSpan.FromMinutes(5));
            AddTime(stringBuilder, TimeSpan.FromMinutes(10));
            AddTime(stringBuilder, TimeSpan.FromMinutes(15));
            AddTime(stringBuilder, TimeSpan.FromMinutes(20));
            AddTime(stringBuilder, TimeSpan.FromMinutes(30));
            AddTime(stringBuilder, TimeSpan.FromMinutes(45));
            AddTime(stringBuilder, TimeSpan.FromMinutes(60));
            AddTime(stringBuilder, TimeSpan.FromHours(6));
            AddTime(stringBuilder, TimeSpan.FromHours(7));
            AddTime(stringBuilder, TimeSpan.FromHours(8));
            AddTime(stringBuilder, TimeSpan.FromHours(10));
            AddTime(stringBuilder, TimeSpan.FromHours(12));
            AddTime(stringBuilder, TimeSpan.FromHours(16));
            AddTime(stringBuilder, TimeSpan.FromHours(17));
            TimeSpan timeSpan = TimeSpan.FromHours(17);
            AddTime(stringBuilder, timeSpan.Add(TimeSpan.FromMinutes(30)));
            AddTime(stringBuilder, TimeSpan.FromHours(18));
            AddTime(stringBuilder, TimeSpan.FromHours(20));
            AddTime(stringBuilder, TimeSpan.FromHours(22));
            timeSpan = TimeSpan.FromHours(22);
            AddTime(stringBuilder, timeSpan.Add(TimeSpan.FromMinutes(30)));
            Console.Write(stringBuilder);
        }
    }
}