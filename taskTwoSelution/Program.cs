namespace taskTwoSelution

{
    internal class Program
    {
        static void Main(string[] args)
        {
            char selection = ' ';
            List<int> list = new List<int>();
            do
            {
                Console.WriteLine("\n---------------------");
                Console.WriteLine("P - Print numbers");
                Console.WriteLine("A - Add a number");
                Console.WriteLine("M - Display mean of the numbers");
                Console.WriteLine("S - Display the smallest number");
                Console.WriteLine("L - Display the largest number");
                Console.WriteLine("F - Find a number");
                Console.WriteLine("c - Clear the list");
                Console.WriteLine("Q. Quit");
                Console.Write("\nEnter your selection: ");
                selection = char.Parse(Console.ReadLine());

                if (selection == 'P' || selection == 'p')
                {
                    if (list.Count == 0)
                    {
                        Console.WriteLine("[] - the list is empty");
                    }
                    else
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            Console.Write($"{list[i]} ");
                        }
                    }
                }
                else if (selection == 'A' || selection == 'a')
                {
                    Console.Write("Enter a value: ");
                    int value = int.Parse(Console.ReadLine());
                    list.Add(value);
                    Console.WriteLine($"{value} added");
                }
                else if (selection == 'M' || selection == 'm')
                {
                    if (list.Count == 0)
                    {
                        Console.WriteLine("Unable to calculate the mean - no data");
                    }
                    else
                    {
                        int sum = 0;
                        for (int i = 0; i < list.Count; i++)
                        {
                            sum += list[i];
                        }
                        Console.WriteLine($"Mean: {sum / list.Count}");
                    }
                }
                else if (selection == 'S' || selection == 's')
                {
                    int smallest = list[0];
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] < smallest)
                        {
                            smallest = list[i];
                        }
                    }
                    Console.WriteLine($"Smallest: {smallest}");
                }
                else if (selection == 'L' || selection == 'l')
                {
                    int largest = list[0];
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] > largest)
                        {
                            largest = list[i];
                        }
                    }
                    Console.WriteLine($"Largest : {largest}");
                }
                else if (selection == 'C' || selection == 'c')
                {
                    list.Clear();
                    Console.WriteLine("List is Clear now ^_^ ");
                }
                else if (selection == 'Q' || selection == 'q')
                    Console.WriteLine("Good bye...");
                else
                    Console.WriteLine("Out of the range");
            } while (selection != 'Q' && selection != 'q');
        }
    }
}
