using cwiczenia3.Containers;

namespace cwiczenia3.Ships;

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

    public Ship(string name, int maxSpeed, int maxNumberOfContainers, double maxContainersWeight)
    {
        Name = name;
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
            && (Containers.Count + 1 <= MaxNumberOfContainers)
        )
        {
            Containers.Add(container);
            Console.WriteLine("Added container " + container.SerialNumber + " to the ship.");
        }
        else
        {
            Console.WriteLine("Unable to add container " + container.SerialNumber + " to the ship.");
        }
    }

    public void AddContainer(List<Container> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            AddContainer(list[i]);
        }
    }

    public void ShowContainers()
    {
        Console.WriteLine("Ship "+ Name + ":");
        for(int i=0; i<Containers.Count; i++)
        {
            Console.WriteLine(Containers[i]);
        }
    }
}