namespace Topic_4___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, firstName, lastName, login, userName;
            int grade, studentID, age, age2;
            double average, salary;

            Console.WriteLine("Hello, What is your Name?");
            name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Hi " + name + " How old are you?");
            Int32.TryParse(Console.ReadLine(), out age);
            Console.WriteLine();
            Console.WriteLine("So you're " + age + " eh? That's not old at all! What is your current salary " + name);
            double.TryParse(Console.ReadLine(), out salary);
            Console.WriteLine();
            Console.WriteLine(salary + " Hope that's per hour and not per year!");
            Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Please Enter the Following information: ");
            Console.Write("First Name: ");
            firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            lastName = Console.ReadLine();
            Console.Write("Grade (9-12): ");
            Int32.TryParse(Console.ReadLine(), out grade);
            Console.Write("Student ID: ");
            Int32.TryParse(Console.ReadLine(), out studentID);
            Console.Write("Login: ");
            login = Console.ReadLine();
            Console.Write("Average: ");
            double.TryParse(Console.ReadLine(), out average);
            Console.WriteLine();

            Console.WriteLine("Your Information: ");
            Console.WriteLine("Login: \t " + login);
            Console.WriteLine("ID: \t " + studentID);
            Console.WriteLine("Name: \t " + lastName + ", " + firstName);
            Console.WriteLine("Average: " + average + "%");
            Console.WriteLine("Grade: \t " + grade);
            Console.ReadLine();

            Console.WriteLine();
            Console.Write("Enter Name ");
            userName = Console.ReadLine();
            Console.Write("Hi " + userName + ", How old are you? ");
            Int32.TryParse(Console.ReadLine(), out age2);
            Console.WriteLine("Did you know that in 5 years you will be " + (age2 + 5) + " years old? And 5 years ago you were " + (age2 - 5) + "! Imagine That!");
        }
    }
}
