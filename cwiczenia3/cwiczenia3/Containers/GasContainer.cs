using cwiczenia3.Interfaces;

namespace cwiczenia3;

public class GasContainer : Container, IHazardNotifier
{
    private int pressure; //[atm]
    
    public int Pressure { get; protected set; }
    
    public GasContainer(int cargoWeight, int height, int containerWeight, int depth, string serialNumber, int maxCargoWeight, int pressure) : base(cargoWeight, height, containerWeight, depth, serialNumber, maxCargoWeight)
    {
        Pressure = pressure;
        Console.WriteLine("Created gas container.");
    }

    public override void Unload()
    {
        CargoWeight = (int) (0.05 * CargoWeight);
    }

    public void SendMesssage()
    {
        Console.WriteLine("Dangerous situation in container " + SerialNumber);
    }
}