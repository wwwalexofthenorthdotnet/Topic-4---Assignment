namespace Topic_4___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, firstName, lastName, login, userName, itemName1, itemName2;
            int grade, studentID, age, age2;
            double average, salary, value1, value2, itemPrice1, itemPrice2, subTotal, discount, taxCost;
            const double tax = 0.13;


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
            Console.ReadLine();

            Console.WriteLine();
            Console.Write("Enter the First Value: ");
            double.TryParse(Console.ReadLine(), out value1);
            Console.Write("Enter the Second Value: ");
            double.TryParse(Console.ReadLine(), out value2);
            Console.WriteLine(value1 + " + " + value2 + " / 2 = " + (value1 + value2) /2 );
            Console.ReadLine();

            Console.WriteLine();
            Console.Write("Enter the Name of Item 1: ");
            itemName1 = Console.ReadLine();
            Console.Write("Enter the Price of Item 1: $");
            double.TryParse(Console.ReadLine(), out itemPrice1);
            Console.Write("Enter the Name of Item 2: ");
            itemName2 = Console.ReadLine();
            Console.Write("Enter the Price of Item 2: $");
            double.TryParse(Console.ReadLine(), out itemPrice2);
            Console.WriteLine("Receipt: ");
            
            Console.WriteLine("Item 1: \t" + itemName1);
            Console.WriteLine("Price: \t\t" + itemPrice1 .ToString("C"));
            Console.WriteLine("Item 2: \t" + itemName2);
            Console.WriteLine("Price: \t\t" + itemPrice2 .ToString("C"));
            Console.WriteLine("==================");
            subTotal = itemPrice1 + itemPrice2;
            discount = (itemPrice1 + itemPrice2) * 0.2;
            taxCost = (itemPrice1 + itemPrice2 - discount) * tax;
            Console.WriteLine("Subtotal: \t" + subTotal .ToString("C"));
            Console.WriteLine("Discount (20%): " + discount .ToString("C"));
            Console.WriteLine("Tax: \t\t" + taxCost .ToString("C"));
            Console.WriteLine("Total: \t\t" + (subTotal - discount + taxCost) .ToString("C"));
        }
    }
}
