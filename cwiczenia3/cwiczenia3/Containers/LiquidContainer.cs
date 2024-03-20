using cwiczenia3.Exceptions;
using cwiczenia3.Interfaces;

namespace cwiczenia3.Containers;

public class LiquidContainer : Container, IHazardNotifier
{
    private bool hasDangerousCargo;
    
    public bool HasDangerousCargo { get; protected set; }
    
    public LiquidContainer(int cargoWeight, int height, int containerWeight, int depth, int maxCargoWeight, bool hasDangerousCargo) : base(cargoWeight, height, containerWeight, depth, maxCargoWeight)
    {
        SerialNumber = "KON-L-" + ++number;
        HasDangerousCargo = hasDangerousCargo;
        Console.WriteLine("Created liquid container.");
    }

    public override void Load(int cargoWeight)
    {
        if (
            (HasDangerousCargo && CargoWeight + cargoWeight <= 0.5 * MaxCargoWeight)
            || (!HasDangerousCargo && CargoWeight + cargoWeight <= 0.9 * MaxCargoWeight)
            )
        {
            base.Load(cargoWeight);
        }
        else
        {
            SendMessage();
        }
    }

    public void SendMessage()
    {
        Console.WriteLine("Dangerous situation in container " + this.SerialNumber + ". Unable to add more cargo.");
    }

    public override string ToString()
    {
        return "Liquid Container "+ SerialNumber;
    }
}