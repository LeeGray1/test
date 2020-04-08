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
        Calories_DatabaseContainer db = new Calories_DatabaseContainer();
        //lists for added exercises and food

        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var Selectedfoods = from F in db.FoodTBLs
                                orderby F.Name
                                select new { F.Name, F.Calories };
            List<Food> foods = new List<Food>();
            foreach (var item in Selectedfoods)
            {
                Food f = new Food();
                f.foodName = item.Name;

                f.foodCalories = item.Calories;

                foods.Add(f);
            }

            Foodlbx.ItemsSource = foods;

            //workouts being created and added
            var Exercises = from E in db.ExerciseTBLs
                                orderby E.Name
                                select new { E.Name,E.CalBurned };
            List<Exercise> workouts = new List<Exercise>();
            foreach (var Healthy in Exercises)
            {
                Exercise w = new Exercise();
                w.exerciseName = Healthy.Name;

                //w.exerciseTime = Healthy.Time;

                w.caloriesBurned = Healthy.CalBurned;

                //w.exerciseTime = Healthy.Time;

                workouts.Add(w);
            }

            Exerciselbx.ItemsSource = workouts;
        }

        private void Exerciselbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //check what was selected
            //Exercise selectedWorkout = Exerciselbx.SelectedItem as Exercise;
            int burned = 0;

            foreach (Exercise selectedworkout in Exerciselbx.SelectedItems)
            {
                //make sure not null
                if (selectedworkout != null)
                {


                    //update display

                    burned += selectedworkout.caloriesBurned;
                }
            }
            tbxCalBurned.Text = burned.ToString();
        }

        private void Foodlbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //check what was selected
            // Food selectedfood = Foodlbx.SelectedItem as Food;
            int totalCal = 0;
            foreach (Food selectedfood in Foodlbx.SelectedItems)
            {

                // how to check li is selected or not


                //make sure not null
                if (selectedfood != null)
                {


                    //update display

                    totalCal += selectedfood.foodCalories;


                }
            }
            tbxCalGained.Text = totalCal.ToString();

        }

        private void tbxCalGained_TextChanged(object sender, TextChangedEventArgs e)
        {
            //calculation to subtract calories
            if (!string.IsNullOrEmpty(tbxCalGained.Text) && !string.IsNullOrEmpty(tbxCalBurned.Text))
                tbxCalResult.Text = (Convert.ToInt32(tbxCalGained.Text) - Convert.ToInt32(tbxCalBurned.Text)).ToString();
        }

        private void calBurned_TextChanged(object sender, TextChangedEventArgs e)
        {
            //calculation to subtract calories
            if (!string.IsNullOrEmpty(tbxCalGained.Text) && !string.IsNullOrEmpty(tbxCalBurned.Text))
                tbxCalResult.Text = (Convert.ToInt32(tbxCalGained.Text) - Convert.ToInt32(tbxCalBurned.Text)).ToString();
            tbxCalResult.Text = (Convert.ToInt32(tbxCalGained.Text) - Convert.ToInt32(tbxCalBurned.Text)).ToString();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
