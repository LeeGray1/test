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
                exerciseName = "Bicep curls",
                exerciseTime = 15,
                caloriesBurned = 110,

            };
            Exercise e2 = new Exercise()
            {
                exerciseName = "Plank",
                exerciseTime = 15,
                caloriesBurned = 120,

            };
            Exercise e3 = new Exercise()
            {
                exerciseName = "Single leg squat",
                exerciseTime = 15,
                caloriesBurned = 105,

            };
            Exercise e4 = new Exercise()
            {
                exerciseName = "push-ups",
                exerciseTime = 15,
                caloriesBurned = 100,

            };
            Exercise e5 = new Exercise()
            {
                exerciseName = "pull-ups",
                exerciseTime = 15,
                caloriesBurned = 100,

            };
            Exercise e6 = new Exercise()
            {
                exerciseName = "Deadlift",
                exerciseTime = 15,
                caloriesBurned = 120,

            };

            workouts.Add(e1);
            workouts.Add(e2);
            workouts.Add(e3);
            workouts.Add(e4);
            workouts.Add(e5);
            workouts.Add(e6);

            Exerciselbx.ItemsSource = workouts;
        }
       
        private void Exerciselbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //check what was selected
            Exercise selectedWorkout = Exerciselbx.SelectedItem as Exercise;

            //make sure not null
            if (selectedWorkout != null)
            {
                //update display

                tbxCalBurned.Text = selectedWorkout.caloriesBurned.ToString();


            }

            
        }

        private void Foodlbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //check what was selected
            Food selectedfood = Foodlbx.SelectedItem as Food;

            //make sure not null
            if (selectedfood != null)
            {

                //update display

                tbxCalGained.Text = selectedfood.foodCalories.ToString();


            }


        }

        private void tbxCalGained_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxCalGained.Text) && !string.IsNullOrEmpty(tbxCalBurned.Text))
                tbxCalResult.Text = (Convert.ToInt32(tbxCalGained.Text) - Convert.ToInt32(tbxCalBurned.Text)).ToString();
        }

        private void calBurned_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxCalGained.Text) && !string.IsNullOrEmpty(tbxCalBurned.Text))
                tbxCalResult.Text = (Convert.ToInt32(tbxCalGained.Text) - Convert.ToInt32(tbxCalBurned.Text)).ToString();
                tbxCalResult.Text = (Convert.ToInt32(tbxCalGained.Text) - Convert.ToInt32(tbxCalBurned.Text)).ToString();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
