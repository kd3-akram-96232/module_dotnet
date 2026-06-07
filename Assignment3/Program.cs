namespace Assignment3
{
    public class Date
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public Date()
        {
            Day = 1;
            Month = 1;
            Year = 2000;
        }

        public Date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public void AcceptDate()
        {
            Console.Write("Day: ");
            Day = int.Parse(Console.ReadLine());

            Console.Write("Month: ");
            Month = int.Parse(Console.ReadLine());

            Console.Write("Year: ");
            Year = int.Parse(Console.ReadLine());
        }

        public void PrintDate()
        {
            Console.WriteLine(ToString());
        }

        public bool IsValid()
        {
            return DateTime.TryParse(
                $"{Year}-{Month}-{Day}",
                out _);
        }

        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }

        public static int CalculateAge(Date birth)
        {
            DateTime dob = new DateTime(
                birth.Year,
                birth.Month,
                birth.Day);

            int age = DateTime.Now.Year - dob.Year;

            if (DateTime.Now < dob.AddYears(age))
                age--;

            return age;
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public bool Gender { get; set; }
        public Date Birth { get; set; }
        public string Address { get; set; }

        public int Age
        {
            get
            {
                return Date.CalculateAge(Birth);
            }
        }

        public Person()
        {
            Birth = new Date();
        }

        public Person(string name,
                      bool gender,
                      Date birth,
                      string address)
        {
            Name = name;
            Gender = gender;
            Birth = birth;
            Address = address;
        }

        public virtual void Accept()
        {
            Console.Write("Name: ");
            Name = Console.ReadLine();

            Console.Write("Gender (true/false): ");
            Gender = bool.Parse(Console.ReadLine());

            Birth = new Date();
            Birth.AcceptDate();

            Console.Write("Address: ");
            Address = Console.ReadLine();
        }

        public virtual void Print()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"Name={Name}, Gender={Gender}, Birth={Birth}, Age={Age}, Address={Address}";
        }
    }

    public enum DepartmentType
    {
        HR,
        Sales,
        Admin,
        IT
    }

    public class Employee : Person
    {
        private static int count = 1000;

        public int Id { get; }
        public double Salary { get; set; }
        public string Designation { get; set; }
        public DepartmentType Dept { get; set; }

        public Employee()
        {
            Id = ++count;
        }

        public Employee(string name,
                        bool gender,
                        Date birth,
                        string address,
                        double salary,
                        string designation,
                        DepartmentType dept)
            : base(name, gender, birth, address)
        {
            Id = ++count;
            Salary = salary;
            Designation = designation;
            Dept = dept;
        }

        public override void Accept()
        {
            base.Accept();

            Console.Write("Salary: ");
            Salary = double.Parse(Console.ReadLine());

            Console.Write("Department (HR,Sales,Admin,IT): ");
            Dept = Enum.Parse<DepartmentType>(
                Console.ReadLine());
        }

        public override void Print()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return base.ToString()
                + $", Id={Id}, Salary={Salary}, Designation={Designation}, Dept={Dept}";
        }
    }

    public class Manager : Employee
    {
        public double Bonus { get; set; }

        public Manager()
        {
            Designation = "Manager";
        }

        public Manager(double bonus)
        {
            Bonus = bonus;
            Designation = "Manager";
        }

        public override void Accept()
        {
            base.Accept();

            Console.Write("Bonus: ");
            Bonus = double.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return base.ToString()
                   + $", Bonus={Bonus}";
        }
    }

    public class Supervisor : Employee
    {
        public int Subordinates { get; set; }

        public Supervisor()
        {
            Designation = "Supervisor";
        }

        public override void Accept()
        {
            base.Accept();

            Console.Write("Subordinates: ");
            Subordinates =
                int.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return base.ToString()
                   + $", Subordinates={Subordinates}";
        }
    }
    public class WageEmp : Employee
    {
        public int Hours { get; set; }
        public int Rate { get; set; }

        public WageEmp()
        {
            Designation = "Wage";
        }

        public override void Accept()
        {
            base.Accept();

            Console.Write("Hours: ");
            Hours = int.Parse(Console.ReadLine());

            Console.Write("Rate: ");
            Rate = int.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return base.ToString()
                + $", Hours={Hours}, Rate={Rate}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager m = new Manager();
            m.Accept();

            Console.WriteLine("\nManager Details");
            m.Print();

            Supervisor s = new Supervisor();
            s.Accept();

            Console.WriteLine("\nSupervisor Details");
            s.Print();

            WageEmp w = new WageEmp();
            w.Accept();

            Console.WriteLine("\nWage Employee Details");
            w.Print();
        }
    }
}
