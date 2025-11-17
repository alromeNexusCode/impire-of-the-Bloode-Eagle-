// Player.cs
using System;
using System.Collections.Generic;

public class Player
{
    public string name;
    public ResourceManager resources;
    public List<Weapon> weapons;
    public LegendaryFort fort;
    public LapisLazuliTower tower;
    public DefenseManager defense;
    public RareItemManager rareItems;

    public Player(string playerName)
    {
        name = playerName;
        resources = new ResourceManager();
        weapons = new List<Weapon>();
        fort = new LegendaryFort();
        tower = new LapisLazuliTower();
        defense = new DefenseManager();
        rareItems = new RareItemManager();
    }

    // عرض حالة اللاعب الأساسية
    public void ShowStatus()
    {
        Console.WriteLine($"Player: {name}");
        resources.ShowResources();
        Console.WriteLine($"Weapons count: {weapons.Count}");
        Console.WriteLine($"Fort level: {fort.level}, Tower level: {tower.level}");
        Console.WriteLine($"Defense shield level: {defense.shieldLevel}");
    }
}
