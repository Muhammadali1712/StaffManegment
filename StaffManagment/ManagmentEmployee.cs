using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffManagment
{
    public class ManagmentEmployee
    {
        public static List<ManagmentEmployee> employees = new List<ManagmentEmployee>();

        public string? Name { get; set; }


        public double WorkingTime { get; set; }
        public double Salary { get; set; }
        public string? WorkingSection { get; set; }

        public override string ToString()
        {
            return $"Nomi : {Name}   Oyligi : {Salary}   Ishlagan vaqti : {WorkingTime}   Ishlash bo'limi : {WorkingSection}";
        }
    }
}
