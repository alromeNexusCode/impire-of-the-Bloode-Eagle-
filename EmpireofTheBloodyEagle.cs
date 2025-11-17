// EmpireOfTheBloodyEagle.cs
using System;
using System.Collections.Generic;

public class EmpireOfTheBloodyEagle
{
    public List<Player> players = new List<Player>();
    public MarketManager market = new MarketManager();
    public GlabaModeManager glabaMode = new GlabaModeManager();
    public GlabaGiftManager giftManager = new GlabaGiftManager();
    public ChatManager chat = new ChatManager();
    public PrisonManager prison = new PrisonManager();

    // إضافة لاعب جديد
    public void AddPlayer(string playerName)
    {
        Player p = new Player(playerName);
        players.Add(p);
        Console.WriteLine($"{playerName} joined Empire of the Bloody Eagle!");
    }

    // تجربة جميع الأنظمة Offline
    public void TestAllSystems()
    {
        Console.WriteLine("Activating Developer Mode for Glaba...");
        glabaMode.ActivateDevMode();

        Console.WriteLine("Building Legendary Fort for first player...");
        players[0].fort.BuildFortDev();

        Console.WriteLine("Building Lapis Lazuli Tower for first player...");
        players[0].tower.BuildTowerDev();

        Console.WriteLine("Giving rare items...");
        players[0].rareItems.GiveAllRareItemsDev();

        Console.WriteLine("Testing weapon bonuses...");
        Weapon sword = new Weapon("Sword of Glory", 100, true);
        players[0].weapons.Add(sword);
        sword.WeaponDev();

        Console.WriteLine("Testing trade...");
        market.AddPlayer(players[0].name);
        market.TradeResourcesDev(players[0].name, players[0].name, "Gold", 500);

        Console.WriteLine("Testing chat...");
        chat.SendGlobalMessage(players[0].name, "Hello World!");
        chat.SendAllianceMessage(players[0].name, "RedAlliance", "Attack now!");

        Console.WriteLine("Testing prison...");
        prison.Imprison(players[0].name);
        prison.Release(players[0].name);
    }
}
