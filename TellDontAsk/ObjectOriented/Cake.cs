using System;

namespace TellDontAsk.ObjectOriented
{
    internal class Cake
    {
        public void BakeIn(Oven oven)
        {
            var timer = new Timer(TimeSpan.FromMinutes(20));
            oven.SetTimer(timer);
        }
    }
}