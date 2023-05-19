using System;
class employee
{
    static void Main()
    {
        Random random = new Random();
        int attendance = random.Next(0, 2);

        if (attendance == 0)
        {
            Console.WriteLine("employee is absent");
        }
        else
        {
            Console.WriteLine("employee is present");
        }
    }
}