using ConsoleApp1.Models;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ConsoleApp1;
class Program
{
    static void Control()
    {
        TimeSpan startTime = new TimeSpan(9, 0, 0);
        TimeSpan endTime = new TimeSpan(11, 0, 0);
        Doctor doctor1 = new Doctor("Umid", "Aslanov", DateTime.Parse("01-01-2015"), "00:00-00:00");
        Doctor doctor2 = new Doctor("Huseyin", "Memmedzade", DateTime.Parse("05-08-2010"), "00:00-00:00");
        Doctor doctor3 = new Doctor("Ali", "Agayev", DateTime.Parse("04-03-2020"), "00:00-00:00");
        Doctor doctor4 = new Doctor("Huseyin", "Memmedzade", DateTime.Parse("05-08-2010"), "00:00-00:00");
        Doctor doctor5 = new Doctor("Heyder", "Quliyev", DateTime.Parse("04-03-2020"), "00:00-00:00");
        Doctor doctor6 = new Doctor("Resad", "Memmedov", DateTime.Parse("05-08-2010"), "00:00-00:00");
        Doctor doctor7 = new Doctor("Emin", "Abbasov", DateTime.Parse("04-03-2020"), "00:00-00:00");
        Doctor doctor8 = new Doctor("Ibrahim", "Nebiyev", DateTime.Parse("05-08-2010"), "00:00-00:00");
        Doctor doctor9 = new Doctor("Ali", "Nebili", DateTime.Parse("04-03-2020"), "00:00-00:00");

        List<Doctor> doctors = new List<Doctor> { doctor1, doctor2, doctor3 };
        List<Doctor> doctors2 = new List<Doctor> { doctor4, doctor5 };
        List<Doctor> doctors3 = new List<Doctor> { doctor6, doctor7, doctor8, doctor9 };

        Department department1 = new Department("Pediatriya", 3, doctors);
        Department department2 = new Department("Travmatologiya", 2, doctors2);
        Department department3 = new Department("Stamotologiya", 4, doctors3);
        
        List<string> options2List = new List<string>();
        foreach (var doctor in doctors)
        {
            options2List.Add(doctor.TimeRange); 
        }
        string[] options2 = options2List.ToArray();
        List<string> options3List = new List<string>();
        foreach (var doctor in doctors2)
        {
            options3List.Add(doctor.TimeRange);
        }
        string[] options3 = options3List.ToArray();

        List<string> options4List = new List<string>();
        foreach (var doctor in doctors3)
        {
            options4List.Add(doctor.TimeRange);
        }
        string[] options4 = options4List.ToArray();

        #region Kursor
        string[] options = {
            "Pediatriya",
            "Travmatologiya",
            "Stamotologiya",
        };

        int selectedIndex = 0;
        ConsoleKey key;

        do
        {
            Console.Clear();
            Console.WriteLine("3 sobeden birini sec...\n");

            for (int i = 0; i < options.Length; i++)
            {
                if (i == selectedIndex)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("-> " + options[i]);
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine("   " + options[i]);
                }
            }

            key = Console.ReadKey(true).Key;

            if (key == ConsoleKey.UpArrow)
            {
                selectedIndex = (selectedIndex == 0) ? options.Length - 1 : selectedIndex - 1;
            }
            else if (key == ConsoleKey.DownArrow)
            {
                selectedIndex = (selectedIndex + 1) % options.Length;
            }

        } while (key != ConsoleKey.Enter);

        Console.Clear();

        #endregion
        if (selectedIndex == 0)
        {
            int selectedIndex2 = 0;
            ConsoleKey key2;

            do
            {
                Console.Clear();
                Console.WriteLine("size uygun olan vaxtlardan birini secin...\n");

                for (int i = 0; i < options2.Length; i++)
                {
                    if (i == selectedIndex2)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("-> " + options2[i]);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine("   " + options2[i]);
                    }
                }

                key2 = Console.ReadKey(true).Key;

                if (key2 == ConsoleKey.UpArrow)
                {
                    selectedIndex2 = (selectedIndex2 == 0) ? options2.Length - 1 : selectedIndex2 - 1;
                }
                else if (key2 == ConsoleKey.DownArrow)
                {
                    selectedIndex2 = (selectedIndex2 + 1) % options2.Length;
                }

            } while (key2 != ConsoleKey.Enter);

