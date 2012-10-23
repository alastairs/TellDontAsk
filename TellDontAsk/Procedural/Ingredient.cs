namespace TellDontAsk.Procedural
{
    internal class Ingredient
    {
        private readonly int amount;

        protected Ingredient(int amount)
        {
            this.amount = amount;
        }

        public int Amount { get { return amount; } }
    }
}