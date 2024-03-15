namespace cwiczenia3;

public class LiquidContainer : Container
{
    public LiquidContainer(int cargoWeight, int height, int containerWeight, int depth, string serialNumber, int maxCargoWeight) : base(cargoWeight, height, containerWeight, depth, serialNumber, maxCargoWeight)
    {
        
    }

    public override void Load(int cargoWeight)
    {
        Console.WriteLine();
        base.Load(cargoWeight);
    }
}