﻿using cwiczenia3.Interfaces;

namespace cwiczenia3.Containers;

public class GasContainer : Container, IHazardNotifier
{
    private int pressure; //[atm]
    
    public int Pressure { get; protected set; }
    
    public GasContainer(int cargoWeight, int height, int containerWeight, int depth, int maxCargoWeight, int pressure) : base(cargoWeight, height, containerWeight, depth, maxCargoWeight)
    {
        SerialNumber = "KON-G-" + ++number;
        Pressure = pressure;
        Console.WriteLine("Created gas container.");
    }

    public override void Unload()
    {
        CargoWeight = (int) (0.05 * CargoWeight);
    }

    public override void Load(int cargoWeight)
    {
        if(CargoWeight + cargoWeight > MaxCargoWeight)
            SendMesssage();
        base.Load(cargoWeight);
    }

    public void SendMesssage()
    {
        Console.WriteLine("Dangerous situation in container " + SerialNumber);
    }

    public override string ToString()
    {
        return "Gas Container "+ SerialNumber;
        
    }
}