using System;

namespace FinalHomeWorkCS
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = GetIntialArray();
            string[] output = FilterArray(input, 3);

            Console.WriteLine($"[{string.Join(", ", output)}]");
            Console.ReadLine();
        }

        static string[] GetIntialArray()
        {
            string source = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus dignissim nec felis sodales aliquet. Morbi sed ullamcorper nunc. Nulla ut urna aliquet turpis suscipit bibendum. Nulla sit amet posuere ligula, in placerat ex. Quisque dignissim eros nulla, quis maximus quam efficitur nec. Etiam vel turpis in lectus luctus ultrices. Ut sed urna vehicula, mollis purus quis, commodo justo. Donec vitae mattis arcu.";
            string[] array = source.Split(new string[] { " ", ", ", ". "}, StringSplitOptions.None);
            return array;
        }

        static string[] FilterArray(string[] input, int stringLength)
        {
            int[] tempArray = new int[input.Length];
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if(input[i].Length <= stringLength)
                {
                    tempArray[count] = i;
                    count++;
                }
            }

            string[] output = new string[count];
            for (int i = 0; i < count; i++)
            {
                output[i] = input[tempArray[i]];
            }

            return output;
        }
    }
}
