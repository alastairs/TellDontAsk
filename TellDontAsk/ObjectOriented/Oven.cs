namespace TellDontAsk.ObjectOriented
{
    internal class Oven
    {
        private Timer timer;
        private int temperature;
        private bool isOn;

        public void SetTimer(Timer timer)
        {
            this.timer = timer;
        }

        public void SetTemperature(int degreesCentigrade)
        {
            temperature = degreesCentigrade;
            isOn = true;
        }
    }
}