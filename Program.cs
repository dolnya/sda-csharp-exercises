using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        //E10

        //Napisz funkcję, która będzie sortowała podaną tablicę liczb wykorzystując algorytm sortowania
        //bąbelkowego.

        //en.wikipedia.org/wiki/Bubble_sort

        //youtube.com/watch? v = lyZQPjUT5B4 & t = 146s
        {
            int[] array = new int[] { 5, 1, 4, 2, 8, 6, 3 };

            int temp = 0;
            for (int j = 0; j < array.Length - j; j++)
            {
                for (int i = 0; i < array.Length; i++)

                {
                    temp = array[i];
                    if (i + 1 < array.Length-j)
                    {
                        if (temp > array[i + 1])
                        {
                            temp = array[i + 1];
                            array[i + 1] = array[i];
                            array[i] = temp;
                        }
                    }
                }
            }
            foreach (var item in array)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
