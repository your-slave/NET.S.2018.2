
using System.Linq;
using NET.S._2018.Karakouski._2;
using System.Diagnostics;
using System;

namespace FilterDigitsPerfomaceComparsion
{
    /// <summary>
    /// Compares perfomance of diffrent FilterDigit implimentations
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            int[] array = Enumerable.Range(1, 7_000_000).ToArray();
            sw.Start();
            DataManipulator.FilterDigit(array, 7);
            sw.Stop();
            Console.WriteLine(nameof(DataManipulator.FilterDigit) + " elapsed time: " + sw.ElapsedTicks);
            sw.Restart();
            DataManipulator.FilterDigit1(array, 7);
            sw.Stop();
            Console.WriteLine(nameof(DataManipulator.FilterDigit1) + " elapsed time: " + sw.ElapsedTicks);
            sw.Restart();
            DataManipulator.FilterDigit2(array, 7);
            sw.Stop();
            Console.WriteLine(nameof(DataManipulator.FilterDigit2) + " elapsed time: " + sw.ElapsedTicks);
            sw.Restart();
            DataManipulator.FilterDigit3(array, 7);
            sw.Stop();
            Console.WriteLine(nameof(DataManipulator.FilterDigit3) + " elapsed time: " + sw.ElapsedTicks);

            Console.ReadKey();
        }
    }
}
