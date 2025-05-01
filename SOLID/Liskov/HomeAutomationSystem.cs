using SOLID_Principle_Practice.SOLID.Dependency.ApplianceControlInterfaces;

namespace SOLID_Principle_Practice.SOLID.Liskov
{
    public class HomeAutomationSystem
    {
        private readonly IAppliance appliance;

        public HomeAutomationSystem(IAppliance appliance)
        {
            this.appliance = appliance;
        }
        public void TurnOn() => appliance.TurnOn();
        public void TurnOff() => appliance.TurnOff();
    }
}
