namespace SOLID_Principle_Practice.SOLID.Dependency.ApplianceControlInterfaces
{
    public interface IAppliance
    {
        void TurnOn();
        void TurnOff();
    }

    public class LightControl : IAppliance{
        public void TurnOn() => Console.WriteLine("Turning on the light");
        public void TurnOff() => Console.WriteLine("Turning off the light");
    }

    public class ACControl : IAppliance {
        public void TurnOn() => Console.WriteLine("Turning on the air conditioner");
        public void TurnOff() => Console.WriteLine("Turning off the air conditioner");
    }
}