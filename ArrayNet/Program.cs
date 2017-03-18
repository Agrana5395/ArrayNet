using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayNet
{
    class Program
    {
        static void Main(string[] args)
        {
            // The long interaction
            int[] numbers = new int[5];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;

            Console.WriteLine("In computer science the numbers start countiong from 0." +
                 "\r\n" + "For exaple {0} in math is equal 0 in computers" + "\r\n" + "in math is equal {1} is equal 1 in PC" +
                 "\r\n" + "in math is equal {2} is equal 2 PC lenguage ", numbers[0], numbers[1], numbers[2]);

            Console.WriteLine("The total number of strings are: {0}",numbers.Length.ToString());

            // The for loop interaction 
            string[] names = new string[] { "Alfredo", "Molly", "Ratchel", "Cats" };
            for (int names1 = 0; names1 < names.Length; names1++)
            {
                string names3 = Convert.ToString(names[names1]);
                Console.WriteLine("The names are {0}", names3);
            }

            // The foreach interaction 
            foreach (string name in names)
            {
                Console.WriteLine("the names are:" + name);
            }

            // Reverse interaction with arrays 
            string myName = "Saltaren";
            char[] nameChar = myName.ToCharArray();
            Array.Reverse(nameChar);
           
            foreach (char myNameChar in nameChar)
            {
                
                Console.Write( myNameChar );
            }

          
            
            Console.ReadLine();
        }

    }
}
