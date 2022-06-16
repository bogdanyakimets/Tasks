//namespace Tasks;
//Пользователь вводит с клавиатуры расстояние,
//расход бензина на 100 км и стоимость трех 
//видов бензина.
//Вывести на экран сравнительную таблицу со стоимостью поездки на разных 
//видах бензина.

public class Task1
{
    public void Tasks()
    {
        double Растояние = 0;
        double Расход = 0;
        double A93 = 0;
        double A95 = 0;
        double A98 = 0;
        double Расход2 = 0;




        Console.WriteLine("Введите растояние в КМ");
        Растояние = double.Parse(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("Введите расход бензина на 100км");
        Расход = double.Parse(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("Введите стоимость первого бензина");
        A93 = double.Parse(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("Введите стоимость второго бензина");
        A95 = double.Parse(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("Ведите стоимость третьего бензина");
        A98 = double.Parse(Console.ReadLine());
        Console.Clear();

        Расход2 = (Растояние / 100 * Расход);

        Console.WriteLine("Цены на поездки на разных бензинах");



        Console.WriteLine(Расход2 * A93);



        Console.WriteLine(Расход2 * A95);



        Console.WriteLine(Расход2 * A98);

        Console.Clear();

        for (int z = 0; z <= 79; z++)
        {
            Console.Write("_");
        }

        Console.WriteLine("|\t A93 \t | \t A95 \t | \t A98 \t |");

        Console.WriteLine("|\t  \t | \t  \t | \t   \t |");

        Console.WriteLine($"|\t  {A93}  \t | \t  {A95} \t | \t {A98} \t |");

        Console.WriteLine("|\t  \t | \t  \t | \t   \t |");

        for (int x = 0; x <= 79; x++)
        {
            Console.Write("_");
        }



        Thread.Sleep(20000);
        Console.Clear();
   }
}