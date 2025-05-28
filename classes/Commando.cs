using System;

public class Commando
{
    public string name;
    public string nameKode { get; set; }
    public string[] tools = { "Hammer", "Chisel", "Rope", "Bag", "Water bottle", };
    public string status;

    //----------------------------------------------------------
    public Commando(string name, string nameKode, string status)
    {
        this.name = name;
        this.nameKode = nameKode;
        this.status = status;
    }
    //----------------------------------------------------------
    public void Walk()
    {
        status = "Walk";
        Console.WriteLine("The soldier is leaving.");
    }
    //----------------------------------------------------------
    public void Hide()
    {
        status = "Hide";
        Console.WriteLine("The soldier is Hide.");
    }
    //----------------------------------------------------------
    public virtual void Attack()
    {
        Console.WriteLine($"The soldier {nameKode} is Attack");
    }
    //----------------------------------------------------------
    public void Sayname(string commanderRank)
    {
        if (commanderRank == "GENERAL".ToLower())
        {
            Console.WriteLine(name);
        }
        else if (commanderRank == "COLONEL".ToLower())
        {
            Console.WriteLine(nameKode);
        }
        else
        {
            Console.WriteLine("Classified information");
        }
    }
    //----------------------------------------------------------
    public void printInfo()
    {
        Console.WriteLine("----- Commando Info -----");
        Console.WriteLine($"Name       : {name}");
        Console.WriteLine($"Code Name  : {nameKode}");
        Console.WriteLine($"Status     : {status}");
        Console.WriteLine("Tools      :");

        foreach (string tool in tools)
        {
            Console.WriteLine($"  - {tool}");
        }

        Console.WriteLine("--------------------------");
    }

}