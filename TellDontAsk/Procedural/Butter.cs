namespace TellDontAsk.Procedural
{
    internal class Butter : Ingredient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="amount">Amount of butter in grams.</param>
        public Butter(int amount) : base(amount)
        {
            Weight = amount;
        }

        protected int Weight { get; set; }

        public static readonly Butter Knob = new Butter(10);
    }
}