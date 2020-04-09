using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Exercise
    {
        public string exerciseName { get; set; }
        public int caloriesBurned { get; set; }

        public Exercise()
        {

        }

        public Exercise(string execisename, int caloriesburned)
        {
            exerciseName = execisename;
            caloriesBurned = caloriesburned;
        }

        public override string ToString()
        {
            return string.Format($"{exerciseName} - {caloriesBurned} cal per hour");
        }


    }
}
