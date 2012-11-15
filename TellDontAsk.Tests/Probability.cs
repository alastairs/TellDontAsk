namespace TellDontAsk.Tests
{
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

        public Probability Either(Probability other)
        {
            return new Probability(rawProbability + other.rawProbability - (rawProbability * other.rawProbability));
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