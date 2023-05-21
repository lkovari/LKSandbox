using LKSandbox.Interfaces;

namespace LKSandbox.Utils
{
    public class TwinsDetector
    {
        public static IEnumerable<IEnumerable<ICreated>> Detect(IEnumerable<ICreated> createdDates)
        {
            IEnumerable<IEnumerable<ICreated>> result;
            if (createdDates == null)
            {
                return null;
            }
            else
            {
                result = createdDates
                    .Select((d, ix) => (ICreated: d, Index: ix))
                    .Select(x => createdDates
                        .Where((d, ix) => x.Index > ix && Math.Abs(x.ICreated.Create.DayNumber - d.Create.DayNumber) <= 1)
                        .Prepend(x.ICreated)
                        .ToList())
                    .Where(list => list.Count > 1).ToList();
            }
            return result;
        }
    }
}
