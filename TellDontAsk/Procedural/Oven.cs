using System;

namespace TellDontAsk.Procedural
{
    internal class Oven
    {
        public bool TurnedOn { get; set; }
        public int Temperature { get; set; }

        public void Add(CakeTin tin1)
        {
            throw new NotImplementedException();
        }

        public TimeSpan Timer { get; set; }
    }
}