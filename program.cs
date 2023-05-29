using System;

namespace JewelCollector
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jewel Collector 2.0");

            Game game = new Game(5); // Tamanho inicial do mapa (5x5)
            game.Start();

            Console.WriteLine("Game Over");
        }
    }
}
