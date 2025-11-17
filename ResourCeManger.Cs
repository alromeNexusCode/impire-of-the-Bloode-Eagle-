// ResourceManager.cs
using System;

public class ResourceManager
{
    public int gold = 10000;
    public int wood = 8000;
    public int food = 5000;
    public int copper = 3000;

    // تطبيق استراتيجية توفير الموارد 5%
    public int ApplyResourceSaving(int cost)
    {
        return (int)(cost * 0.95);
    }

    // استخدام الموارد للبناء أو البحث
    public bool UseResources(int g, int w, int f, int c)
    {
        g = ApplyResourceSaving(g);
        w = ApplyResourceSaving(w);
        f = ApplyResourceSaving(f);
        c = ApplyResourceSaving(c);

        if (gold >= g && wood >= w && food >= f && copper >= c)
        {
            gold -= g;
            wood -= w;
            food -= f;
            copper -= c;
            return true;
        }

        Console.WriteLine("Not enough resources.");
        return false;
    }

    // Developer Mode: الموارد لا تخصم
    public void UseResourcesDev()
    {
        Console.WriteLine("[DevMode] Resources not deducted.");
    }

    // عرض الموارد الحالية
    public void ShowResources()
    {
        Console.WriteLine($"Gold: {gold}, Wood: {wood}, Food: {food}, Copper: {copper}");
    }
}
