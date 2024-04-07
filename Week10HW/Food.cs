using System;
using System.Collections.Generic;
using System.Text;

namespace Week10HW
{
    class Food
    {
        int foodId;
        string foodName, foodType;
        double foodAmount;

        public int FoodId 
        {
         get { return foodId; }
         set { foodId = value; }      
        }

        public string FoodName 
        {
            get { return foodName; }
            set { foodName = value; }
            
        }
        public string FoodType
        {
            get { return foodType; }
            set { foodType = value; }


        }
        public double FoodAmount 
        {
            get { return foodAmount; }
            set {foodAmount = value; }
        
        
        }
    }
}
