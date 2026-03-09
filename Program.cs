using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть, будь ласка, кількість студентів у таблиці:");
        int numbers = int.Parse(Console.ReadLine()!);

        StudentsTable table = new StudentsTable(numbers);

        if(table.Count > 0)
        {
            table[0] = new Student("Ревун", "Єлизавета", "Андріївна");
        }

        for (int i = 1; i < table.Count; i++)
        {
            Console.WriteLine("Введіть дані студента:");

            Console.WriteLine("Ім'я: ");
            string firstName = Console.ReadLine()!;

            Console.WriteLine("Прізвище: ");
            string lastName = Console.ReadLine()!;

            Console.WriteLine("По батькові: ");
            string patronymic = Console.ReadLine()!;

            table[i] = new Student(lastName, firstName, patronymic);       
        }

        Console.WriteLine("Список студентів у таблиці:");
        for (int i = 0; i < table.Count; i++)
        {
            Student s = table[i];
            if (s != null)
                Console.WriteLine(s.GetInformation());
        }

        Console.Write("Введіть індекс студента, якого хочете змінити: ");
        int editIndex = int.Parse(Console.ReadLine()!);

        if (editIndex >= 0 && editIndex < table.Count && table[editIndex] != null)
        {
            Console.Write("Нове ім'я: ");
            string newFirst = Console.ReadLine()!;
            Console.Write("Нове прізвище: ");
            string newLast = Console.ReadLine()!;
            
            Console.Write("Нове по батькові: ");
            string newPatr = Console.ReadLine()!;

            table[editIndex].FirstName = newFirst;
            table[editIndex].LastName = newLast;
            table[editIndex].Patronymic = newPatr;
        }
        else
        {
            Console.WriteLine("Такого студента немає");
        }

        Console.WriteLine("Оновлений список студентів:");
        for (int i = 0; i < table.Count; i++)
        {
            Student s = table[i];
            if (s != null)
                Console.WriteLine(s.GetInformation());
        }

        Console.WriteLine("Кількість студентів у таблиці: " + table.Count);
    }
}