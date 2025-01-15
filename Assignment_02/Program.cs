using System.Globalization;
namespace Assignment_02
{
    #region Q1

    public enum Security_Level
    {
        Guest,
        Developer,
        Secretary,
        DBA
    }

    public class Employee
    {
        // Properties
        public int ID { get; set; }
        public string Name { get; set; }
        private string gender = "M";
        public string Gender
        {
            get { return gender; }
            set
            {
                if (value == "M" || value == "F")
                {
                    gender = value;
                }
                else
                {
                    throw new ArgumentException("Gender must be 'M' (Male) or 'F' (Female).");
                }
            }
        }
        public Security_Level SecurityPrivilege { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }

        // Constructor
        public Employee(int _id, string _name, string _gender, Security_Level _securityPrivilege,
                        decimal _salary, DateTime _hireDate)
        {
            ID = _id;
            Name = _name;
            Gender = _gender;
            SecurityPrivilege = _securityPrivilege;
            Salary = _salary;
            HireDate = _hireDate;
        }

        // Override ToString() method
        public override string ToString()
        {
            return $"Employee ID: {ID}\n" +
                   $"Name: {Name}\n" +
                   $"Gender: {(Gender == "M" ? "Male" : "Female")}\n" +
                   $"Security Level: {SecurityPrivilege}\n" +
                   $"Salary: {DisplaySalary()}\n" +
                   $"Hire Date: {HireDate.ToShortDateString()}";
        }

        // Display salary in currency format
        public string DisplaySalary()
        {
            return String.Format(CultureInfo.CurrentCulture, "{0:C}", Salary);
        }
    }

    #endregion

    #region Q2
    public class Hiring_Date
    {
        // Properties
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        // Constructor
        public Hiring_Date(int _day, int _month, int _year)
        {
            if (!IsValidDate(_day, _month, _year))
            {
                throw new ArgumentException("Invalid date. Please provide a valid day, month, and year.");
            }

            Day = _day;
            Month = _month;
            Year = _year;
        }

        // Method to validate the date
        private bool IsValidDate(int _day, int _month, int _year)
        {
            try
            {
                DateTime tempDate = new DateTime(_year, _month, _day);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Override ToString() method 
        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }

    }
    #endregion


    internal class Program
    {
        static void Main(string[] args)
        {
           #region Q3
            // Create an array of Employees (Size 3)
            Employee[] EmpArr = new Employee[3];

            // Create three employees with different security levels
            EmpArr[0] = new Employee(101, "Abd0_7amdy", "M", Security_Level.DBA, 75000m, DateTime.Now);    // DBA
            EmpArr[1] = new Employee(102, "Asmaa_7amdy", "F", Security_Level.Guest, 50000m, DateTime.Now); // Guest
            EmpArr[2] = new Employee(103, "Asmaa_3bdalla", "F", Security_Level.Developer | Security_Level.Guest | Security_Level.Secretary | Security_Level.DBA,
                                           90000m, DateTime.Now); // Security Officer (Full Permissions)

            // Output the Employee details
            foreach (var emp in EmpArr)
            {
                Console.WriteLine(emp.ToString());
                Console.WriteLine("........................................................");
                
            }
            #endregion

           #region Q4

            // Initialize boxing/unboxing counter
            int boxingUnboxingCount = 0;

            // Sort the array based on hire date
            var sortedEmpArr = EmpArr.OrderBy(emp =>
            {
                boxingUnboxingCount++;  // Count boxing/unboxing during comparison
                return emp.HireDate;    // Accessing the HireDate will box the DateTime for comparison
            }).ToArray();

            // Display sorted employee details
            Console.WriteLine("Sorted Employees by Hire Date:");
            foreach (var emp in sortedEmpArr)
            {
                Console.WriteLine(emp.ToString());
                Console.WriteLine("--------------------------------------");
            }

            // Display how many times boxing/unboxing occurred
            Console.WriteLine($"Number of Boxing/Unboxing operations: {boxingUnboxingCount}");

            #endregion
           
        }
    }
}
