using FluentAssertions;
using LKSandbox.Interfaces;
using LKSandbox.Models;
using LKSandbox.Utils;

namespace LKSandboxTest
{
    public class TwinsTest
    {
        List<ICreated> creates;
        [SetUp]
        public void Setup()
        {
            creates = new List<ICreated>();
            creates.Add(new Created(new DateOnly(1965, 2, 2)));
            creates.Add(new Created(new DateOnly(1965, 2, 3)));
            creates.Add(new Created(new DateOnly(1966, 2, 2)));
            creates.Add(new Created(new DateOnly(1966, 12, 10)));
            creates.Add(new Created(new DateOnly(1966, 12, 11)));
            creates.Add(new Created(new DateOnly(2023, 4, 3)));
            creates.Add(new Created(new DateOnly(2023, 4, 5)));
            creates.Add(new Created(new DateOnly(1923, 5, 21)));
            creates.Add(new Created(new DateOnly(1923, 5, 22)));
            creates.Add(new Created(new DateOnly(2023, 5, 21)));
            creates.Add(new Created(new DateOnly(2023, 5, 21)));
        }
        [Test]
        public void TwinsDetectionTest()
        {
            IEnumerable<IEnumerable<ICreated>> twins = TwinsDetector.Detect(creates);
            twins.Should().HaveCount(4);
            foreach (var twin in twins)
            {
                twin.Should().NotBeNull();
                twin.Should().HaveCount(2);
                twin.ElementAt(0).Should().NotBeNull();
                twin.ElementAt(0).Should().NotBeNull();
                var diff = Math.Abs(twin.ElementAt(0).Create.DayNumber - twin.ElementAt(0).Create.DayNumber);
                diff.Should().BeLessThan(2);
            }
        }

    }
}
