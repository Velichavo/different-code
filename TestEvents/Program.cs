using System;
using TestEvents.Tank;

namespace TestEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            TankPlayer tP = new TankPlayer();
            char key = ' ';
            while (((ConsoleKey)key) != ConsoleKey.Escape)
            {
                key = tP.Key;
                //Console.WriteLine(key);
                tP.Update();
            }
            
        }
    }
}
