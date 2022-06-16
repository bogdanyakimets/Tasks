namespace Tasks;
public class Task4
{
    public void Tasks()
    {
        string symbol = "#################";
        string space = " ";

        for (int i = 0; i < 10; i++)
        {
            Console.Write(space);
            Console.Write(symbol);
            Console.WriteLine();
            symbol = symbol.Remove(0, 2);
            space += " ";
        }
        Console.ReadLine();
    }
}