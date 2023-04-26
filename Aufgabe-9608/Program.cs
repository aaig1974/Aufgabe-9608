using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * IQ Test
Einer Ihrer Freunde schreibt bald eine IQ Test und um sich darauf vorzubereiten hat er Sie gebeten ein kleines Programm für Ihn zu schreiben. 
Einer der häufigsten Aufgaben ist es den Unterschied zwischen einer Vielzahl von Zahlen zu finden. Ihrem Freund ist aufgefallen, dass 
die Zahlen sich meistens in der Geradheit unterscheiden.

Um Ihrem Freund nun zu helfen schreiben Sie bitte eine Methode „Test“ die als Rückgabetyp Integer und als Parametertyp einen String hat. 
Diese Methode soll die Position der Zahl angeben die unterschiedlich den anderen gegenüber ist.

Hinweis: Um Ihrem Freund zu helfen muss die Position bei 1 anfangen (nicht bei 0).

Beispiel
Test(„2 4 7 8 10“) => 3 //Die dritte Zahl ist ungerade, während die restlichen gerade sind

Test(„1 2 1 1“) => 2 //Die zweite Zahl ist gerade, während die restlichen ungerade sind

Test(„2 4 6 8 10 2 4 6 7 8 10“) => 9 //Die neunte Zahl ist ungerade, während die restlichen gerade sind
 * 
 * 
 * */

namespace Aufgabe_9608
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test("2 4 6 8 10 2 4 6 7 8 10"));
            Console.ReadKey();
        }

        private static int Test(string str)
        {
            int[] arr = StringToIntArray(str, ' ');
            int isEven = 0;
            int isOdd = 0;
            int index = -1;
            bool even = true;

            foreach(var item in arr)
            {
                if (item % 2 == 0)
                    isEven++;
                else
                    isOdd++;
            }

            if(isEven > isOdd)
            {
                even = false;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (IsEven(arr[i]) == even)
                {
                    index = i;
                    return index + 1;
                }

            }

            return index;
        }

        private static bool IsEven(int i)
        {
            return i % 2 == 0; 
        }

        private static int[] StringToIntArray(string str, char seperator)
        {
            string[] strArr = str.Split(seperator);
            int length = strArr.Length;
            int[] arr = new int[length];
            for (int i = 0; i < length; i++)
            {
                arr[i] = Convert.ToInt32(strArr[i]);
            }
            return arr;
        }
    }
}
