using System;

namespace HomeWorkPlayer
{
    class Program
    {
        static void Main()
        {
            Player player1 = new Player(18, "ViCoffee","Man","Dwarf");

            player1.ShowInfo();
        }
    }

    class Player
    {
        public string Nickname;
        public string Gender;
        public string PlayerClass;

        public int Age;

        public Player(int age, string nickname, string gender, string playerClass)
        {
            Nickname = nickname;
            Gender = gender;
            PlayerClass = playerClass;
            Age = age;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Information about player:\nNickname is {Nickname}" +
                $"\nGender is {Gender}" +
                $"\nPlayer class is {PlayerClass}" +
                $"\nAge is {Age} years old");
        }
    }
}
