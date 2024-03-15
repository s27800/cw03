using cwiczenia3.Exceptions;
using cwiczenia3.Interfaces;

namespace cwiczenia3;

public abstract class Container : IContainer
{
    private int cargoWeight;
    public int CargoWeight { get; protected set; }

    protected Container(int cargoWeight)
    {
        CargoWeight = cargoWeight;
    }
    
    public void Unload()
    {
        throw new NotImplementedException();
    }

    public virtual void Load(int cargoWeight)
    {
        throw new OverfillException("Message1");
    }
}