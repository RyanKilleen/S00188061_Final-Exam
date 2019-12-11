using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S00188061_Final_Exam
{
    //This is Declaring my enums
    public enum Postion {GoalKeeper, Defender, MidFeilder, Forward }
    //This is the start of the player class
    class Player
    {
        //Declaring Variables
        public string FirstName { get; set; }

        public string Surname { get; set; }

        public string PreferedPostion {get; set;}

        public DateTime Dateofbirth { get; set; }

        private string _Age;
        //This is Setting Random Date of Birth
        public string Age
        {
            get
            {
                return string.Format("{0} Dateofbirth - {1:c}", _Age, Dateofbirth);
            }
            set
            {
                _Age = value;
            }
        }

        //This is a method to Generate A random PLayer
        public Player GetRandomPlayer()
        {
            string[] randomfirstName = { "Adam", "Amelia", "Ava", "Chloe", };
            int RandomNumber = Random.Equals { 0, 4};
            string Firstname = Firstname[randomfirstName];

            string[] randomsecondName = { "Brennan", "Byrne", "Daly", "Doyle" };
            int RandomNumber1 = Random.Equals { 0, 4};
            string SecondName = SecondName[randomsecondName];

            string[] randomAge = { "24", "21", "23", "26" };
            int RandomNumber2 = Random.Equals { 0, 4};
            string randomAge = randomAge[randomAge];
        }
    }
}
