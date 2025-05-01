using SOLID_Principle_Practice.SOLID.SRP.AppliancesControllers;

namespace SOLID_Principle_Practice.SOLID.Open
{
    public class LightTimerControl : TimerControl
    {
        public void SetLightTimer() => Console.WriteLine("Setting timer for light");
    }
}
