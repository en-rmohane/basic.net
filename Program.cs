using System;
class emp1
{
    static void main()
    {
        Random random = new Random();
        int check = random.Next(1, 4);
        int wagePerHoure = 20;
        int FullDay = 8;
        int patrtime = 8;
        int dailywage;

        if (check==1)
        {
            dailywage = wagePerHoure * FullDay;
            Console.WriteLine("employee is present");

        }
        else if (check==2)
        {
            dailywage = 0;
            Console.WriteLine("employee is absent");
        }
        else if (check ==3)
        {
            dailywage = wagePerHoure * patrtime;
            Console.WriteLine("employee is part time working");
        }
        else
        {
            dailywage = 0;
            Console.WriteLine("invalid employee status");
        }
        Console.WriteLine("Daily wages is $" + dailywage);
    }
}