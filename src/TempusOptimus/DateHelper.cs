using System;
using System.Text;

namespace TempusOptimus
{
    public class DateHelper
    {
        private void AddDate(StringBuilder sb, DateTime date)
        {
            sb.AppendFormat("{0} = {1}", date.ToLongDateString(), OptimaDate.Convert(date)).AppendLine();
        }

        public void Run()
        {
            var stringBuilder = new StringBuilder();
            var dateTime = new DateTime(1, 1, 1);
            AddDate(stringBuilder, dateTime.AddDays(0));
            dateTime = new DateTime(1, 1, 1);
            AddDate(stringBuilder, dateTime.AddDays(28));
            dateTime = new DateTime(1, 1, 1);
            AddDate(stringBuilder, dateTime.AddDays(56));
            dateTime = new DateTime(1, 1, 1);
            AddDate(stringBuilder, dateTime.AddDays(84));
            dateTime = new DateTime(1, 1, 1);
            AddDate(stringBuilder, dateTime.AddDays(112));
            dateTime = new DateTime(1, 1, 1);
            AddDate(stringBuilder, dateTime.AddDays(140));
            dateTime = new DateTime(1, 1, 1);
            AddDate(stringBuilder, dateTime.AddDays(168));
            dateTime = new DateTime(1, 1, 1);
            AddDate(stringBuilder, dateTime.AddDays(196));
            dateTime = new DateTime(1, 1, 1);
            AddDate(stringBuilder, dateTime.AddDays(224));
            dateTime = new DateTime(1, 1, 1);
            AddDate(stringBuilder, dateTime.AddDays(252));
            dateTime = new DateTime(1, 1, 1);
            AddDate(stringBuilder, dateTime.AddDays(280));
            dateTime = new DateTime(1, 1, 1);
            AddDate(stringBuilder, dateTime.AddDays(308));
            dateTime = new DateTime(1, 1, 1);
            AddDate(stringBuilder, dateTime.AddDays(336));
            AddDate(stringBuilder, new DateTime(1975, 2, 6));
            AddDate(stringBuilder, new DateTime(1975, 2, 25));
            dateTime = new DateTime(1975, 2, 26);
            AddDate(stringBuilder, dateTime.AddDays(28));
            dateTime = new DateTime(1975, 2, 26);
            AddDate(stringBuilder, dateTime.AddDays(56));
            AddDate(stringBuilder, new DateTime(1977, 5, 15));
            AddDate(stringBuilder, new DateTime(2000, 7, 19));
            AddDate(stringBuilder, new DateTime(2002, 1, 28));
            AddDate(stringBuilder, new DateTime(2004, 6, 23));
            AddDate(stringBuilder, new DateTime(2011, 12, 31));
            AddDate(stringBuilder, new DateTime(2012, 2, 29));
            AddDate(stringBuilder, new DateTime(2012, 12, 31));
            Console.Write(stringBuilder);
        }
    }
}