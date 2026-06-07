namespace Assignment2
{
    public struct Student
    {
        // Private data members
        private string name;
        private bool gender;
        private int age;
        private int std;
        private char div;
        private double marks;

        // Parameterized Constructor
        public Student(string name, bool gender, int age,
                       int std, char div, double marks)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.std = std;
            this.div = div;
            this.marks = marks;
        }

        // Getters and Setters
        public string GetName() => name;
        public void SetName(string name) => this.name = name;

        public bool GetGender() => gender;
        public void SetGender(bool gender) => this.gender = gender;

        public int GetAge() => age;
        public void SetAge(int age) => this.age = age;

        public int GetStd() => std;
        public void SetStd(int std) => this.std = std;

        public char GetDiv() => div;
        public void SetDiv(char div) => this.div = div;

        public double GetMarks() => marks;
        public void SetMarks(double marks) => this.marks = marks;

        // Accept Details
        public void AcceptDetails()
        {
            Console.Write("Enter Name: ");
            name = Console.ReadLine();

            Console.Write("Enter Gender (true=Male, false=Female): ");
            gender = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Enter Age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Standard: ");
            std = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Division: ");
            div = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter Marks: ");
            marks = Convert.ToDouble(Console.ReadLine());
        }

        // Print Details
        public void PrintDetails()
        {
            Console.WriteLine("\nStudent Details");
            Console.WriteLine($"Name      : {name}");
            Console.WriteLine($"Gender    : {(gender ? "Male" : "Female")}");
            Console.WriteLine($"Age       : {age}");
            Console.WriteLine($"Standard  : {std}");
            Console.WriteLine($"Division  : {div}");
            Console.WriteLine($"Marks     : {marks}");
        }
    }

    public class Program
    {
        static void Main()
        {
            Student s = new Student();

            s.AcceptDetails();
            s.PrintDetails();
        }
    }
}
