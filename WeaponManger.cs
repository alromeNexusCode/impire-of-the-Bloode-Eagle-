// WeaponManager.cs
using System;

public class Weapon
{
    public string weaponName;
    public int baseDamage;
    public bool isLegendary;
    public int finalDamage;

    public Weapon(string name, int dmg, bool legendary = false)
    {
        weaponName = name;
        baseDamage = dmg;
        isLegendary = legendary;
        ApplyDamageBonus();
    }

    // تطبيق زيادة 5%، إضافية للسلاح الأسطوري
    public void ApplyDamageBonus()
    {
        finalDamage = (int)(baseDamage * 1.05);
        if (isLegendary)
            finalDamage = (int)(finalDamage * 1.05);
        Console.WriteLine($"{weaponName} damage: {finalDamage} (Legendary: {isLegendary})");
    }

    // Developer Mode: زيادة القوة مؤقتًا
    public void WeaponDev()
    {
        finalDamage = baseDamage * 2;
        Console.WriteLine($"[DevMode] {weaponName} damage boosted to {finalDamage}");
    }
}
