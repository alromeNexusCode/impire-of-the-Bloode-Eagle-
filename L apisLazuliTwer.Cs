// LapisLazuliTower.cs
using System;

public class LapisLazuliTower
{
    public int level = 1;
    public string towerName = "برج اللازورد";
    public int productionRate = 50;
    public int maxStorage = 500;
    public int storedLazuli = 0;
    public int upgradeCostGold = 8000;
    public int upgradeCostWood = 4000;

    // بناء البرج
    public void BuildTower(int castleLevel, int gold, int wood)
    {
        if (castleLevel >= 30 && gold >= upgradeCostGold && wood >= upgradeCostWood)
        {
            level = 1;
            storedLazuli = 0;
            gold -= upgradeCostGold;
            wood -= upgradeCostWood;
            Console.WriteLine($"{towerName} built! Produces {productionRate}/h");
        }
        else
        {
            Console.WriteLine("Cannot build Lapis Lazuli Tower.");
        }
    }

    // ترقية البرج
    public void UpgradeTower(int gold, int wood)
    {
        if (gold >= upgradeCostGold && wood >= upgradeCostWood)
        {
            level++;
            productionRate += 25;
            maxStorage += 200;
            gold -= upgradeCostGold;
            wood -= upgradeCostWood;
            Console.WriteLine($"{towerName} upgraded to level {level}. Rate: {productionRate}/h");
        }
    }

    // جمع اللازورد
    public void CollectLazuli()
    {
        int collected = Math.Min(productionRate, maxStorage - storedLazuli);
        storedLazuli += collected;
        Console.WriteLine($"Collected {collected} Lazuli. Total: {storedLazuli}");
    }

    // Developer Mode: البناء الكامل مع تخزين كامل
    public void BuildTowerDev()
    {
        level = 10;
        storedLazuli = maxStorage;
        Console.WriteLine($"[DevMode] {towerName} built with full Lazuli!");
    }
}
