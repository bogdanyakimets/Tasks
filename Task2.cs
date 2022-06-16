namespace Tasks;

//The user enters from the keyboard the distance to the airport and the time,
//for which you need to get there. Calculate the speed,
//with which he needs to go

public class Task2
{
    public void Tasks()
    {
        double distance = 0;
        double time = 0;
        double speed = 0;


        Console.WriteLine("Enter the distance to the airport");
        distance = double.Parse(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("Enter the time you need to arrive at the airport");
        time = double.Parse(Console.ReadLine());
        Console.Clear();

        speed = distance / time;
        Console.WriteLine($"You need to drive at speed {speed} km/h");

        Thread.Sleep(15000);
        Console.Clear();
    }
}