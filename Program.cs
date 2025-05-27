using System;


namespace Comando
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Commando c = new Commando("yoel","yoel-cmd","walk");
            Weapon weapon = new Weapon("gun", "honda", 32);
            
            
            //c.SayName("colonel");

            Console.WriteLine(c.NameKode);

            //c.Status = "up";

        }
    }
}
