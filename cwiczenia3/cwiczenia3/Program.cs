using cwiczenia3;
using cwiczenia3.Exceptions;

public class Program {
    public static void Main(string[] args)
    {
        //GasContainer
        GasContainer gasContainer = new GasContainer(20, 250, 550, 550, 300, 3);
        
        try
        {
            gasContainer.Load(100);
            gasContainer.Load(300);
        }
        catch(OverfillException e)
        {
            Console.WriteLine(e);
        }
        
        Console.WriteLine("Cargo weight before unload: " + gasContainer.CargoWeight);
        gasContainer.Unload();
        Console.WriteLine("Cargo weight after unload: " + gasContainer.CargoWeight);
        
        //LiquidContainer
        LiquidContainer liquidContainer = new LiquidContainer(120, 200, 700, 600, 800, true);
        
        Console.WriteLine("Cargo weight before unload: " + liquidContainer.CargoWeight);
        liquidContainer.Unload();
        Console.WriteLine("Cargo weight after unload: " + liquidContainer.CargoWeight);

        try
        {
            liquidContainer.Load(100);
            liquidContainer.Load(301);
        }
        catch(OverfillException e)
        {
            Console.WriteLine(e);
        }
        
        //RefrigiratedContainer
        RefrigiratedContainer refrigiratedContainer = new RefrigiratedContainer(5, 230, 1200, 720, 1000, "Bananas", 12);
        
        Console.WriteLine("Cargo weight before unload: " + refrigiratedContainer.CargoWeight);
        refrigiratedContainer.Unload();
        Console.WriteLine("Cargo weight after unload: " + refrigiratedContainer.CargoWeight);
        
        try
        {
            refrigiratedContainer.Load(500);
            refrigiratedContainer.Load(700);
        }
        catch(OverfillException e)
        {
            Console.WriteLine(e);
        }
    }
}