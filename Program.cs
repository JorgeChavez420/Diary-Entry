using System;
using System.Globalization;

namespace Diary_Entry
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Introduce el texto deseado acontinuacion");

                float a = float.Parse(Console.ReadLine());


                using (StreamWriter sw = new StreamWriter("30/05/2021.txt"))
                {
                    CultureInfo culture = new CultureInfo("es-MX");
                    todayAsStr = today.toString(culture);
                }
            }
        }





