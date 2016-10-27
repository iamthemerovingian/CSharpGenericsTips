using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipsProject
{
    public static class StringExtensions
    {
        public static TEnum ParseEnum<TEnum>(this string value) where TEnum: struct
        {
            return (TEnum)Enum.Parse(typeof(TEnum), value);
        }
    }
    class Program
    {
        public enum Steps
        {
            Step1,
            Step2,
            Step3
        }
       
        static void Main(string[] args)
        {
            //var input = "Step1";

            //var value = input.ParseEnum<Steps>();

            //Console.WriteLine(value);

            ////Steps value = (Steps)Enum.Parse(typeof(Steps), input);
            //var numbers = new double[] { 1, 2, 3, 4, 5, 6 };
            //var result = SimpledAverage(numbers);
            //Console.WriteLine(result);


            //var list = new List<Item>();

            //list.Add(new Item<int>());
            //list.Add(new Item<double>());

            var a = new Item();
            var b = new Item();
            var c = new Item();

            Console.WriteLine(Item.InstanCount);

             a = new Item<int>();
             b = new Item<string>();
             c = new Item<string>();

            Console.WriteLine(Item<string>.InstanCount);
            Console.WriteLine(Item<int>.InstanCount);
        }

        public class Item<T> : Item
        {
            public static new int InstanCount;

            public Item()
            {
                InstanCount++;
            }
        }

        public class Item
        {
            public static int InstanCount;

            public Item()
            {
                InstanCount++;
            }
        }


        private static double SimpledAverage(double[] numbers)
        {
            var count = 0;
            var sum = 0.0;

            for (int i = 0; i < numbers.Length; i += 2)
            {
                sum += numbers[i];
                count += 1;
            }
            return sum/count;
        }
    }
}
