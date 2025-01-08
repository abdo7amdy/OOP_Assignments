namespace OOP_Assignment_01
{
    // Define the WeekDays enum
    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    // Define the Person struct
    struct Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    // Define the Season enum
    enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }

    // Define the Colors enum
    enum Colors
    {
        Red,
        Green,
        Blue
    }

    // Define the Point struct
    struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    } 

    #region Additional Question 
    public struct Rectangle
        {
            private double width;
            private double height;

            // Public property for Width with validation
            public double Width
            {
                get { return width; }
                set
                {
                    if (value >= 0)
                    {
                        width = value;
                    }
                    else
                    {
                        Console.WriteLine("Error: Width cannot be negative.");
                    }
                }
            }

            // Public property for Height with validation
            public double Height
            {
                get { return height; }
                set
                {
                    if (value >= 0)
                    {
                        height = value;
                    }
                    else
                    {
                        Console.WriteLine("Error: Height cannot be negative.");
                    }
                }
            }

            // Constructor to initialize the fields
            public Rectangle(double width, double height)
            {
                this.width = 0;
                this.height = 0;
                Width = width;  // Uses the property to apply validation
                Height = height; // Uses the property to apply validation
            }

            // Public read-only property for Area
            public double Area
            {
                get { return width * height; }
            }

            // Method to display the rectangle's dimensions and area
            public void DisplayInfo()
            {
                Console.WriteLine($"Rectangle Dimensions: Width = {width}, Height = {height}");
                Console.WriteLine($"Area = {Area}");
            }
        }

    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //for (int i = 0; i <= (int)WeekDays.Sunday; i++)
            //{
            //    Console.WriteLine((WeekDays)i);
            //}
            #endregion

            #region Q2
            //// Create and populate an array of Person objects
            //Person[] people = new Person[3];
            //people[0] = new Person("Lian", 25);
            //people[1] = new Person("Raghad", 30);
            //people[2] = new Person("Ahmed", 35);
            //// Display details of each person
            //Console.WriteLine("\nDetails of Persons:");
            //foreach (var person in people)
            //{
            //    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            //}
            #endregion

            #region Q3
            // Season input and corresponding month range
            //Console.WriteLine("\nEnter a season (Spring, Summer, Autumn, Winter):");
            //string? input = Console.ReadLine();

            //if (Enum.TryParse(input, true, out Season seazon))
            //{
            //    switch (seazon)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("Spring: March to May");
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine("Summer: June to August");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine("Autumn: September to November");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine("Winter: December to February");
            //            break;
            //        default:
            //            Console.WriteLine("Invalid season.");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid season.");
            //}
            #endregion

            #region Q5
            // Colors input to check for primary color
            //Console.WriteLine("\nEnter a color (Red, Green, Blue):");
            //string? colorInput = Console.ReadLine();

            //if (Enum.TryParse(colorInput, true, out Colors color))
            //{
            //    switch (color)
            //    {
            //        case Colors.Red:
            //        case Colors.Green:
            //        case Colors.Blue:
            //            Console.WriteLine($"{color} is a primary color.");
            //            break;
            //        default:
            //            Console.WriteLine($"{color} is not a primary color.");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid color.");
            //}
            #endregion

            #region Q6
            // Calculate distance between two points without using 
            //    Console.WriteLine("\nEnter coordinates for the first point (X Y):");
            //    string[] point1Input = Console.ReadLine().Split(' ');
            //    Point point1 = new Point(double.Parse(point1Input[0]), double.Parse(point1Input[1]));

            //    Console.WriteLine("Enter coordinates for the second point (X Y):");
            //    string[] point2Input = Console.ReadLine().Split(' ');
            //    Point point2 = new Point(double.Parse(point2Input[0]), double.Parse(point2Input[1]));

            //    double xDiff = point2.X - point1.X;
            //    double yDiff = point2.Y - point1.Y;
            //    double distance = SquareRoot(xDiff * xDiff + yDiff * yDiff);
            //    Console.WriteLine($"The distance between the two points is: {distance:F2}");
            //}

            //// Custom square root calculation using the Babylonian method
            //static double SquareRoot(double number)
            //{
            //    if (number < 0) return -1; // Invalid for negative numbers

            //    double guess = number / 2;
            //    double epsilon = 0.00001; // Precision level

            //    while (Math.Abs(guess * guess - number) > epsilon)
            //    {
            //        guess = (guess + number / guess) / 2;
            //    }

            //    return guess;
            #endregion

            #region Q7

            //Person[] people = new Person[3];

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"\nEnter details for person {i + 1}:");
            //    Console.Write("Name: ");
            //    string? name = Console.ReadLine();
            //    Console.Write("Age: ");
            //    int age = int.Parse(Console.ReadLine());

            //    people[i] = new Person(name, age);
            //}

            //// Find the oldest person
            //Person oldest = people[0];
            //for (int i = 1; i < people.Length; i++)
            //{
            //    if (people[i].Age > oldest.Age)
            //    {
            //        oldest = people[i];
            //    }
            //}

            //Console.WriteLine($"\nThe oldest person is {oldest.Name} with age {oldest.Age}.");

            #endregion

           
        }
    }
}
