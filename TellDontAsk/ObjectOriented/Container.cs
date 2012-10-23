namespace TellDontAsk.ObjectOriented
{
    public abstract class Container
    {
        public void MixWith(Utensil utensil)
        {
            utensil.Mix(this.Ingredients);
        }

        private object Ingredients { get; set; }
    }
}