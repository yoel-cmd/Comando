using System;


namespace Comando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Weapon weapon = new Weapon("gun", "honda", 32);

            //Commando c = new Commando("yoel","yoel-cmd","walk");
            //AirCommando airCommando = new AirCommando("inon", "llo", "singal");
            //SeaCommando seaCommando = new SeaCommando("azur", "azurr", "walk");
            //Commando[] commandoArr = { c, airCommando, seaCommando };

            //foreach(Commando item in commandoArr)
            //{
            //    item.Attack();
            //}
            //EnemyFactory enemy = new EnemyFactory();
            //enemy.creatEnemy();


            //foreach (Enemy item in enemy.enemies)
            //{
            //    Console.WriteLine($"Terrorist Name: {item.name}");
            //    Console.WriteLine($"Health Level: {item.life}");
            //    Console.WriteLine($"Status: {item.status}");
            //    Console.WriteLine($"Shout: {item.shout}");
            //    Console.WriteLine(); 
            //}
            EnemyFactory enemyFactory = new EnemyFactory();
            SoliderFactory soliderFactory = new SoliderFactory();
            WeaponFactory weaponFactory = new WeaponFactory();
            enemyFactory.creatEnemy();
            soliderFactory.createCommando();
            weaponFactory.creatWeapon();
           








        }
    }
}
