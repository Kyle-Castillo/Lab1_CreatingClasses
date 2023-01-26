using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCreatingClasses_KyleCastillo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Person Ian = new Person(1, "Ian", "Brooks", "Red", 30, true);
            Person Gina = new Person(2, "Gina", "James", "Green", 18, false);
            Person Mike = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person Mary = new Person(4, "Mary", "Beals", "Yellow", 28, true);

            string GinaInfo = Gina.DisplayPersoninfo;
            Console.WriteLine(Mike.ToString());
            string IanNewColor = Ian.ChangefavoriteColour;
            string MaryTenYears = Mary.GetAgeInTenYears;


        }
    }
}
