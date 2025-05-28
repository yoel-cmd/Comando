using System;

public class Weapon
{
    public string nameWepon;
    public string manufacturer;
    public int ammoCount;
    //----------------------------------------------------------
    public Weapon(string name, string manufacturer, int ammoCount)
    {
        this.nameWepon = name;
        this.manufacturer = manufacturer;
        this.ammoCount = ammoCount;
    }
    //----------------------------------------------------------
    public void Shoot()
    {
        Console.WriteLine("shoot");
        ammoCount -= 1;
    }
    //----------------------------------------------------------
    public void printInfo()
    {
        Console.WriteLine("----- Weapon Info -----");
        Console.WriteLine($"Name         : {nameWepon}");
        Console.WriteLine($"Manufacturer : {manufacturer}");
        Console.WriteLine($"Ammo Count   : {ammoCount}");
        Console.WriteLine("------------------------");
    }

}