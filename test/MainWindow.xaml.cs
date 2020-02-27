using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Food> foods = new List<Food>();
        List<Exercise> workouts = new List<Exercise>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Food f1 = new Food()
            {
                foodName = "Steak and chips",
                foodCalories = 661 
                
            };
            Food f2 = new Food()
            {
                foodName = "Roast dinner",
                foodCalories = 850
            };
            Food f3 = new Food()
            {
                foodName = "Shepards pie",
                foodCalories = 922
            };
            Food f4 = new Food()
            {
                foodName = "Fish and chips",
                foodCalories = 840
            };
            Food f5 = new Food()
            {
                foodName = "Lasagne",
                foodCalories = 135
            };

            foods.Add(f1);
            foods.Add(f2);
            foods.Add(f3);
            foods.Add(f4);
            foods.Add(f5);

            Foodlbx.ItemsSource = foods;

            Exercise e1 = new Exercise()
            {
                exerciseName ="Bicep curls",
                exerciseTime = 15,
                caloriesBurned = ,
                
            }
            Exercise e2 = new Exercise()
            {
                exerciseName = "",
                exerciseTime = ,
                caloriesBurned = ,

            }
            Exercise e1 = new Exercise()
            {
                exerciseName = "",
                exerciseTime = ,
                caloriesBurned = ,

            }
            Exercise e1 = new Exercise()
            {
                exerciseName = "",
                exerciseTime = ,
                caloriesBurned = ,

            }
            Exercise e1 = new Exercise()
            {
                exerciseName = "",
                exerciseTime = ,
                caloriesBurned = ,

            }
            Exercise e1 = new Exercise()
            {
                exerciseName = "",
                exerciseTime = ,
                caloriesBurned = ,

            }
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }       
    }
}