            Console.Clear();
            if (selectedIndex2 == 0)
            {
                foreach (var item in doctors)
                {
                    if (item.TimeRange == options2[selectedIndex2])
                    {
                        Console.WriteLine(item);
                        Console.WriteLine("-----------------------------------");
                    }
                }
            }
            if (selectedIndex2 == 1)
            {
                foreach (var item in doctors)
                {
                    if (item.TimeRange == options2[selectedIndex2])
                    {
                        Console.WriteLine(item);
                        Console.WriteLine("-----------------------------------");
                    }
                }
            }
            if (selectedIndex2 == 2)
            {
                foreach (var item in doctors)
                {
                    if (item.TimeRange == options2[selectedIndex2])
                    {
                        Console.WriteLine(item);
                        Console.WriteLine("-----------------------------------");
                    }
                }
            }

        }
        if (selectedIndex == 1)
        {
            

            int selectedIndex2 = 0;
            ConsoleKey key2;
            do
            {
                Console.Clear();
                Console.WriteLine("size uygun olan vaxtlardan birini secin...\n");

                for (int i = 0; i < options3.Length; i++)
                {
                    if (i == selectedIndex2)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("-> " + options3[i]);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine("   " + options3[i]);
                    }
                }

                key2 = Console.ReadKey(true).Key;

                if (key2 == ConsoleKey.UpArrow)
                {
                    selectedIndex2 = (selectedIndex2 == 0) ? options3.Length - 1 : selectedIndex2 - 1;
                }
                else if (key2 == ConsoleKey.DownArrow)
                {
                    selectedIndex2 = (selectedIndex2 + 1) % options3.Length;
                }

            } while (key2 != ConsoleKey.Enter);

            Console.Clear();
            if (selectedIndex2 == 0)
            {
                foreach (var item in doctors2)
                {
                    if (item.TimeRange == options3[selectedIndex2])
                    {
                        Console.WriteLine(item);
                        Console.WriteLine("-----------------------------------");
                    }
                }
            }
            if (selectedIndex2 == 1)
            {
                foreach (var item in doctors2)
                {
                    if (item.TimeRange == options3[selectedIndex2])
                    {
                        Console.WriteLine(item);
                        Console.WriteLine("-----------------------------------");
                    }
                }
            }
            if (selectedIndex2 == 2)
            {
                foreach (var item in doctors2)
                {
                    if (item.TimeRange == options3[selectedIndex2])
                    {
                        Console.WriteLine(item);
                        Console.WriteLine("-----------------------------------");
                    }
                }
            }

        }
        if (selectedIndex == 2)
        {
            

            int selectedIndex2 = 0;
            ConsoleKey key2;

            do
            {
                Console.Clear();
                Console.WriteLine("size uygun olan vaxtlardan birini secin...\n");

                for (int i = 0; i < options4.Length; i++)
                {
                    if (i == selectedIndex2)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("-> " + options3[i]);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine("   " + options4[i]);
                    }
                }

                key2 = Console.ReadKey(true).Key;

                if (key2 == ConsoleKey.UpArrow)
                {
                    selectedIndex2 = (selectedIndex2 == 0) ? options4.Length - 1 : selectedIndex2 - 1;
                }
                else if (key2 == ConsoleKey.DownArrow)
                {
                    selectedIndex2 = (selectedIndex2 + 1) % options4.Length;
                }

            } while (key2 != ConsoleKey.Enter);

            Console.Clear();
            if (selectedIndex2 == 0)
            {
                foreach (var item in doctors3)
                {
                    if (item.TimeRange == options4[selectedIndex2])
                    {
                        Console.WriteLine(item);
                        Console.WriteLine("-----------------------------------");
                    }
                }
            }
            if (selectedIndex2 == 1)
            {
                foreach (var item in doctors3)
                {
                    if (item.TimeRange == options4[selectedIndex2])
                    {
                        Console.WriteLine(item);
                        Console.WriteLine("-----------------------------------");
                    }
                }
            }
            if (selectedIndex2 == 2)
            {
                foreach (var item in doctors3)
                {
                    if (item.TimeRange == options4[selectedIndex2])
                    {
                        Console.WriteLine(item);
                        Console.WriteLine("-----------------------------------");
                    }
                }
            }

        }
    }
    static void Main(string[] args)
    {
        List<User> users = new List<User>();
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Surname: ");
        string surname = Console.ReadLine();
        Console.Write("Enter Email adress: ");
        string email = Console.ReadLine(); 
        if (email.EndsWith("@gmail.com"))
        {
            Console.Write("Enter Phone number");
            string phoneNumber = Console.ReadLine();
            User newUser = new User(name, surname, email, phoneNumber);
            users.Add(newUser);
        }
        else
        {
            Console.WriteLine("Wrong Email!!!");
        }
        

        Control();

    }
}



