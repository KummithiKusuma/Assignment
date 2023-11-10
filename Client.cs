using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud2
{
    internal class Client
    {

        managedoctor managedoctor;
        public Program()
        {
            managedoctor = new managedoctor();
        }
        void DisplayAdminMenu()
        {
            Console.WriteLine("1.Add doctor");
            Console.WriteLine("2.Modify doctor experience");
            Console.WriteLine("3.Modify doctor phonenumber");
            Console.WriteLine("4.Modify doctor clinicaddress")
            Console.WriteLine("0.delete doctor");
        }
        void StartAdminActivities()
        {
            int choice;
            do
            {
                DisplayAdminMenu();
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("deleted");
                        break;
                    case 1:
                        managedoctor.getdetailsfromuser();
                        break;
                    case 2:
                        Updateexperience();
                        break;
                    case 3:
                        Updatephonenumber();
                        break;
                    case 4:
                        Updateclinicaddress();
                        break;
                    default:
                        Console.WriteLine("Invalid choice.Try again");
                        break;
                }
            }
            while (choice != 0);
        }
        private void Updateexperience()
        {
            managedoctor.PrintdoctorDetails();
            Console.WriteLine("Please enter the new experience");
            int experience = Convert.ToInt32(Console.ReadLine());
            var result = managedoctor.Updateexperience(experience);
            if (result == true)
            {
                Console.WriteLine("Experience updated");
                managedoctor.PrintdoctorDetails();
            }
            else
                Console.WriteLine("Unable to update experience");
        }
        private void Updatephonenumber()
        {
            managedoctor.PrintdoctorDetails();
            Console.WriteLine("Please enter the new Phonenumber");
            int phonenumber = Convert.ToInt32(Console.ReadLine());
            var result = managedoctor.Updatedphonenumber(phonenumber);
            if (result == true)
            {
                Console.WriteLine("phonenumber updated");
                managedoctor.PrintdoctorDetails();
            }
            else
                Console.WriteLine("Unable to update phonenumber");
        }
        private void update clinicaddress()
        {
            managedoctor.PrintdoctorDetails();
            Console.WriteLine("Please enter the new clinicaddress");
            string clinicaddress = Convert.ToInt32(Console.ReadLine());
            var result = managedoctor.clinicaddress(clinicaddress);
            if (result == true)
            {
                Console.WriteLine("clinicaddress  updated");
                managedoctor.PrintdoctorDetails();
            }
            else
                Console.WriteLine("Unable to update clinicaddress ");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("welcome to the Clinic");
            Program home = newProgram();
            home.StartAdminActivities();
        }
    }
}
