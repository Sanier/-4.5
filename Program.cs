using System;

namespace Практикум_4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            (string Name, string LastName, string Login, int LoginLenght, bool HasPet, string[] favcolors, double Age) User;

            Console.WriteLine("Введите имя");
            User.Name = Console.ReadLine();

            Console.WriteLine("Введите фамилию");
            User.LastName = Console.ReadLine();

            Console.WriteLine("Введите логин");
            User.Login = Console.ReadLine();
        }
    }
}
