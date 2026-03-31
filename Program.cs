using System;

namespace BseLr1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторна робота №1");
            Console.WriteLine("Виконала: Головко Єлизавета, група ПЗПІ-25-3");

            // Вхідні дані для розрахунку
            int a = 10;
            int b = 5;

            // Виклик функції суми з обробкою помилок переповнення
            int? result = Sum(a, b);

            if (result.HasValue)
            {
                Console.WriteLine($"Результат суми (AI-код): {result.Value}");
            }
            else
            {
                Console.WriteLine("Помилка: Переповнення при обчисленні суми!");
            }
        }

        /// <summary>
        /// Функція, що обчислює суму двох чисел з перевіркою на переповнення.
        /// </summary>
        /// <param name="a">Перше число</param>
        /// <param name="b">Друге число</param>
        /// <returns>Сума чисел, або null у разі переповнення</returns>
        public static int? Sum(int a, int b)
        {
            try
            {
                // Використовуємо checked для виявлення переповнення типу int
                checked
                {
                    return a + b;
                }
            }
            catch (OverflowException)
            {
                // Повертаємо null, якщо результат виходить за межі допустимих значень
                return null;
            }
        }
    }
}