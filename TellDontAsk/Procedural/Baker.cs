using System;
using System.Threading;

namespace TellDontAsk.Procedural
{
    /// <summary>
    /// This is a manager class: it controls the order of operations, and knows too much about the
    /// implementation of baking a Victoria Sponge.  
    /// </summary>
    internal class Baker
    {
        public void BakeVictoriaSponge()
        {
            // Recipe taken from: http://www.bbc.co.uk/food/recipes/victoriasponge_13555

            var oven = new Oven();
            if (!oven.TurnedOn)
            {
                oven.TurnedOn = true;
                oven.Temperature = 180;
            }

            var tin1 = new CakeTin(18);
            var tin2 = new CakeTin(18);
            var knobOfButter = Butter.Knob;
            Grease(tin1, knobOfButter);
            Grease(tin2, knobOfButter);

            var bowl = new Bowl();
            bowl.Add(new Butter(225), new CasterSugar(225));

            bowl.Add(new Egg(), new Egg(), new Egg(), new Egg());
            bowl.Add(new VanillaExtract(2)); 
            bowl.Mix();

            bowl.Add(new SelfRaisingFlour(225));
            bowl.Mix();

            tin1.AddMix(bowl.CakeMix);
            tin2.AddMix(bowl.CakeMix);

            oven.Add(tin1);
            oven.Add(tin2);

            oven.Timer = TimeSpan.FromMinutes(20);

            oven.TurnedOn = false;

            Thread.Sleep(TimeSpan.FromMinutes(60)); // Wait for the sponges to cool.
        }

        private static void Grease(CakeTin tin, Butter knobOfButter)
        {
            tin.GreaseBase(knobOfButter);
            tin.GreaseSide(knobOfButter);
        }
    }
}