// LegendaryFort.cs
using System;

public class LegendaryFort
{
    public int level = 1;
    public string fortName = "حصن الفجر";
    public string weaponAppearance = "Spear of Light";
    public int upgradeCostGold = 5000;
    public int upgradeCostWood = 2500;

    // بناء الحصن
    public void BuildFort(int castleLevel, int gold, int wood)
    {
        if (castleLevel >= 15 && gold >= upgradeCostGold && wood >= upgradeCostWood)
        {
            level = 1;
            gold -= upgradeCostGold;
            wood -= upgradeCostWood;
            Console.WriteLine($"{fortName} built with weapon: {weaponAppearance}");
        }
        else
        {
            Console.WriteLine("Cannot build Legendary Fort.");
        }
    }

    // ترقية الحصن
    public void UpgradeFort(int gold, int wood)
    {
        if (gold >= upgradeCostGold && wood >= upgradeCostWood)
        {
            level++;
            gold -= upgradeCostGold;
            wood -= upgradeCostWood;
            Console.WriteLine($"{fortName} upgraded to level {level}. Weapon: {weaponAppearance}");
        }
    }

    // Developer Mode: بناء فوري
    public void BuildFortDev()
    {
        level = 10;
        Console.WriteLine($"[DevMode] {fortName} built instantly with weapon: {weaponAppearance}");
    }
}
