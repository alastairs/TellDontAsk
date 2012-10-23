namespace TellDontAsk.ObjectOriented
{
    public abstract class Ingredient
    {
        public void AddTo(Container container)
        {
            container.Add(this);
        }
    }
}