﻿using cwiczenia3.Exceptions;
using cwiczenia3.Interfaces;

namespace cwiczenia3.Containers;

public abstract class Container : IContainer
{
    protected static int number = 0;
    
    private int cargoWeight; //[kg]
    private int height; //[cm]
    private int containerWeight; //[kg]
    private int depth; //[cm]
    private string serialNumber; //[KON-C-1] C=rodzaj, 1=numer
    private int maxCargoWeight; //[kg]
    
    public int CargoWeight { get; protected set; }
    public int Height { get; protected set; }
    public int ContainerWeight { get; protected set; }
    public int Depth { get; protected set; }
    public string SerialNumber { get; protected set; }
    public int MaxCargoWeight { get; protected set; }

    protected Container(int cargoWeight, int height, int containerWeight, int depth, int maxCargoWeight)
    {
        CargoWeight = cargoWeight;
        Height = height;
        ContainerWeight = containerWeight;
        Depth = depth;
        SerialNumber = "KON-C";
        MaxCargoWeight = maxCargoWeight;
    }

    public virtual void Unload()
    {
        CargoWeight = 0;
    }

    public virtual void Load(int cargoWeight)
    {
        if ((CargoWeight + cargoWeight) <= MaxCargoWeight)
        {
            CargoWeight += cargoWeight;
            Console.WriteLine("Added cargo to container " + SerialNumber);
        }
        else
        {
            throw new OverfillException("Too heavy cargo. Unable to load.");
        }
    }

    public override string ToString()
    {
        return "Container "+ SerialNumber;
    }
}