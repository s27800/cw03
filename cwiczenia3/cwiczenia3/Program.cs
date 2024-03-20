using cwiczenia3.Ships;
using cwiczenia3.Exceptions;
using cwiczenia3.Containers;

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
        
        //Ship
        Ship ship = new Ship("USCGC Dallas", 50, 5, 5);

        List<Container> list = new List<Container>();
        list.Add(liquidContainer);
        list.Add(refrigiratedContainer);
        
        ship.AddContainer(gasContainer);
        ship.AddContainer(list);
        ship.ShowContainers();
        
        ship.DeleteContainer(liquidContainer);
        ship.ShowContainers();
        
        ship.AddContainer(new LiquidContainer(1000, 200, 4500, 500, 3000, false));
        ship.ShowContainers();

        Ship ship2 = new Ship("USCGC Alder", 45, 3, 5);
        ship.MoveContainerToAnotherShip(gasContainer, ship2);
        ship.ShowContainers();
        ship2.ShowContainers();
        
        ship2.ReplaceContainer("KON-G-1", liquidContainer);
        ship2.ShowContainers();
        
        ship.ShowInfo();
        ship2.ShowInfo();
    }
}