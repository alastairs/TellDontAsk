namespace TellDontAsk.ObjectOriented
{
    public abstract class Ingredient
    {
        private readonly string name;
        private readonly int grams;

        protected Ingredient(string name, int grams)
        {
            this.name = name;
            this.grams = grams;
        }

        public void AddTo(Container container)
        {
            container.Add(this);
        }
    }
}