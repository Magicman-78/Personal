namespace Structs_and_enums
{

    internal class Program
    {
        struct PlayerData
        {
            public string name;
            public bool isAlive;
            public DateTime lastEdited;
            public DateTime whenCreated;
        }

        struct Stats
        {
            public int health;
            public float mana;
            public float attack;
            public float defense;
            public float speed;
        }
        static void Main(string[] args)
        {
            Stats player1Stats = new()
            {
                health = 10,
                mana = 5,
                attack = 4,
                defense = 3,
                speed = 6
            };

            PlayerData player1 = new()
            {
                name = "Derek the Monarch",
                whenCreated = DateTime.Now,
                lastEdited = DateTime.Now
            };

            Console.WriteLine(player1.name);
            Console.WriteLine(player1.isAlive);
            Console.WriteLine(player1.lastEdited);

            Stats player2Stats = new()
            {
                health = 15,
                mana = 3,
                attack = 5,
                defense = 7,
                speed = 2
            };

            PlayerData player2 = new()
            {
                name = "Keira the Queen",
                whenCreated = DateTime.Now,
                lastEdited = DateTime.Now
            };

            Console.WriteLine(player2.name);
            Console.WriteLine(player2.isAlive);
            Console.WriteLine(player2.lastEdited);
        }

        static void PrintPlayerName()
        {
            
        }
    }
}
