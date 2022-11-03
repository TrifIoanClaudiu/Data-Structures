using System;

namespace EventsAndMulticastDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            AudioSystem audioSystem = new AudioSystem();
            RenderingEngine renderingEngine = new RenderingEngine();

            Player player1 = new Player("Bruno Fernandes");
            Player player2 = new Player("Cristiano Ronaldo");
            Player player3 = new Player("Paul Pogba");


            GameEventManager.TriggerGameStart();
            Console.WriteLine("Game is Running.... Press any key to end the game.");

            Console.Read();

            GameEventManager.TriggerGameOver();

        }
    }
}
