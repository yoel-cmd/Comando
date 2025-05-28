using System;

public class AirCommando : Commando
{
    public string typeComander { get; set; } = "Can fall";

    //----------------------------------------------------------
    public AirCommando(string name, string nameKode, string status) :base( name, nameKode, status) 
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
        Console.WriteLine($"The soldier{nameKode} from AirCommand  is Attack");
    }
    //----------------------------------------------------------


}
