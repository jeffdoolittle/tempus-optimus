using System;

namespace TempusOptimus
{
    public class OptimaTime
    {
        private const double TicksPerDay = 864000000000;

        private readonly int _millimodes;
        private readonly int _modes;
        private readonly double _remainder;
        private readonly long _ticks;
        private readonly double _totalModes;

        public OptimaTime(double intervals)
            : this((long)(intervals / 1000 * TicksPerDay))
        {
        }

        private OptimaTime(long ticks)
        {
            if (ticks > TicksPerDay)
            {
                throw new ArgumentException(string.Format("Value cannot exceed {0}", TicksPerDay), "ticks");
            }
            _ticks = ticks;
            if (Math.Abs(_ticks - TicksPerDay) > double.Epsilon)
            {
                _totalModes = (1000 * ticks) / TicksPerDay;
                _modes = (int)_totalModes;
                _remainder = _totalModes - _modes;
                _millimodes = (int)(1000 * _remainder);
            }
            else
            {
                _totalModes = 0;
                _modes = 0;
                _remainder = 0;
                _millimodes = 0;
            }
        }

        public int Centimodes
        {
            get { return _millimodes / 10; }
        }

        public int Decimodes
        {
            get { return _millimodes / 100; }
        }

        public int Millimodes
        {
            get { return _millimodes; }
        }

        public int Modes
        {
            get { return _modes; }
        }

        public static OptimaTime Now
        {
            get { return Convert(DateTime.UtcNow.TimeOfDay); }
        }

        public TimeSpan TimeSpan
        {
            get { return TimeSpan.FromTicks(_ticks); }
        }

        public static OptimaTime Convert(TimeSpan ts)
        {
            return new OptimaTime(ts.Ticks);
        }

        public static TimeSpan Convert(OptimaTime dt)
        {
            return TimeSpan.FromTicks(dt._ticks);
        }

        public string ToString(int scale)
        {
            string str = string.Format("M{{0:000.{0}}}", "".PadRight(scale, '0'));
            return string.Format(str, _totalModes);
        }

        public override string ToString()
        {
            return ToString(3);
        }
    }
}