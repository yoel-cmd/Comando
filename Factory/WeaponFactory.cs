using System;
using System.Collections.Generic;

public class WeaponFactory
{
    public List<Weapon> weapons = new List<Weapon>();
    //-----------------------------------------------------------------------------------------------------------
    Random rnd = new Random();
    string[] weaponNames = new string[]
    {
    "Stormbreaker",
    "Night Fang",
    "Iron Claw",
    "Shadow Blaster",
    "Thunder Spike"
    };
    //-----------------------------------------------------------------------------------------------------------
    string[] weaponManufacturers = new string[]
    {
    "BlackForge Arms",
    "CrimsonTech",
    "IronShield Industries",
    "NovaCore Systems",
    "Titan Armaments"
    };
    //------------------------------------------------------------------------------------------------------------
    int[] weaponAmmoCounts = new int[]
    {
    12,24,8,50,16
    };
    //------------------------------------------------------------------------------------------------------------
    public void creatWeapon()
    {
        for (int i = 0; i < 10; i++)
        {
            string name = weaponNames[rnd.Next(0, weaponNames.Length)];
            string manufacturer = weaponManufacturers[rnd.Next(0, weaponManufacturers.Length)];
            int ammoCount = weaponAmmoCounts[rnd.Next(0, weaponAmmoCounts.Length)];

            weapons.Add(new Weapon(name, manufacturer, ammoCount));
        }
    }
    //---------------------------------------------------------------------------------------------------------
    public void addWeapon(string name, string manufacturer, int ammoCount)
    {
        weapons.Add(new Weapon(name, manufacturer, ammoCount));
    }


}