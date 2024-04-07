using System;
using static System.Console;

namespace Week10HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Food food1 = new Food();
            Food food2 = new Food();
          


            food1.FoodId = 1234;
            food1.FoodName = "Patty Paradise";
            food1.FoodType = "Burger";
            food1.FoodAmount = 20.00;

            food2.FoodId = 1022;
            food2.FoodName = "Cold Turkey";
            food2.FoodType = "Turkey Sandwhich";
            food2.FoodAmount = 15.00;

            Console.WriteLine("{0,20},{1,20},{2,20},{3,20}", "FoodId", "FoodName", "FoodType", "FoodAmount");

            Console.WriteLine("{0,20},{1,20},{2,20},{3,20}", food1.FoodId, food1.FoodName, food1.FoodType, food1.FoodAmount);
            Console.WriteLine("{0,20},{1,20},{2,20},{3,20}", food2.FoodId, food2.FoodName, food2.FoodType, food2.FoodAmount);

            ReadKey();


        }
    }
}
