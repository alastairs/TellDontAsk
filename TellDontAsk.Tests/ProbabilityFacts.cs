using System;
using NUnit.Framework;

namespace TellDontAsk.Tests
{
    public class ProbabilityFacts
    {
        [TestFixture]
        public class EqualsShould
        {
            [Test]
            public void ReturnTrueIfTheInstancesAreTheSameObject()
            {
                var probability = new Probability(0.25);
                var otherProbability = probability;

                Assert.That(otherProbability, Is.EqualTo(probability));
            }

            [Test]
            public void ReturnTrueIfTheInstancesRepresentTheSameValue()
            {
                var probability = new Probability(0.25);
                var otherProbability = new Probability(0.25);

                Assert.That(otherProbability, Is.EqualTo(probability));
            }

            [Test]
            public void ReturnFalseIfTheInstancesRepresentDifferentValues()
            {
                var probability = new Probability(0.25);
                var otherProbability = new Probability(1/3);

                Assert.That(otherProbability, Is.Not.EqualTo(probability));
            }
        }

        [TestFixture]
        public class CombinedWithShould
        {
            [TestCase(0.5, 0.25)]
            [TestCase(0.75, 0.25)]
            [TestCase(0.3, 0.6666666666666667)]
            public void ReturnThisProbabilityMultipliedByTheArgument(double firstProbability, double secondProbability)
            {
                var probability = new Probability(firstProbability);

                var combinedProbability = probability.CombinedWith(new Probability(secondProbability));

                Assert.That(combinedProbability, Is.EqualTo(new Probability(firstProbability * secondProbability)));
            }
        }

        [TestFixture]
        public class InverseOfShould
        {
            [TestCase(0.25)]
            [TestCase(0.6666666666667)]
            [TestCase(Math.PI - 3)]
            public void ReturnThisProbabilitySubtractedFrom1(double rawProbability)
            {
                var probability = new Probability(rawProbability);

                var inverseProbability = probability.InverseOf();

                Assert.That(inverseProbability, Is.EqualTo(new Probability(1 - rawProbability)));
            }
        }

        [TestFixture]
        public class EitherShould
        {
            [TestCase(0.5, 0.25)]
            [TestCase(0.75, 0.25)]
            [TestCase(0.3, 0.6666666666666667)]
            public void ReturnAPlusBLessAMultipliedByB(double a, double b)
            {
                var probabilityOfA = new Probability(a);
                var probabilityOfB = new Probability(b);

                var eitherEvent = probabilityOfA.Either(probabilityOfB);

                Assert.That(eitherEvent, Is.EqualTo(new Probability(a + b - (a*b))));
            }
        }
    }
}
