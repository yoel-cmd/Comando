using System;

public class SeaCommando : Commando
{
    public string typeComander { get; set; } = "Can swim";
    //----------------------------------------------------------
    public SeaCommando(string name, string nameKode, string status) : base(name, nameKode, status)
    {
        
    }
    //----------------------------------------------------------
    public void print()
    {
        Console.WriteLine(typeComander);
    }
    //----------------------------------------------------------
    public override void Attack()
    {
        Console.WriteLine($"The soldier {nameKode} from SeaCommando is Attack");
    }
    //----------------------------------------------------------

}