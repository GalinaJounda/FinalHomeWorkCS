using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string[] array = source.Split(new string[] { ", ", ". "}, StringSplitOptions.None);
            return array;
        }

        static string[] FilterArray(string[] input, int stringLength)
        {
            string[] output = new string[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                if(input[i].Length <= 3)
                {
                    output[i] = input[i];
                }
            }
            return output;
        }
    }
}
