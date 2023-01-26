using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LabCreatingClasses_KyleCastillo
{
    internal class Person
    {
        private int personId;
        private string firstName;
        private string lastName;
        private string favoriteColour;
        private int age;
        private bool isWorking;

        public Person(int personId, string firstName, string lastName, string favoriteColour, int age, bool isWorking)
        {
            this.personId = personId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.favoriteColour = favoriteColour;
            this.age = age;
            this.isWorking = isWorking;

            
        }

        public string DisplayPersoninfo
        {
            get
            {
                Console.WriteLine(personId + ": " + firstName + " " + lastName + "'s favorite colour is " + favoriteColour);

                return firstName;
            }
        }

        public string ChangefavoriteColour
        {
            get
            {
                this.favoriteColour = "white";

                Console.WriteLine(personId + ": " + firstName + " " + lastName + "'s favorite colour is " + favoriteColour);

                return favoriteColour;
            }
        }


        public string GetAgeInTenYears
        {
            get
            {
                int ageTenYears;

                ageTenYears = age + 10;

                Console.WriteLine(firstName + lastName + "'s Age in 10 years is: " + ageTenYears);

                return firstName;
            }
        }


        public override string ToString()
        {
            return string.Format("PersonId : {0} \nFirstName : {1} \nLastName : {2} \nFavoriteColour : {3} \nAge : {4} \nIsWorking : {5}", personId, firstName, lastName, favoriteColour, age, isWorking);
        }


    }
}
