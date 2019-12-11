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

namespace S00188061_Final_Exam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Here is where im declaring my postions as lsits
        List<Postion> GoalKeaper;
        List<Postion> Defender;
        List<Postion> MidFeilder;
        List<Postion> Forward;

        public MainWindow()
        {
            InitializeComponent();
        }

        //This is the method to load the list into the main window box
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            GoalKeaper = new List<Postion>();
            Defender = new List<Postion>();
            MidFeilder = new List<Postion>();
            Forward = new List<Postion>();
            playeraddtbx.ItemsSource = GoalKeaper;
        }
        //This is all the players that wil be loaded into the list box
        Postion p1 = new Player("Jamie", "Doyle,", "GoalKeeper", DateTime, 19-07-99);
        Postion p2 = new Player("Ava", "Doyle,", "GoalKeeper", DateTime, 16-03-96);

        Postion p3 = new Player("John", "clarke", "Defender", DateTime, 01 - 03 - 96);
        Postion p4 = new Player("Jim", "davids", "Defender",  DateTime, 13 - 03 - 93);
        Postion p5 = new Player("jack", "davids", "Defender", DateTime, 11 - 03 - 96);
        Postion p6 = new Player("conor", "Doyle", "Defender", DateTime, 10 - 03 - 94);
        Postion p7 = new Player("colm", "Davids", "Defender", DateTime, 09 - 03 - 95);
        Postion p8 = new Player("matt", "mchugh", "Defender", DateTime, 07 - 03 - 99);

        Postion p9 = new Player("matt", "mchugh", "Midfeilder", DateTime, 07 - 05 - 97);
        Postion p10 = new Player("james", "Richards", "Midfeiler", DateTime, 07 - 03 - 91);
        Postion p11 = new Player("conor", "mcguinges", "Midfeilder", DateTime, 15 - 03 - 99);
        Postion p12 = new Player("Ava", "Laois", "Midefielder", DateTime, 18 - 11 - 95);
        Postion p13 = new Player("Emily", "mchugh", "Midefeilder", DateTime, 18 - 03 - 92);
        Postion p14 = new Player("Tomas", "mcdermot", "Midefieleder", DateTime, 07 - 03 - 91);

        Postion p15 = new Player("matt", "mchugh", "Forward", DateTime, 07 - 11 - 96);
        Postion p16 = new Player("Leana", "Michelas", "Forward", DateTime, 28 - 04 - 90);
        Postion p17 = new Player("Clare", "Redfields", "Forward", DateTime, 27 - 06 - 92);
        Postion p18 = new Player("Shona", "mchugh", "Forward", DateTime, 27 - 06 - 91);

    }

    //This is a method to check that the buttons work
    private void playeraddedtbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        Postion selectedPostion = playeraddedtbx.SelectedItem as Postion;
        if (selectedPostion != null)
            playerremovetbx.Text = playeraddtbx.Description;
    }
    //This method checks for conflicts
    private void btnadd(object sender, RoutedEventArgs e)
    {
        Postion selectedActivity = Player.SelectedItem as Postion;

        if (selectedPostion != null)
        {

            //check no date conflicts
            bool dateConflict = false;
            foreach (var activity in Player)
            {
                if (selectedpostion.player == Player.Equals)
                {
                    MessageBox.Show("Date conflict");
                    dateConflict = true;
                }
            }

            if (!dateConflict)
            {
                Postion.Remove(selectedpostion);
                selectedpostion.Add(selectedpostion);

                //reset
                Playeraddedtbx.ItemsSource = null;
                playeremovedtbx.ItemsSource = null;
                playeraddedlbx.ItemsSource = Postion;

                //maintain filter view
                if (Postion.IsChecked == true) FilterType("GoalKeeper");
                else if (Postion.IsChecked == true) FilterType("Defender");
                else if (Postion.IsChecked == true) FilterType("Midfeilder");
                else if (Postion.IsChecked == true) FilterType("Forward");

                Postion.Sort();
                playeraddedtbx.ItemsSource = selectedpostions;

            }

        }
        else
        {
            MessageBox.Show("Nothing selected");
        }
    }
    //This is another method for removal button
    private void btnRemove(object sender, RoutedEventArgs e)
    {
        Postion selectedpostion = playeraddedtbx.SelectedItem as Postion;
        if (selectedActivity != null)
        {
            selectedActivitie0.Remove(selectedActivity);
            allActivities.Add(selectedActivity);

            //reset
            lbxActivities.ItemsSource = null;
            lbxUserActivities.ItemsSource = null;
            allActivities.Sort();
            rbAll.IsChecked = true;
            lbxActivities.ItemsSource = Postion;
            lbxUserActivities.ItemsSource = selectedActivities;
        }
        else
            MessageBox.Show("Nothing selected");
    }
}


