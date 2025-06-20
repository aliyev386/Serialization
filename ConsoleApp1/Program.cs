using ConsoleApp1.Models;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ConsoleApp1;
class Program
{

    class MainControl
    {

        private List<Department> departments = new List<Department>();

        public MainControl()
        {
            InitializeData();
        }

        private void InitializeData()
        {
            Doctor doctor1 = new Doctor("Umid", "Aslanov", DateTime.Parse("01-01-2015"), "00:00-00:00");
            Doctor doctor2 = new Doctor("Huseyin", "Memmedzade", DateTime.Parse("05-08-2010"), "00:00-00:00");
            Doctor doctor3 = new Doctor("Ali", "Agayev", DateTime.Parse("04-03-2020"), "00:00-00:00");
            Doctor doctor4 = new Doctor("Huseyin", "Memmedzade", DateTime.Parse("05-08-2010"), "00:00-00:00");
            Doctor doctor5 = new Doctor("Heyder", "Omerzade", DateTime.Parse("04-03-2020"), "00:00-00:00");
            Doctor doctor6 = new Doctor("Resad", "Memmedov", DateTime.Parse("05-08-2010"), "00:00-00:00");
            Doctor doctor7 = new Doctor("Emin", "Abbasov", DateTime.Parse("04-03-2020"), "00:00-00:00");
            Doctor doctor8 = new Doctor("Ibrahim", "Nebiyev", DateTime.Parse("05-08-2010"), "00:00-00:00");
            Doctor doctor9 = new Doctor("Ali", "Nebili", DateTime.Parse("04-03-2020"), "00:00-00:00");

            var doctors1 = new List<Doctor> { doctor1, doctor2, doctor3 };
            var doctors2 = new List<Doctor> { doctor4, doctor5 };
            var doctors3 = new List<Doctor> { doctor6, doctor7, doctor8, doctor9 };

            Department department1 = new Department("Pediatriya", doctors1.Count, doctors1);
            Department department2 = new Department("Travmatologiya", doctors2.Count, doctors2);
            Department department3 = new Department("Stamotologiya", doctors3.Count, doctors3);

            departments.Add(department1);
            departments.Add(department2);
            departments.Add(department3);
        }


        public void Loading()
        {
            string[] dots = { "", ".", "..", "..." };

            for (int i = 0; i < dots.Length; i++)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("\t\t\t#-----------------------------#");
                Console.WriteLine("\t\t\t|                             |");
                Console.WriteLine($"\t\t\t|          Loading{dots[i],-3}         |");
                Console.WriteLine("\t\t\t|                             |");
                Console.WriteLine("\t\t\t#-----------------------------#");

                Thread.Sleep(800);
            }

            Console.Clear();
        }

        public void Login(string name, string surname)
        {
            List<User> users = new List<User>();

            
            while (true)
            {
                Console.Write("Enter Email adress: ");
                string email = Console.ReadLine();
                if (email.EndsWith("@gmail.com"))
                {
                    Console.Write("Enter Phone number: ");
                    string phoneNumber = Console.ReadLine();
                    User newUser = new User(name, surname, email, phoneNumber);
                    Loading();
                    users.Add(newUser);
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong Email!!!\nTry Again...");
                    
                }
            }
        }
        public void MainMenu(string name, string surname)
        {
            

            string free = " free";
            string reserved = " reserved";
            
            string[] options2_ =
                {
                "09:00-11:00",
                "12:00-14:00",
                "15:00-17:00"
            };
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
            if (selectedIndex >= 0 && selectedIndex < options.Length)
            {
                int selectedIndex2 = 0;
                ConsoleKey key2;

                do
                {
                    Console.Clear();
                    Console.WriteLine("Pediatr sobesinde olan hekimlerden birini secin...\n");

                    for (int i = 0; i < departments[selectedIndex].DoctorCount; i++)
                    {
                        if (i == selectedIndex2)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine();
                            Console.WriteLine("-> " + departments[selectedIndex].Doctors[i]);
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine(" " + departments[selectedIndex].Doctors[i]);
                        }
                    }

                    key2 = Console.ReadKey(true).Key;

                    if (key2 == ConsoleKey.UpArrow)
                    {
                        selectedIndex2 = (selectedIndex2 == 0) ? departments[selectedIndex].Doctors.Count - 1 : selectedIndex2 - 1;
                    }
                    else if (key2 == ConsoleKey.DownArrow)
                    {
                        selectedIndex2 = (selectedIndex2 + 1) % departments[selectedIndex].Doctors.Count;
                    }

                } while (key2 != ConsoleKey.Enter);
                if (selectedIndex2 >= 0 && selectedIndex2 < departments[selectedIndex].Doctors.Count)

                {
                    Doctor selectedDoctor = departments[selectedIndex].Doctors[selectedIndex2];
                    int selectedIndex3 = 0;
                    ConsoleKey key3;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("size uygun olan vaxtlardan birini secin...\n");

                        for (int i = 0; i < options2_.Length; i++)
                        {

                            string timeStatus = selectedDoctor.ReservedTimes.Contains(options2_[i]) ? " (reserved)" : " (free)";
                            if (i == selectedIndex3)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("-> " + options2_[i] + timeStatus);
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.WriteLine("   " + options2_[i] + timeStatus);
                            }

                        }

                        key3 = Console.ReadKey(true).Key;

                        if (key3 == ConsoleKey.UpArrow)
                        {
                            selectedIndex3 = (selectedIndex3 == 0) ? options2_.Length - 1 : selectedIndex3 - 1;
                        }
                        else if (key3 == ConsoleKey.DownArrow)
                        {
                            selectedIndex3 = (selectedIndex3 + 1) % options2_.Length;
                        }

                    } while (key3 != ConsoleKey.Enter);
                    if (selectedIndex3 >= 0 && selectedIndex3 < options2_.Length)
                    {

                        string selectedTime = options2_[selectedIndex3];

                        if (selectedDoctor.ReservedTimes.Contains(selectedTime))
                        {
                            Console.WriteLine("Hemin vaxt artiq bu hekim ucun rezerv olunub. Zehmet olmasa basqa bir vaxt secin.");
                            Console.WriteLine("\nPress enter for continue...");
                            Console.ReadLine();
                            MainMenu(name, surname);
                        }
                        else
                        {
                            selectedDoctor.ReservedTimes.Add(selectedTime);
                            Console.WriteLine($"{name} {surname} siz saat {selectedTime} de {selectedDoctor.Name} hekimin qebuluna yazildiniz.");
                            Console.WriteLine("\nPress enter for continue...");
                            Console.ReadLine();
                            Console.Clear();
                            Start();
                        }
                    }

                }


            }

        }
    }
    static MainControl mainControl = new MainControl();
    static void Start()
    {

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Surname: ");
        string surname = Console.ReadLine();

        mainControl.Login(name, surname);
        mainControl.MainMenu(name, surname);
    }
    static void Main(string[] args)
    {
        Start();
    }
}


