using System;
using NUnit.Framework;

namespace TellDontAsk.Tests
{
    public class ProbabilityFacts
    {
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
    }

    public class Probability
    {
        private readonly double rawProbability;

        public Probability(double rawProbability)
        {
            this.rawProbability = rawProbability;
        }

        public Probability CombinedWith(Probability probability)
        {
            return new Probability(rawProbability * probability.rawProbability);
        }

        public Probability InverseOf()
        {
            return new Probability(1 - rawProbability);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Probability);
        }

        public override int GetHashCode()
        {
            return rawProbability.GetHashCode();
        }

        protected bool Equals(Probability other)
        {
            return rawProbability.Equals(other.rawProbability);
        }
    }
}
