using System;
using System.Threading;

namespace KayanYazi
{
    class Program
    {
        static void prints(char[] arr) // yazdirma fonksiyonu;
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
            Console.WriteLine();
        }

        static void appendArray(char text, char[] arr) // yeni bir arraye texti ekleme fonksiyonu;
        {

            arr[arr.Length - 1] = text;
        }

        static void shift(char[] arr) // texti kaydirma fonksiyonu;
        {
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i - 1] = arr[i];
            }
            arr[arr.Length - 1] = ' ';
        }
        static void Main(string[] args)
        {
            string text;
            Console.Write("enter text: ");
            text = Console.ReadLine();
            char[] textArr = new char[15];
            for (int i = 0; i < 15; i++)
            {
                textArr[i] = ' ';
            }

            for (int i = 0; i < text.Length + 15; i++)
            {
                if (i < text.Length)
                    appendArray(text[i], textArr);
                prints(textArr);
                shift(textArr);
                Thread.Sleep(50);
                Console.Clear();
            }
        }
    }
}
