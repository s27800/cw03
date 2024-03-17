namespace cwiczenia3.Boats;

public class Ship
{
    private string name;
    private List<Container> containers;
    private int maxSpeed;
    private int maxNumberOfContainers;
    private double maxContainersWeight;
    private double currentWeight;
    
    public string Name { get; protected set; }
    public List<Container> Containers { get; protected set; }
    public int MaxSpeed { get; protected set; }
    public int MaxNumberOfContainers { get; protected set; }
    public double MaxContainersWeight { get; protected set; }
    public double CurrentWeight { get; protected set; }

    public Ship(int maxSpeed, int maxNumberOfContainers, double maxContainersWeight)
    {
        Containers = new List<Container>();
        MaxSpeed = maxSpeed;
        MaxNumberOfContainers = maxNumberOfContainers;
        MaxContainersWeight = maxContainersWeight;
        CurrentWeight = 0;
    }

    public void AddContainer(Container container)
    {
        if (
            (container.ContainerWeight + container.CargoWeight + CurrentWeight <= MaxContainersWeight)
            && (this.containers.Count + 1 <= MaxNumberOfContainers)
        )
        {
            this.containers.Add(container);
            Console.WriteLine("Added container " + container.SerialNumber + " to the ship.");
        }
        else
        {
            Console.WriteLine("Unable to add container " + container.SerialNumber + " to the ship.");
        }
    }
}