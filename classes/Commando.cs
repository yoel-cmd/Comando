using System;

public class Commando
{
    public string Name;
    public string NameKode;
    public string[] Tools = { "Hammer", "Chisel", "Rope", "Bag", "Water bottle", };
    public string Status;

    //----------------------------------------------------------
    public Commando(string name,string nameKode,string status)
    {
        this.Name = name;
        this.NameKode = nameKode;
        this.Status = status;
    }
    //----------------------------------------------------------
    public void Walk()
    {
        Status = "Walk";
        Console.WriteLine("The soldier is leaving.");
    }
    //----------------------------------------------------------
    public void Hide()
    {
        Status = "Hide";
        Console.WriteLine("The soldier is Hide.");
    }
    //----------------------------------------------------------
    public void Attack()
    {
        Console.WriteLine($"The soldier{NameKode} is Attack");
    }
}