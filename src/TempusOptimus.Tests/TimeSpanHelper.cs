using System;
using System.Text;

namespace TempusOptimus
{
    public class TimeSpanHelper
    {
        private void AddInterval(StringBuilder sb, double interval)
        {
            var optimaTime = new OptimaTime(interval);
            sb.AppendFormat("{0} = {1}", optimaTime, optimaTime.TimeSpan).AppendLine();
        }

        public void Run()
        {
            var stringBuilder = new StringBuilder();
            AddInterval(stringBuilder, 0);
            AddInterval(stringBuilder, 41.6666666666667);
            AddInterval(stringBuilder, 83.3333333333333);
            AddInterval(stringBuilder, 125);
            AddInterval(stringBuilder, 166.666666666667);
            AddInterval(stringBuilder, 250);
            AddInterval(stringBuilder, 333.333333333333);
            AddInterval(stringBuilder, 500);
            Console.WriteLine(stringBuilder);
        }
    }
}