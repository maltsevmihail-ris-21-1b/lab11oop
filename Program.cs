using System.Collections;
using System.Diagnostics;

namespace OOP__lab11
{
    public class Program
    {
        public static Random rnd = new Random();
        static void Main(string[] args)
        {
            bool isContains = false;
            int size = 1000000;

            int first = 0;
            int last = size - 1;
            int middle = size / 2;
            int notContains = size;

            var testCollections = new TestCollections(size);

            var stopwatch = new Stopwatch();

            stopwatch.Start();

            isContains = testCollections.Collection1.Contains(new Engine(first));
            Console.WriteLine("Первый элемент в коллекции 1: " + stopwatch.ElapsedTicks);
            Console.WriteLine($"Результат: {isContains}");
            stopwatch.Restart();
            isContains = testCollections.Collection1.Contains(new Engine(middle));
            Console.WriteLine("Средний элемент в коллекции 1: " + stopwatch.ElapsedTicks);
            Console.WriteLine($"Результат: {isContains}");
            stopwatch.Restart();
            isContains = testCollections.Collection1.Contains(new Engine(last));
            Console.WriteLine("Последний элемент в коллекции 1: " + stopwatch.ElapsedTicks);
            Console.WriteLine($"Результат: {isContains}");
            stopwatch.Restart();
            isContains = testCollections.Collection1.Contains(new Engine(notContains));            
            Console.WriteLine("Отсутствующий элемент в коллекции 1: " + stopwatch.ElapsedTicks);
            Console.WriteLine($"Результат: {isContains}\n");
            stopwatch.Restart();

            isContains = testCollections.Collection2.Contains((new Engine(first).ToString()));
            Console.WriteLine("Первый элемент в коллекции 2: " + stopwatch.ElapsedTicks);
            Console.WriteLine($"Результат: {isContains}");
            stopwatch.Restart();
            isContains = testCollections.Collection2.Contains((new Engine(middle).ToString()));
            Console.WriteLine("Средний элемент в коллекции 2: " + stopwatch.ElapsedTicks);
            Console.WriteLine($"Результат: {isContains}");
            stopwatch.Restart();
            isContains = testCollections.Collection2.Contains((new Engine(last).ToString()));
            Console.WriteLine("Последний элемент в коллекции 2: " + stopwatch.ElapsedTicks);
            Console.WriteLine($"Результат: {isContains}");
            stopwatch.Restart();
            isContains = testCollections.Collection2.Contains((new Engine(notContains).ToString()));            
            Console.WriteLine("Отсутствующий элемент в коллекции 2: " + stopwatch.ElapsedTicks);
            Console.WriteLine($"Результат: {isContains}\n");
            stopwatch.Restart();

            isContains = testCollections.Collection3.ContainsKey(new Engine(first));
            Console.WriteLine("Первый элемент по ключу в коллекции 3: " + stopwatch.ElapsedTicks);
            Console.WriteLine($"Результат: {isContains}");
            stopwatch.Restart();
            isContains = testCollections.Collection3.ContainsKey(new Engine(2));
            Console.WriteLine("Средний элемент по ключу в коллекции 3: " + stopwatch.ElapsedTicks);
            Console.WriteLine($"Результат: {isContains}");
            stopwatch.Restart();
            isContains = testCollections.Collection3.ContainsKey(new Engine(last));
            Console.WriteLine("Последний элемент по ключу в коллекции 3: " + stopwatch.ElapsedTicks);
            Console.WriteLine($"Результат: {isContains}");
            stopwatch.Restart();
            isContains = testCollections.Collection3.ContainsKey(new Engine(notContains));
            Console.WriteLine("Отсутвующий элемент по ключу в коллекции 3: " + stopwatch.ElapsedTicks);
            Console.WriteLine($"Результат: {isContains}\n");
            stopwatch.Restart();

            isContains = testCollections.Collection4.ContainsKey((new InternalCombustionEngine(first, first).BaseEngine).ToString());
            Console.WriteLine("Первый элемент по ключу в коллекции 4: " + stopwatch.ElapsedTicks);
            Console.WriteLine($"Результат: {isContains}");
            stopwatch.Restart();
            isContains = testCollections.Collection4.ContainsKey((new InternalCombustionEngine(middle, middle).BaseEngine).ToString());
            Console.WriteLine("Средний элемент по ключу в коллекции 4: " + stopwatch.ElapsedTicks);
            Console.WriteLine($"Результат: {isContains}");
            stopwatch.Restart();
            isContains = testCollections.Collection4.ContainsKey((new InternalCombustionEngine(last, last).BaseEngine).ToString());
            Console.WriteLine("Последний элемент по ключу в коллекции 4: " + stopwatch.ElapsedTicks);
            Console.WriteLine($"Результат: {isContains}");
            stopwatch.Restart();
            isContains = testCollections.Collection4.ContainsKey((new InternalCombustionEngine(notContains, notContains).BaseEngine).ToString());
            Console.WriteLine("Отсутвующий элемент по ключу в коллекции 4: " + stopwatch.ElapsedTicks);
            Console.WriteLine($"Результат: {isContains}\n");
            stopwatch.Restart();

            isContains = testCollections.Collection3.ContainsValue(new InternalCombustionEngine(first, first));
            Console.WriteLine("Первый элемент по значению в коллекции 3: " + stopwatch.ElapsedTicks);
            Console.WriteLine($"Результат: {isContains}");
            stopwatch.Restart();
            isContains = testCollections.Collection3.ContainsValue(new InternalCombustionEngine(middle, middle));
            Console.WriteLine("Средний элемент по значению в коллекции 3: " + stopwatch.ElapsedTicks);
            Console.WriteLine($"Результат: {isContains}");
            stopwatch.Restart();
            isContains = testCollections.Collection3.ContainsValue(new InternalCombustionEngine(last, last));
            Console.WriteLine("Последний элемент по значению в коллекции 3: " + stopwatch.ElapsedTicks);
            Console.WriteLine($"Результат: {isContains}");
            stopwatch.Restart();
            isContains = testCollections.Collection3.ContainsValue(new InternalCombustionEngine(notContains, notContains));
            Console.WriteLine("Отсутвующий элемент по значению в коллекции 3: " + stopwatch.ElapsedTicks);
            Console.WriteLine($"Результат: {isContains}");

            stopwatch.Stop();
        }
    }
}
