namespace TellDontAsk
{
    class Program
    {
        static void Main(string[] args)
        {
            // Don't run this program. The below line will take 1hr 20 minutes to complete.
            new Procedural.Baker().BakeVictoriaSponge();
            

            // Baking an object-oriented cake is not like baking a real cake. The point of object orientation 
            // is not to model the real world, but to effectively and efficiently model your problem.  By properly
            // modelling the problem in an object oriented way, we can dispense with the manager code that is 
            // required in a real-world/procedural implementation, improving the cohesion of our classes.  

            var butter = new ObjectOriented.Butter(225);
            var sugar = new ObjectOriented.CasterSugar(225);
            var eggs = new[]
            {
                new ObjectOriented.Egg(),
                new ObjectOriented.Egg(),
                new ObjectOriented.Egg(),
                new ObjectOriented.Egg()
            };
            var vanillaExtract = new ObjectOriented.VanillaExtract(2);
            var selfRaisingFlour = new ObjectOriented.SelfRaisingFlour(225);
            
            var mixingBowl = new ObjectOriented.MixingBowl();
            butter.AddTo(mixingBowl);
            sugar.AddTo(mixingBowl);

            // TODO: Cream the butter and sugar together

            foreach (var egg in eggs)
            {
                egg.AddTo(mixingBowl);
            }

            // TODO: Beat the eggs into the mix

            vanillaExtract.AddTo(mixingBowl);

            // TODO: Stir the vanilla extract into the mix

            selfRaisingFlour.AddTo(mixingBowl);

            // TODO: Fold the flour into the mix

            var oven = new ObjectOriented.Oven();
            oven.SetTemperature(180);
            new ObjectOriented.Cake().BakeIn(oven);
        }
    }
}