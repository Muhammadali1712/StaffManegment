namespace StaffManagment
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Mening Dasturimga xush kelibsiz!  Kamchiliklar uchun uzur");
            try
            {
                GanerateEmployees();
                bool move = true;
                while (move)
                {
                    using (StreamWriter writer = new StreamWriter(Path.path))
                    {
                        foreach (var employee in ManagmentEmployee.employees)
                            writer.WriteLine(employee.ToString());

                    }
                    Console.WriteLine("\n\nKerakli bo'limni tanlang : \n1.Xodimlarni ko'rish\n2.Xodim qo'shish\n" +
                        "3.Xodimni O'zgartirish\n4.Xodimni ishdan olish\n5.Eng uzoq vaqtdan beri ishlab kelayotgan xodim\n" +
                        "6.Eng ko'p maosh oluvchi 5 ta xodim\n7.Har bir bo'limdagi xodimlar soni\n8.Dasturdan chiqish");
                    byte m = Convert.ToByte(Console.ReadLine());
                    switch (m)
                    {
                        case 1:
                            EmployeesRead();
                            break;
                        case 2:
                            ManageEmployees.CreateEmployee();
                            break;
                        case 3:
                            ManageEmployees.UpdateEmployee();
                            break;
                        case 4:
                            ManageEmployees.DeleteEmployee();
                            break;
                        case 5:
                            ManageEmployees.NiceEmployee();
                            break;
                        case 6:
                            ManageEmployees.Top5Employee();
                            break;
                        case 7:
                            ManageEmployees.sectionCount();
                            break;
                        case 8:
                            move = false;
                            break;
                        default:
                            Console.WriteLine("Error!!!!!!");
                            break;
                    }

                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("Siz nimadirni xato qildingiz E'tibor bilan ishlang!!!!!\n\n"+ex.ToString());
            }


        }

        public static void GanerateEmployees()
        {
            ManagmentEmployee.employees.Add(new ManagmentEmployee() { Name = "Alex", Salary = 300, WorkingSection = "IT", WorkingTime = 10 });
            ManagmentEmployee.employees.Add(new ManagmentEmployee() { Name = "Bob", Salary = 400, WorkingSection = "HR", WorkingTime = 5 });
            ManagmentEmployee.employees.Add(new ManagmentEmployee() { Name = "Tom", Salary = 200, WorkingSection = "HR", WorkingTime = 7 });
            ManagmentEmployee.employees.Add(new ManagmentEmployee() { Name = "Jerry", Salary = 350, WorkingSection = "IT", WorkingTime = 9 });
            ManagmentEmployee.employees.Add(new ManagmentEmployee() { Name = "Ali", Salary = 500, WorkingSection = "IT", WorkingTime = 18 });
            ManagmentEmployee.employees.Add(new ManagmentEmployee() { Name = "Vali", Salary = 450, WorkingSection = "HR", WorkingTime = 12 });
            ManagmentEmployee.employees.Add(new ManagmentEmployee() { Name = "Andy", Salary = 300, WorkingSection = "IT", WorkingTime = 2 });
            ManagmentEmployee.employees.Add(new ManagmentEmployee() { Name = "Tayson", Salary = 400, WorkingSection = "HR", WorkingTime = 4 });
            ManagmentEmployee.employees.Add(new ManagmentEmployee() { Name = "Michael", Salary = 200, WorkingSection = "IT", WorkingTime = 15 });

        }

        public static void EmployeesRead()
        {
            Console.Clear();
            foreach (var emp in ManagmentEmployee.employees)
            {
                Console.WriteLine(emp.ToString());

            }
        }



    }
}