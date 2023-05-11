using System;

namespace HomeWorkPlayer
{
    class Program
    {
        public void Main()
        {
            Player player1 = new Player(18, "ViCoffee","Man","Dwarf");

            player1.ShowInfo();
        }
    }

    class Player
    {
        private string _nickname;
        private string _gender;
        private string _gameClass;

        private int _age;

        public Player(int age, string nickname, string gender, string gameClass)
        {
            _nickname = nickname;
            _gender = gender;
            _gameClass = gameClass;
            _age = age;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Information about player:\nNickname is {_nickname}" +
                $"\nGender is {_gender}" +
                $"\nPlayer class is {_gameClass}" +
                $"\nAge is {_age} years old");
        }


    }
}
