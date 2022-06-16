namespace Tasks;
//The user enters any integer.
//We need to remove all the digits 3 and 6
//from this integer and display it back on the screen.
public class Task3
{
    public void Tasks()
    {
        Console.WriteLine("Write numbers");

        string str = Console.ReadLine();
        string result = str;
        bool check = true;
        while (check)
        {
            if (result.Contains('6'))
                result = result.Remove(result.IndexOf("6"), 1);
            else if (result.Contains('3'))
                result = result.Remove(result.IndexOf("3"), 1);
            else
               check = false;
            Console.WriteLine($"result = {result}");
        }

    }
}