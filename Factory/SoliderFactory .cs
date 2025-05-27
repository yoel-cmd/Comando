using System;
using System.Collections.Generic;

public class CommandoFactory
{
    public List<Commando> commandos = new List<Commando>();
    //----------------------------------------------------------
    string[] soldierNames = new string[]
    {
    "John Miller", "James Anderson", "Robert Jackson", "Michael Davis", "William Harris",
    "David Thompson", "Joseph White", "Charles Martin", "Thomas Lewis", "Daniel Walker",
    "Matthew Hall", "Anthony Allen", "Mark Young", "Steven King", "Andrew Scott",
    "Joshua Green", "Kevin Adams", "Brian Baker", "Jason Wright", "Eric Nelson"
    };
    string[] codeNames = new string[]
    {
    "IronWolf", "GhostStrike", "FalconEye", "ShadowBlade", "NightStorm",
    "SteelViper", "EchoHawk", "CrimsonFox", "PhantomZero", "BlackHornet",
    "SilverFang", "RogueEagle", "ThunderFist", "ViperGhost", "CobraClaw",
    "DeltaShade", "BlazeRaven", "StormTiger", "AlphaFrost", "RapidSpecter"
    };
    string[] statusRandom = { "Standing", "walking", "hiding" };
    Random rnd = new Random();
    public void createCommando()
    {
        int num = rnd.Next(1, 2);
        for (int i = 0; i < 10; i++)
        {
            string name = soldierNames[rnd.Next(0, soldierNames.Length)];
            string nameKode = codeNames[rnd.Next(0, codeNames.Length)];
            string status = statusRandom[rnd.Next(0, statusRandom.Length)];
            if (num == 1)
            {
                commandos.Add(new AirCommando(name, nameKode, status));
            }
            else
            {
                commandos.Add(new SeaCommando(name, nameKode, status));
            }
        }
    }
}