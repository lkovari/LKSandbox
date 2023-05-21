using FluentAssertions;
using LKSandbox.Interfaces;
using LKSandbox.Models;
using LKSandbox.Utils;

namespace LKSandboxTest
{
    public class TwinsTest
    {
        List<ICreated> createsTest1;
        List<ICreated> createsTest2;
        [SetUp]
        public void Setup()
        {
            createsTest1 = new List<ICreated>();
            createsTest1.Add(new Created(new DateOnly(1965, 2, 2)));
            createsTest1.Add(new Created(new DateOnly(1965, 2, 3)));
            createsTest1.Add(new Created(new DateOnly(1966, 2, 2)));
            createsTest1.Add(new Created(new DateOnly(1966, 12, 10)));
            createsTest1.Add(new Created(new DateOnly(1966, 12, 11)));
            createsTest1.Add(new Created(new DateOnly(2023, 4, 3)));
            createsTest1.Add(new Created(new DateOnly(2023, 4, 5)));
            createsTest1.Add(new Created(new DateOnly(1923, 5, 21)));
            createsTest1.Add(new Created(new DateOnly(1923, 5, 22)));
            createsTest1.Add(new Created(new DateOnly(2023, 5, 21)));
            createsTest1.Add(new Created(new DateOnly(2023, 5, 21)));
            createsTest2 = new List<ICreated>();
            createsTest2.Add(new Created(new DateOnly(1965, 2, 2)));
            createsTest2.Add(new Created(new DateOnly(1966, 2, 2)));
            createsTest2.Add(new Created(new DateOnly(1966, 12, 11)));
            createsTest2.Add(new Created(new DateOnly(2023, 4, 3)));
            createsTest2.Add(new Created(new DateOnly(2023, 4, 5)));
            createsTest2.Add(new Created(new DateOnly(1923, 5, 21)));
            createsTest2.Add(new Created(new DateOnly(1923, 5, 23)));
            createsTest2.Add(new Created(new DateOnly(2023, 5, 21)));
            createsTest2.Add(new Created(new DateOnly(2023, 5, 23)));

        }
        [Test]
        public void TwinsDetectionTest1()
        {
            IEnumerable<IEnumerable<ICreated>> twins = TwinsDetector.Detect(createsTest1);
            twins.Should().HaveCountGreaterThan(0);
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
        [Test]
        public void TwinsDetectionTest2()
        {
            IEnumerable<IEnumerable<ICreated>> twins = TwinsDetector.Detect(createsTest2);
            twins.Should().HaveCountLessThan(1);
        }
    }
}
