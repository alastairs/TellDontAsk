using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;

namespace TellDontAsk.Procedural
{
    internal class Oven
    {
        public bool TurnedOn { get; set; }
        public int Temperature { get; set; }

        private readonly ICollection<CakeTin> tins = new Collection<CakeTin>();

        public void Add(CakeTin tin)
        {
            tins.Add(tin);
        }

        public TimeSpan Timer { get; set; }

        public void Bake()
        {
            Thread.Sleep(Timer);

            foreach (var tin in tins)
            {
                tin.Contents.IsCooked = true;
            }
        }
    }
}