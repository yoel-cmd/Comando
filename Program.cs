using System;


namespace Comando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weapon weapon = new Weapon("gun", "honda", 32);

            Commando c = new Commando("yoel","yoel-cmd","walk");
            AirCommando airCommando = new AirCommando("inon", "llo", "singal");
            SeaCommando seaCommando = new SeaCommando("azur", "azurr", "walk");
            Commando[] commandoArr = { c, airCommando, seaCommando };

            foreach(Commando item in commandoArr)
            {
                item.Attack();
            }

            
            

           

        }
    }
}
