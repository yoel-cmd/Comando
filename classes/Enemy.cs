using System;

public class Enemy
{
    public string name { get; set; }
    public int life { get; set; } = 100;
    public bool tatus { get; set; } = true;
    public string shout { get; } = "I am an enemy.";
    //----------------------------------------------------------
    public Enemy(string name)
    {
        this.name = name;
    }
    //----------------------------------------------------------
    public void printInfo()
    {
        Console.WriteLine("----- Enemy Info -----");
        Console.WriteLine($"Name  : {name}");
        Console.WriteLine($"Life  : {life}");
        Console.WriteLine($"Status: {(tatus ? "Alive" : "Dead")}");
        Console.WriteLine($"Shout : \"{shout}\"");
        Console.WriteLine("----------------------");
    }
}