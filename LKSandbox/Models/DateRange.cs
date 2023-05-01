using LKSandbox.Interfaces.Parameters;

namespace LKSandbox.Models
{
    public class DateRange : IDateRange
    {
        private DateOnly _begin;
        public DateOnly Begin { get => _begin; }
        private DateOnly _end;
        public DateOnly End { get => _end; }

        public DateRange(DateOnly begin, DateOnly end)
        {
            _begin = begin;
            _end = end;
        }

        public override string ToString()
        {
            return "Range: " + _begin.ToString() + " - " + _end.ToString();
        }
    }
}
