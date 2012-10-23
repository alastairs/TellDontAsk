namespace TellDontAsk.ObjectOriented
{
    internal class MixingBowl : Container
    {
        public override void Add(Ingredient ingredient)
        {
            Ingredients.Add(ingredient);
        }
    }
}