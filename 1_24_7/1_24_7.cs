
namespace _1_24_7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int choice = 0;


            do
            {
                Console.WriteLine("\n" + "TIME UNIT CONVERSION");
                Console.WriteLine("\n" + "Please choose your unit of conversion: ");
                Console.WriteLine("1. Convert seconds to minutes.");
                Console.WriteLine("2. Convert minutes to hours");
                Console.WriteLine("3. Convert hours to days");
                Console.WriteLine("4. Convert days to months.");
                Console.WriteLine("5. Exit the program.");
                Console.Write("\n" + "Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the number of second/s: ");
                        float seconds = Convert.ToInt32(Console.ReadLine());
                        float minutes = seconds / 60;
                        if (seconds == 1)
                        {
                            Console.WriteLine("\n" + $"{seconds} second is {minutes} minutes.");
                        }
                        else
                        {
                            if (minutes == 1)
                            {
                                Console.WriteLine("\n" + $"{seconds} seconds is {minutes} minute.");
                            }
                            else
                            {
                                Console.WriteLine("\n" + $"{seconds} seconds is {minutes} minutes.");
                            }
                        }

                        break;

                    case 2:
                        Console.Write("Enter the number of minute/s: ");
                        float minutes2 = Convert.ToInt32(Console.ReadLine());
                        float hour = minutes2 / 60;
                        if (minutes2 == 1)
                        {
                            Console.WriteLine("\n" + $"{minutes2} minute is {hour} hours.");
                        }
                        else
                        {
                            if (hour == 1)
                            {
                                Console.WriteLine("\n" + $"{minutes2} minutes is {hour} hour.");
                            }
                            else
                            {
                                Console.WriteLine("\n" + $"{minutes2} minutes is {hour} hours.");
                            }
                        }

                        break;

                    case 3:
                        Console.Write("Enter the number of hour/s: ");
                        float hour2 = Convert.ToInt32(Console.ReadLine());
                        float day = hour2 / 24;
                        if (hour2 == 1)
                        {
                            Console.WriteLine("\n" + $"{hour2} hour is {day} days.");
                        }
                        else
                        {
                            if (day == 1)
                            {
                                Console.WriteLine("\n" + $"{hour2} hours is {day} day.");
                            }
                            else
                            {
                                Console.WriteLine("\n" + $"{hour2} hours is {day} days.");
                            }
                        }

                        break;

                    case 4:
                        Console.Write("Enter the number of day/s: ");
                        float day2 = Convert.ToInt32(Console.ReadLine());
                        float months = day2 / 30;
                        if (day2 == 1)
                        {
                            Console.WriteLine("\n" + $"{day2} day is {months} months.");
                        }
                        else
                        {
                            if (months == 1)
                            {
                                Console.WriteLine("\n" + $"{day2} days is {months} month.");
                            }
                            else
                            {
                                Console.WriteLine("\n" + $"{day2} days is {months} months.");
                            }
                        }

                        break;

                    case 5:
                        Console.WriteLine("Exiting the program... Thank you!");
                        return;

                    default:
                        Console.WriteLine("Invalid input. Please choose in the numbers 1 to 4 in Time Unit Conversion.");
                        break;
                }

            }

            while (choice > 0);

        }
    }
}
