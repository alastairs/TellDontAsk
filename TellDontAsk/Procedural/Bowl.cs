using System.Collections.Generic;
using System.Linq;

namespace TellDontAsk.Procedural
{
    internal class Bowl
    {
        private IEnumerable<Ingredient> ingredients;

        public void Add(params Ingredient[] ingredients)
        {
            this.ingredients = ingredients;
        }

        public void Mix()
        {
            CakeMix = new CakeMix();
            ingredients = Enumerable.Empty<Ingredient>();
        }

        public CakeMix CakeMix { get; private set; }
    }
}