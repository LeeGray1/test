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
        public int exerciseTime { get; set; }
        public int caloriesBurned { get; set; }

        public Exercise()
        {

        }

        public Exercise(string execisename, int time, int caloriesburned)
        {
            exerciseName = execisename;
            exerciseTime = time;
            caloriesBurned = caloriesburned;
        }

        public override string ToString()
        {
            return (this.exerciseName + exerciseTime + caloriesBurned);
        }

       
    }
}
