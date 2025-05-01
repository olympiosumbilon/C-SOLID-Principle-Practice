using SOLID_Principle_Practice.SOLID.Interface;

namespace SOLID_Principle_Practice.SOLID.Compiler
{
    public class HomeAutomationSystem
    {
        private readonly ILight light;
        private readonly IAC ac;

        public HomeAutomationSystem(ILight light, IAC ac)
        {
            this.light = light;
            this.ac = ac;
        }

        public void TurnOnLight() => light.TurnOn();
        public void TurnOffLight() => light.TurnOff();
        public void TurnOnAC() => ac.TurnOn();
        public void TurnOffAC() => ac.TurnOff();
    }
}
