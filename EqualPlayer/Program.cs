using System;
using System.Collections.Generic;

namespace EqualPlayer
{
    public enum PlayerClass
    {
        Tank , Fighter , Slayer , Mage , Controller , Marksmen
    }
    public class Player
    {
        public PlayerClass PClass { get ; }
        public string Name { get ; }
        public Player( PlayerClass pClass , string name)
        {
            PClass = pClass ;
            Name = name;
        }
        public override int GetHashCode()
        {
            return PClass.GetHashCode()^Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return this.GetHashCode() == obj.GetHashCode();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Player> setOfPlayers = new HashSet<Player>();
            setOfPlayers.Add(new Player(PlayerClass.Tank, "Ana"));
            setOfPlayers.Add(new Player(PlayerClass.Slayer, "Paulo"));
            setOfPlayers.Add(new Player(PlayerClass.Tank, "Ana"));
            foreach (Player p in setOfPlayers)
            {
                Console.WriteLine ($"{p.Name} is a {p. PClass}" );
            }
        }
    }
}
