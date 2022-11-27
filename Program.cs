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

            Console.WriteLine($"[{string.Join(", ", input)}]");
            Console.ReadLine();
        }

        static string[] GetIntialArray()
        {
            string source = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus dignissim nec felis sodales aliquet. Morbi sed ullamcorper nunc. Nulla ut urna aliquet turpis suscipit bibendum. Nulla sit amet posuere ligula, in placerat ex. Quisque dignissim eros nulla, quis maximus quam efficitur nec. Etiam vel turpis in lectus luctus ultrices. Ut sed urna vehicula, mollis purus quis, commodo justo. Donec vitae mattis arcu.";
            string[] array = source.Split(new string[] { ", ", ". "}, StringSplitOptions.None);
            return array;
        }
    }
}
