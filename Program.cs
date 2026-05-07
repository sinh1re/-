namespace лаба_5
{
    class Program
    {
          static void Main(string[] args)
          {
                Console.WriteLine("Лабораторная работа 5");
                Console.WriteLine("Интеграция AI-инструментов");

                // Пример работы с AI (демонстрация)
                int a = 10;
                int b = 20;
                int sum = Add(a, b);

                Console.WriteLine($"Сумма {a} + {b} = {sum}");
                Console.WriteLine("Нажмите любую клавишу для выхода...");
                Console.ReadKey();
          }

         static int Add(int x, int y)
         {
                return x + y;
         }
    }
}
