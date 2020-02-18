using System;

namespace QuestionNoOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====Question Number One's Answer =====");

            DateTime startDateTime = Convert.ToDateTime(Console.ReadLine());
            DateTime endDateTime = Convert.ToDateTime(Console.ReadLine());

            double totalCharge = 0;
            DateTime y = new DateTime();
            DateTime x = startDateTime;
            //Console.WriteLine(x.TimeOfDay);
            while (x != endDateTime)
            {
                if (x.TimeOfDay>= new TimeSpan(9, 00, 00) && new TimeSpan(22, 59, 59) <= x.TimeOfDay)
                {
                    x = x.Add(new TimeSpan(0, 0, 20));
                    totalCharge = totalCharge + 0.30;
                    if (x > endDateTime)
                    {
                        var extra = y.Second - x.Second;
                        x = x.Subtract(new TimeSpan(0, 0, extra));
                        Console.WriteLine((x - new TimeSpan(0, 0, 20)) + " + " + extra + " second " + x + " = 30 paisa");
                        x = endDateTime;
                    }
                    else
                    {
                        y = x - new TimeSpan(0, 0, 20);
                        Console.WriteLine(y + " + 20 second " + x + " = 30 paisa");
                    }
                } else if (x.TimeOfDay >= new TimeSpan(0, 00, 00) && new TimeSpan(8, 59, 59) <= x.TimeOfDay)
                {
                    x = x.Add(new TimeSpan(0, 0, 20));
                    totalCharge = totalCharge + 0.20;
                    if (x > endDateTime)
                    {
                        var extra = y.Second - x.Second;
                        x = x.Subtract(new TimeSpan(0,0,extra));
                        Console.WriteLine((x - new TimeSpan(0, 0, 20)) + " + " + extra + " second " + x + " = 20 paisa");
                        x = endDateTime;
                    }
                    else
                    {
                        y = x - new TimeSpan(0, 0, 20);
                        Console.WriteLine((x - new TimeSpan(0, 0, 20)) + " + 20 second " + x + " = 20 paisa");
                    }
                } else
                {
                    x = x.Add(new TimeSpan(0, 0, 20));
                    totalCharge = totalCharge + 0.20;
                    if (x > endDateTime)
                    {
                        var extra = y.Second - x.Second;
                        x = x.Subtract(new TimeSpan(0, 0, extra));
                        Console.WriteLine((x - new TimeSpan(0, 0, 20)) + " + " + extra + " second " + x + " = 20 paisa");
                        x = endDateTime;
                    }
                    else
                    {
                        y = x - new TimeSpan(0, 0, 20);
                        Console.WriteLine((x - new TimeSpan(0, 0, 20)) + " + 20 second " + x + " = 20 paisa");
                    }
                }
            }

            Console.WriteLine(totalCharge + " Taka");
        }
    }
}
