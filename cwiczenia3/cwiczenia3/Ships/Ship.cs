using cwiczenia3.Containers;

namespace cwiczenia3.Ships;

public class Ship
{
    private string name;
    private List<Container> containers;
    private int maxSpeed;
    private int maxNumberOfContainers;
    private double maxContainersWeight; //[T]
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

    public bool AddContainer(Container container)
    {
        if (
            (container.ContainerWeight + container.CargoWeight + (CurrentWeight*1000) <= (MaxContainersWeight*1000))
            && (Containers.Count + 1 <= MaxNumberOfContainers)
        )
        {
            Containers.Add(container);
            CurrentWeight += (double)(container.ContainerWeight + container.CargoWeight)/1000;
            Console.WriteLine("Added container " + container.SerialNumber + " to the ship.");
            return true;
        }
        else
        {
            Console.WriteLine("Unable to add container " + container.SerialNumber + " to the ship.");
        }

        return false;
    }

    public void AddContainer(List<Container> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            AddContainer(list[i]);
        }
    }

    public void DeleteContainer(Container container)
    {
        if (Containers.Contains(container))
        {
            CurrentWeight -= (container.CargoWeight + container.ContainerWeight);
            Containers.Remove(container);
            Console.WriteLine("Removed Container " + container.SerialNumber);
        }
        else
        {
            Console.WriteLine("Unable to find Container " + container.SerialNumber);
        }
    }

    public void MoveContainerToAnotherShip(Container container, Ship ship)
    {
        if (Containers.Contains(container))
        {
            if (ship.AddContainer(container))
            {
                Containers.Remove(container);
                Console.WriteLine("Moved Container "+ container.SerialNumber);
            }
            else
            {
                Console.WriteLine("Unable to move Container "+ container.SerialNumber);
            }
        }
        else
        {
            Console.WriteLine("Unable to find Container "+ container.SerialNumber);
        }
    }

    public void ReplaceContainer(string serialNumber, Container container)
    {
        bool found = false;
        for (int i = 0; i < Containers.Count && !found; i++)
        {
            if (Containers[i].SerialNumber == serialNumber)
            {
                if (AddContainer(container))
                {
                    string oldNumber = Containers[i].SerialNumber;
                    DeleteContainer(Containers[i]);
                    found = true;
                    Console.WriteLine("Replaced Container "+ oldNumber +" with "+ container.SerialNumber);
                }
            }
        }

        if (!found)
        {
            Console.WriteLine("Unable to replace Container " + serialNumber);
        }
    }

    public void ShowInfo()
    {
        Console.WriteLine("Ship "+ Name + "(max speed: "+MaxSpeed+", max number of containers: "+MaxNumberOfContainers+", max weight of containers: "+MaxContainersWeight+")");
        ShowContainers();
    }

    public void ShowContainers()
    {
        Console.WriteLine("Ship "+ Name + " containers:");
        for(int i=0; i<Containers.Count; i++)
        {
            Console.WriteLine(Containers[i]);
        }
    }
}