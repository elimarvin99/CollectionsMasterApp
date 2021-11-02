using System;
using System.Collections.Generic;


namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create

            #region Arrays
            // Create an integer Array of size 50                    //Done

            var myIntArray = new int[50];




            //Create a method to populate the number array with 50 random numbers that are between 0 and 50       //Done

            Populater(myIntArray);

            //Print the first number of the array                    //Done
            Console.WriteLine($"The first number in the array is {myIntArray[0]}");

            //Print the last number of the array              //Done

            Console.WriteLine($"The last number in the array is {myIntArray[myIntArray.Length-1]}");

        Console.WriteLine("All Numbers Original");
            //Use this method to print out your numbers from arrays or lists                      //Done
            //NumberPrinter();
            NumberPrinter(myIntArray);
            Console.WriteLine("-------------------");

            //Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*     Hint: Array._____(); Create a custom method     */                         //Done

            Console.WriteLine("All Numbers Reversed:");

            ReverseArray(myIntArray);

            NumberPrinter(myIntArray);

            Console.WriteLine("---------REVERSE CUSTOM------------");

            Console.WriteLine("-------------------");

            //Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers         //Done
            Console.WriteLine("Multiple of three = 0: ");

            ThreeKiller(myIntArray);

            NumberPrinter(myIntArray);

            Console.WriteLine("-------------------");

            //Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");

            SortArray(myIntArray);

            NumberPrinter(myIntArray);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //Create an integer List                             //Done

            var myIntList = new List<int>();

            //Print the capacity of the list to the console          //Done

            Console.WriteLine($"myIntList capacity is currently : {myIntList.Capacity}");
            //Populate the List with 50 random numbers between 0 and 50 you will need a method for this           //Done

            Populater(myIntList);


            //Print the new capacity             //Done

            NumberPrinter(myIntList);
            
            Console.WriteLine("---------------------");

            //Create a method that prints if a user number is present in the list                //Done
            //Remember: What if the user types "abc" accident your app should handle that!         //Done            
            Console.WriteLine("What number will you search for in the number list?");
            //var userInput = Convert.ToInt32(Console.ReadLine());
            int userInput;
            while (!int.TryParse(Console.ReadLine(), out userInput))
            {
                Console.WriteLine("The value must be of integer type");
            }
                
            NumberChecker(myIntList, userInput);


            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //Print all numbers in the list
            //NumberPrinter();                           //Done

            NumberPrinter(myIntList);
            Console.WriteLine("-------------------");

            //Create a method that will remove all odd numbers from the list then print results                 //Done
            Console.WriteLine("Evens Only!!");                     

            OddKiller(myIntList);
            
            Console.WriteLine("------------------");

            //Sort the list then print results                                //Done
            Console.WriteLine("Sorted Evens!!");

            myIntList.Sort();

            NumberPrinter(myIntList);

            Console.WriteLine("------------------");

            //Convert the list to an array and store that into a variable             //Done

            var newArray = myIntList.ToArray();

            //Clear the list                                          //Done
            myIntList.Clear();
            


            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }
                  
        }

        private static void OddKiller(List<int> numberList)
        {
            for (int i = numberList.Count-1; i >= 0; i--) //start from last index going down to zero
            {
                if (numberList[i] % 2 != 0) //access value at current index (not just the value of i in the counter)
                {
                    numberList.Remove(numberList[i]); //remove actual index value in list 
                }
                
            }
            NumberPrinter(numberList);
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            var placeholderInt = new List<int>();
            foreach (var i in numberList)
            {
               
                if (i == searchNumber)
                {
                    placeholderInt.Add(i);
                }
                
            }
            Console.WriteLine($"{searchNumber} was found {placeholderInt.Count} times in your list");
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            for (int i = 0; i < 50; i++)
            {
                numberList.Add(rng.Next(0, 50));
            }

        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            for (int i = 0; i < 50; i++) //because starting at 0 we go up to 50 because an array also starts at 0 so an array with index 50 really goes from 0 to 49
            {
                numbers[i] = rng.Next(0,50);
            }
            
        }        

        private static void ReverseArray(int[] array)
        {
            Array.Reverse(array);
        }

        private static void SortArray(int[] array)
        {
            Array.Sort(array);
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
