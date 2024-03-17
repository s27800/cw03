namespace cwiczenia3;

public class RefrigiratedContainer : Container
{
    private string type;
    private double temperature;
    
    public string Type { get; protected set; }
    public double Temperature { get; protected set; }
    
    public RefrigiratedContainer(int cargoWeight, int height, int containerWeight, int depth, string serialNumber, int maxCargoWeight, string type, double temperature) : base(cargoWeight, height, containerWeight, depth, serialNumber, maxCargoWeight)
    {
        Type = type;
        Temperature = temperature;

        switch (type)
        {
            case "Bananas":
                if (Temperature < 13.3)
                {
                    Temperature = 13.3;
                    WrongTemperature();
                }
                break;
            case "Chocolate":
                if(Temperature < 18)
                {
                    Temperature = 18;
                    WrongTemperature();
                }
                break;
            case "Fish":
                if(Temperature < 2)
                {
                    Temperature = 2;
                    WrongTemperature();
                }
                break;
            case "Meat":
                if(Temperature < -15)
                {
                    Temperature = -15;
                    WrongTemperature();
                }
                break;
            case "Ice cream":
                if(Temperature < -18)
                {
                    Temperature = -18;
                    WrongTemperature();
                }
                break;
            case "Frozen pizza":
                if(Temperature < -30)
                {
                    Temperature = -30;
                    WrongTemperature();
                }
                break;
            case "Cheese":
                if(Temperature < 7.2)
                {
                    Temperature = 7.2;
                    WrongTemperature();
                }
                break;
            case "Sausages":
                if(Temperature < 5)
                {
                    Temperature = 5;
                    WrongTemperature();
                }
                break;
            case "Butter":
                if(Temperature < 20.5)
                {
                    Temperature = 20.5;
                    WrongTemperature();
                }
                break;
            case "Eggs":
                if(Temperature < 19)
                {
                    Temperature = 19;
                    WrongTemperature();
                }
                break;
            default:
                Console.WriteLine("Wrong type of food for Refrigirated Container.");
                break;
        }
        Console.WriteLine("Created refrigirated container.");
    }

    public void WrongTemperature()
    {
        Console.WriteLine("Wrong temperature for " + Type + ". Changed temperature to " + Temperature + ".");
    }
}