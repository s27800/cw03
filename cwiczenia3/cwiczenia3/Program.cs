using cwiczenia3;
using cwiczenia3.Exceptions;

public class Program {
    public static void Main(string[] args)
    {
        //GasContainer
        GasContainer gasContainer = new GasContainer(20, 250, 550, 550, "KON-G-1", 300, 3);
        
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
        LiquidContainer liquidContainer = new LiquidContainer(120, 200, 700, 600, "KON-L-2", 800, true);
        
        //RefrigiratedContainer
        RefrigiratedContainer refrigiratedContainer = new RefrigiratedContainer(0, 230, 1200, 720, "KON-R-3", 1000, "Bananas", 12);
        
    }
}