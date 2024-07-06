using Stack;

internal class Program
{
    private static void Main(string[] args)
    {
        Stk s = new Stk();
        int Choice;
        int value;
        do 
        {
            showOptions();
            Console.WriteLine("Enter your choice");
            Choice = Convert.ToInt32(Console.ReadLine());
            switch (Choice) 
            {
                case 0:
                    Console.WriteLine("Bye");
                    break;
                case 1:
                    if (s.IsFull())
                    {
                        Console.WriteLine("Stack over flow");
                    }
                    else
                    {
                        Console.WriteLine("Not full");
                    }
                    break;
                case 2:
                    if (s.IsEmpty())
                    {
                        Console.WriteLine("Already Empty");
                    }
                    else
                    {
                        Console.WriteLine("there are elements");
                    }
                    break;
                case 3:
                    Console.WriteLine("Enter value to push it");
                    value = Convert.ToInt32(Console.ReadLine());
                    s.push(value);
                    break;
                case 4:
                    s.pop();
                    break;
                case 5:
                    Console.WriteLine("Enter your value");
                    value = Convert.ToInt32(Console.ReadLine());
                    s.search(value);
                    break;
                case 6:
                    s.Display();
                    break;
                default:
                    Console.WriteLine("invaild option");
                    break;
            }
        } while (Choice != 0);
    }
    public static void showOptions() 
    {
        Console.WriteLine("___________________________");
        Console.WriteLine("1-Is full");
        Console.WriteLine("2-Is empty");
        Console.WriteLine("3-push");
        Console.WriteLine("4-pop");
        Console.WriteLine("5-search");
        Console.WriteLine("6-display");
        Console.WriteLine("0-Exit");
        Console.WriteLine("___________________________");
    }
}