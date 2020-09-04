using System;
using System.Collections.Generic;
namespace Basic_13
{
    class Program
    {
        public static void PrintNumbers()
        {
            for (int i = 0; i <= 255; i++){
                Console.WriteLine(i);
            }
        }
        public static void PrintOdds()
        {
            for (int i = 0; i <= 255; i++){
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void PrintSum()
        {
            var sum = 0;
            for (int i = 0; i <= 255; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine(sum+=i);
            }
        }
        public static void LoopArray(int[] numbers)
        {
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        public static int FindMax(int[] numbers)
        {
            var max = numbers[0];
            for (var value = 0; value < numbers.Length; value++)
            {
                if ((int)numbers[value] > max)
                {
                    max = numbers[value];
                }
            }
            Console.WriteLine(max);
            return max;
        }
        public static void GetAverage(int[] numbers)
        {
            var sum = 0;
            for (int i = 0; i<numbers.Length; i++)
            {
                sum += numbers[i];
            }
            var avg = sum/(numbers.Length);
            Console.WriteLine(avg);
        }
        public static int[] OddArray()
        {
            List<int> odd_list = new List <int>();
            for (int i = 0; i <= 255; i++)
            {
                if (i % 2 != 0)
                {
                    odd_list.Add(i);
                }
            }
            int[] odd_array = new int[odd_list.Count];
            for (var j = 0; j < odd_list.Count; j++)
            {
                odd_array[j] = odd_list[j];
                Console.WriteLine(odd_array[j]);
            }
            // Console.WriteLine(odd_array);
            return odd_array;
        }   
        public static int GreaterThanY(int[] numbers, int y)
        {
            var count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if ((int)numbers[i] > y)
                {
                    count +=1;
                }
            }
            Console.WriteLine(count);
            return count;
        }
        public static int[] SquareArrayValues(int[] numbers)
        {
            List<int> squarelist = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                squarelist.Add(numbers[i]*numbers[i]);
            }
            int[] square_array = new int[squarelist.Count];
            for (int j = 0; j < squarelist.Count; j++)
            {
                square_array[j] = squarelist[j];
            }
            Console.WriteLine(square_array);
            return square_array;
        }
        public static int[] EliminateNegatives(int[] numbers)
        {
            List<int> eliminate_list = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    eliminate_list.Add(0);
                }
                else{
                    eliminate_list.Add(numbers[i]);
                }
            }
            int[] eliminate_array = new int[eliminate_list.Count];
            for (int j = 0; j < eliminate_list.Count; j++)
            {
                eliminate_array[j] = eliminate_list[j];
            }
            Console.WriteLine(eliminate_array);
            return eliminate_array;
        }
        public static void MinMaxAverage(int[] numbers)
        {
            var max = numbers[0];
            var min = numbers[0];
            var sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                if (numbers[i]< min)
                {
                    min = numbers[i];
                }
                sum+=numbers[i];
            }
            var avg = sum/numbers.Length;
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(sum);
        }
        public static void ShiftValues(int[] numbers)
        {
            for (var i = 0; i < numbers.Length; i++)
            {
                if (i < numbers.Length - 1)
                {
                    numbers[i] = numbers[i+1];
                }
                else
                {
                    numbers[i] = 0;
                }
            }
            Console.WriteLine(numbers);
        }
        public static object[] NumToString(int[] numbers)
        {
            object[] num_list = new object[numbers.Length];
            for (var i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    num_list[i] = "Dojo";
                }
                else
                {
                    num_list[i] = numbers[i];
                }
            }
            return num_list;
        }
        static void Main(string[] args)
        {
            int[] numbers = {1,-5, -2, 33,-22,2,8,7,2,12,15, 3, 44, 43};
            NumToString(numbers);
        }
    }
}
