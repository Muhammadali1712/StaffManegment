﻿namespace StaffManagment
{
    public static class ManageEmployees
    {

        public static async Task CreateEmployee()
        {
            Console.Clear();
            Console.Write("Xodimni ismini kiriting : ");
            string? name = Console.ReadLine();
            Console.Write("Oyligi : ");
            double salary = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ishlash bo'limi (HR yoki IT) : ");
            string? workingSection = Console.ReadLine();
            ManagmentEmployee.employees.Add(new ManagmentEmployee() { Name = name, Salary = salary, 
                WorkingSection = workingSection, WorkingTime = 0 });
            
            
                await Task.Delay (TimeSpan.FromSeconds(5));
                Console.WriteLine("CreateEmployee Complated!!!");
            
        }

        public static async Task UpdateEmployee() 
        {
            Console.Clear();
            Console.Write("O'zgartirmoqchi bo'lgan xodimni ismini kiriting : ");
            string? namesearch = Console.ReadLine();

            ManagmentEmployee? afd = ManagmentEmployee.employees.Where(x => x.Name == namesearch).FirstOrDefault();

            if (afd != null)
            {
                ManagmentEmployee.employees.Remove(afd);

                Console.Write("Xodimni ismini kiriting : ");
                string? name = Console.ReadLine();
                Console.Write("Oyligi : ");
                double salary = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ishlagan vaqti : ");
                double workingTime = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ishlash bo'limi (HR yoki IT) : ");
                string? workingSection = Console.ReadLine();
                ManagmentEmployee.employees.Add(new ManagmentEmployee() { Name = name, Salary = salary, 
                    WorkingSection = workingSection, WorkingTime = workingTime});

                
            }
            else Console.WriteLine("Bunday xodim topilmadi");


            await Task.Delay(TimeSpan.FromSeconds(5));
            Console.WriteLine("UpdateEmployee Complated!!!");
        }

        public static async void DeleteEmployee()
        {
            Console.Clear();
            Console.Write("Bo'shatmoqchi bo'lgan xodimni ismini kiriting : ");
            string? name = Console.ReadLine();

            IEnumerable<ManagmentEmployee> afd = ManagmentEmployee.employees.Where(x => x.Name == name);

            if (afd.FirstOrDefault() != null)
            {
                ManagmentEmployee.employees.Remove(afd.FirstOrDefault());
                Console.WriteLine("Bo'shatildi");
            }
            else Console.WriteLine("Bunday xodim topilmadi");


            await Task.Delay(TimeSpan.FromSeconds(5));
            Console.WriteLine("DeleteEmployee Complated!!!");
        }

        public static async Task NiceEmployee()
        {
            Console.Clear();
            double maxi = ManagmentEmployee.employees.Max(x => x.WorkingTime);
            String employee = ManagmentEmployee.employees.Where(x => x.WorkingTime == maxi).FirstOrDefault().ToString();
            Console.WriteLine("Managmentda eng ko'p ishlagan xodim : ");
            Console.WriteLine(employee);

            await Task.Delay(TimeSpan.FromSeconds(5));
            Console.WriteLine("NiceEmployee Complated!!!");
        }

        public static async void Top5Employee()
        {
            Console.Clear();
            IEnumerable<ManagmentEmployee> top5 = ManagmentEmployee.employees.OrderByDescending(x => x.Salary)
                .ThenBy(x=>x.Name).Take(5);
            Console.WriteLine("Eng ko'p maosh oluvchi 5 ta xodim : ");
            foreach (ManagmentEmployee employee in top5)
            {
                Console.WriteLine(employee.ToString());
            }

            await Task.Delay(TimeSpan.FromSeconds(5));
            Console.WriteLine("Top5Employee Complated!!!");
        }

        public static async void sectionCount()
        {
            Console.Clear();
            int HR=0, IT=0;
            foreach (ManagmentEmployee item in ManagmentEmployee.employees)
            {
                if (item.WorkingSection == "IT") IT++;
                else if(item.WorkingSection == "HR") HR++;
            }
            Console.WriteLine("IT bo'limida ishlovchi xodimlar soni : "+IT);
            Console.WriteLine("HR bo'limida ishlovchi xodimlar soni : "+HR);

            await Task.Delay(TimeSpan.FromSeconds(5));
            Console.WriteLine("sectionCount Complated!!!");
        }
    }
}
