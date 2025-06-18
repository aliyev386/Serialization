using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class User
    {
        public string Name {  get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber {  get; set; }
        public User() { }
        public User(string name, string surname, string email, string phoneNumber)
        {
            Name = name;
            Surname = surname;
            Email = email;
            PhoneNumber = phoneNumber;
        }
    }
}
