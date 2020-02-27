using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Food : IComparable
    {
        public string foodName { get; set; }
        public int foodCalories { get; set; }

        public Food()
        {

        }

        public Food(string foodname, int foodcalories)
        {
            foodName = foodname;

            foodCalories = foodcalories;
        }

        public override string ToString()
        {
            return string.Format($"{foodName} - {foodCalories} cal");
        }


        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            Food foods = obj as Food;
            if (foods != null)
                return this.foodName.CompareTo(foods.foodName);
            else
                throw new ArgumentException("");
        }
    }
}
