using System;
using System.Collections.Generic;

namespace TellDontAsk.ObjectOriented
{
    public abstract class Utensil
    {
        public void Mix(ICollection<Ingredient> ingredients)
        {
            throw new NotImplementedException();
        }
    }
}