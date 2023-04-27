using System;

namespace lab3_z1
{
    public class Program
    {
        static public int Text(string textIn)
        {
            int count = 0;

            bool inNumber = false;

            foreach (char c in textIn)
            {

                if (char.IsNumber(c))
                {
                    if (!inNumber)
                    {

                        inNumber = true;
                        count++;
                    }
                }
                else
                {

                    inNumber = false;
                }
            }
            if (count == 0) Console.WriteLine("В рядку немає чисел");
            else Console.WriteLine(count);

            return count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введіть рядок: ");
            string textIn = Console.ReadLine();

            char[] charArray = textIn.ToCharArray();

            

            Array.Reverse(charArray);

            Console.WriteLine("Реверсивний рядок: ");
            Console.WriteLine(charArray);

            Console.WriteLine("Кількість чисел в рядку:");
            Text(textIn); 

        }
    }
}
