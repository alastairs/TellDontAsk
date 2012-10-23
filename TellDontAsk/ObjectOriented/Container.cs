using System.Collections.Generic;

namespace TellDontAsk.ObjectOriented
{
    public abstract class Container
    {
        public void MixWith(Utensil utensil)
        {
            utensil.Mix(Ingredients);
        }

        protected ICollection<Ingredient> Ingredients { get; set; }

        public abstract void Add(Ingredient ingredient);
    }
}