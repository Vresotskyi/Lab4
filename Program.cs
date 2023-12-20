using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<string, string> бібліотека = new Dictionary<string, string>();

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        while (true)
        {
            Console.WriteLine("Оберіть опцію:");
            Console.WriteLine("1. Додати книгу");
            Console.WriteLine("2. Показати список книг");
            Console.WriteLine("3. Видалити книгу");
            Console.WriteLine("4. Вийти");

            string вибір = Console.ReadLine();

            switch (вибір)
            {
                case "1":
                    ДодатиКнигу();
                    break;
                case "2":
                    ПоказатиКниги();
                    break;
                case "3":
                    ВидалитиКнигу();
                    break;
                case "4":
                    Console.WriteLine("До побачення!");
                    return;
                default:
                    Console.WriteLine("Невірний вибір. Спробуйте знову.");
                    break;
            }
        }
    }

    static void ДодатиКнигу()
    {
        Console.WriteLine("Введіть назву книги:");
        string назва = Console.ReadLine();

        Console.WriteLine("Введіть автора:");
        string автор = Console.ReadLine();

        if (!бібліотека.ContainsKey(назва))
        {
            бібліотека[назва] = автор;
            Console.WriteLine("Книга успішно додана до бібліотеки!");
        }
        else
        {
            Console.WriteLine("Книга з такою назвою вже є у бібліотеці.");
        }
    }

    static void ПоказатиКниги()
    {
        Console.WriteLine("Список книг у бібліотеці:");

        if (бібліотека.Count == 0)
        {
            Console.WriteLine("У бібліотеці немає жодної книги.");
        }
        else
        {
            foreach (var книга in бібліотека)
            {
                Console.WriteLine($"Назва: {книга.Key}, Автор: {книга.Value}");
            }
        }
    }

    static void ВидалитиКнигу()
    {
        Console.WriteLine("Введіть назву книги, яку бажаєте видалити:");
        string назва = Console.ReadLine();

        if (бібліотека.ContainsKey(назва))
        {
            бібліотека.Remove(назва);
            Console.WriteLine("Книга успішно видалена з бібліотеки!");
        }
        else
        {
            Console.WriteLine("Книга з такою назвою не знайдена у бібліотеці.");
        }
    }
}
