namespace TellDontAsk.Procedural
{
    internal class CakeTin
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="i">The size of the cake tin in cm</param>
        public CakeTin(int i)
        {
            
        }

        public bool BaseIsGreased { get; set; }
        public bool SideIsGreased { get; set; }

        public void GreaseBase(Butter knobOfButter)
        {
            BaseIsGreased = true;
        }

        public void GreaseSide(Butter knobOfButter)
        {
            SideIsGreased = true;
        }

        public void AddMix(object mix)
        {
            throw new System.NotImplementedException();
        }
    }
}