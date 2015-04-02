using System;
using Xunit;

namespace TempusOptimus.Tests
{
    public class date_convert_tests
    {
        [Fact]
        public void datetime_minvalue_converts_to_first_day_of_year_754()
        {
            var input = DateTime.MinValue;
            var output = OptimaDate.Convert(input);
            
            Assert.Equal(754, output.Year);
            Assert.Equal(1, output.Month);
            Assert.Equal(1, output.Day);
            Assert.Equal(1, output.DayOfYear);
        }

        [Fact]
        public void min_date_time()
        {
            var input = DateTime.MinValue.TimeOfDay;
            var output = OptimaTime.Convert(input);

        }
    }
}
