using System;

namespace biography
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string surname;
            string date;
            int age;
            string zodiac;
            string work;
            string profession;
            string hobby;

            Console.Write("Введите ваше имя:");
            name = Console.ReadLine();
            Console.Write("Введите вышу фамилию:");
            surname = Console.ReadLine();
            Console.Write("Когда вы родились:");
            date = Console.ReadLine();
            Console.Write("Сколько вам полных лет:");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите ваш знак зодиака:");
            zodiac = Console.ReadLine();
            Console.Write("Где вы работаете:");
            work = Console.ReadLine();
            Console.Write("Кем вы работаете:");
            profession = Console.ReadLine();
            Console.Write("Какое ваше хобби:");
            hobby = Console.ReadLine();

            Console.Write($"Ваше имя и фамилия - {name} {surname}. Вы родились {date} и вам {age} полных лет.По знаку зодиака вы - {zodiac}." +
                $" Ваша профессия - {profession} и вы работаете в {work}. А ваше любимое занятие {hobby}.");




        }
    }
}
