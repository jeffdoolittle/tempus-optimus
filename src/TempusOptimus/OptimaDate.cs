using System;

namespace TempusOptimus
{
    public class OptimaDate
    {
        private const int YearOfTheFoundingOfRomeBCE = 753;
        private readonly int _dayOfMonth;
        private readonly int _dayOfYear;
        private readonly int _month;
        private readonly int _year;

        public OptimaDate(int year, int tdMonth, int tdDay)
            : this(year, tdMonth - 28 + tdDay)
        {
        }

        private OptimaDate(int year, int dayOfYear)
        {
            _year = year + YearOfTheFoundingOfRomeBCE;
            _dayOfYear = dayOfYear;
            decimal num = dayOfYear % new decimal(28);
            _month = (int)Math.Ceiling(dayOfYear / new decimal(280, 0, 0, false, 1));
            if (dayOfYear == 365)
            {
                _month = 13;
                _dayOfMonth = 29;
            }
            else if (dayOfYear == 366)
            {
                _month = 13;
                _dayOfMonth = 30;
            }
            else if (num != new decimal(0))
            {
                _dayOfMonth = (int)num;
            }
            else
            {
                _dayOfMonth = 28;
            }
        }

        public int DayOfYear
        {
            get { return _dayOfYear; }
        }

        public static OptimaDate Today
        {
            get { return Convert(DateTime.UtcNow.Date); }
        }

        public static OptimaDate Convert(DateTime dateTime)
        {
            return new OptimaDate(dateTime.Year, dateTime.DayOfYear);
        }

        private static string MonthName(int month)
        {
            return ((Months)month).ToString();
        }

        public string ToLongDateString()
        {
            string str = string.Format("{0} {1} {2:0000}", _dayOfMonth, MonthName(_month), _year);
            return str;
        }

        public string ToShortDateString()
        {
            string str = string.Format("{0}/{1}/{2:0000}", _dayOfMonth, _month, _year);
            return str;
        }

        public override string ToString()
        {
            return ToLongDateString();
        }

        private enum Months
        {
            Primum = 1,
            Secundo = 2,
            Tertia = 3,
            Quartum = 4,
            Quinto = 5,
            Sexto = 6,
            Septimo = 7,
            Octavo = 8,
            Nono = 9,
            Decimo = 10,
            Undecimo = 11,
            Duodecimo = 12,
            Tertiadecima = 13
        }
    }
}