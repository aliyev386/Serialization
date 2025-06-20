using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Doctor
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime WorkExperience {  get; set; }
        public TimeSpan StartTime { get;private set; }
        public TimeSpan EndTime { get;private set; }
        public string TimeRange { get => $"{StartTime:hh\\:mm}-{EndTime:hh\\:mm}"; set
            {
                var parts = value.Split('-');
                if (parts.Length == 2 &&
                    TimeSpan.TryParse(parts[0], out var start) &&
                    TimeSpan.TryParse(parts[1], out var end))
                {
                    StartTime = start;
                    EndTime = end;
                }
                else
                {
                    throw new ArgumentException("Format düzgün deyil. Düzgün format: hh:mm-hh:mm");
                }
            }
        }
        public List<string> ReservedTimes { get; set; } = new List<string>();
        public Doctor() { }
        public Doctor(string name, string surname, DateTime workExperience, string timeRange)
        {
            Name = name;
            Surname = surname;
            WorkExperience = workExperience;
            TimeRange = timeRange;
        }
        public override string ToString() 
        {
            return $"Name: {Name}\nSurname: {Surname}\nWork experience: {WorkExperience}";
        }
    }
}
