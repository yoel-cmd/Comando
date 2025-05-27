using System;


namespace Comando
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Commando c = new Commando("yoel","yoel-cmd","walk");
            Weapon weapon = new Weapon("gun", "honda", 32);
            
            //Console.WriteLine(c.Status);
            c.SayName("colonel");
            //Console.WriteLine(c.NameKode);
            //Console.WriteLine(weapon.manufacturer);
            //Console.WriteLine(weapon.ammoCount);
            //Console.WriteLine(weapon.);

            c.Status = "up";

        }
    }
}
