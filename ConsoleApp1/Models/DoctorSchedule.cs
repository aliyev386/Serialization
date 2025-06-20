using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    class DoctorSchedule
    {
        public Doctor Doctor { get; set; }
        public bool[] ReservedHours { get; set; }

        public DoctorSchedule(Doctor doctor, int slotCount)
        {
            Doctor = doctor;
            ReservedHours = new bool[slotCount];
        }

        public bool IsAvailable(int index) => !ReservedHours[index];
        public void Reserve(int index) => ReservedHours[index] = true;
    }

}
