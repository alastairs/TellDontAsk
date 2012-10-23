namespace TellDontAsk.Procedural
{
    internal class CakeTin
    {
        private int size;
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="size">The size of the cake tin in cm</param>
        public CakeTin(int size)
        {
            this.size = size;
        }

        public bool BaseIsGreased { get; set; }
        public bool SideIsGreased { get; set; }

        public CakeMix Contents { get; private set; }

        public void GreaseBase(Butter knobOfButter)
        {
            BaseIsGreased = true;
        }

        public void GreaseSide(Butter knobOfButter)
        {
            SideIsGreased = true;
        }

        public void AddMix(CakeMix mix)
        {
            Contents = mix;
        }
    }
}