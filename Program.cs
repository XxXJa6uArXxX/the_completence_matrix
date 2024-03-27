using System;

class Program
{
    static void Main()
    {
        // Инициализация 5 предопределённых массивов со статичными значениями.
        int[][] arrays = new int[][]
        {
            new int[] {2, 3, 4, 0, 1, 3, 3, 1, 4, 3, 5, 4, 2, 5, 0},
            new int[] {2, 2, 5, 0, 1, 3, 3, 1, 2, 3, 3, 3, 3, 4, 0},
            new int[] {3, 4, 3, 0, 2, 5, 3, 3, 3, 2, 4, 5, 2, 4, 1},
            new int[] {4, 1, 1, 3, 5, 3, 5, 3, 5, 5, 4, 3, 4, 3, 4},
            new int[] {3, 2, 3, 3, 4, 3, 5, 2, 4, 4, 3, 3, 4, 2, 4},
        };
        int[] userArray = new int[15];

        string[] names = new string[] {"Экстраверт", "Интроверт", "Способность к монотонной работе", "Наставничество", "Организаторские способности",
"Критическое мышление", "Многозадачность", "Креативность", "Стрессоустойчивость", "Контроль времени", "Работа с большим объемом информации", "Аналитические навыки", 
"Эмпатия", "Любопытство", "Ораторское искусство"};
        
        string[] arr = new string[] {"Программист", "Тестировщик", "Аналитик", "Проджект-менеджер", "Продакт-менеджер"};

        
        for (int i = 0; i < userArray.Length; i++)
        {
            Console.WriteLine($"Введите значение для элемента {names[i]} (от 0 до 5):");
            // Чтение и проверка ввода пользователя.
            int value;
            while (!int.TryParse(Console.ReadLine(), out value) || value < 0 || value > 5)
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите число от 0 до 5:");
            }
            userArray[i] = value;
        }

        // Добавление пользовательского массива в список массивов
        Array.Resize(ref arrays, arrays.Length + 1);
        arrays[arrays.Length - 1] = userArray;
        // Вывод всех массивов
        for (int i = 0; i < arrays.Length; i++)
        {
            Console.WriteLine($"Максимальное число портрета '{arr[i]}': {string.Join(", ", arrays[i])}");
        }

        // Подсчет и вывод суммы каждого массива
        foreach (var array in arrays)
        {
            int sum = 0;
            foreach (var item in array)
            {
                sum += item;
            }
            Console.WriteLine($"Сумма элементов: {sum}");
        }
    }
}