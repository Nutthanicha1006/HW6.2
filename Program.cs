using System;

namespace HW6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int meat, amb,  pq;
            double kg, amkg, p;

            Console.WriteLine();
            Console.WriteLine("             meat price          ");
            Console.WriteLine("     1. Pork        -> 150 Bath/kg");
            Console.WriteLine("     2. Chicken     ->  70 Bath/kg");
            Console.WriteLine(" --------------------------------------");
            Console.Write(" Choose the meat you want (1 or 2) : ");
            meat = int.Parse(Console.ReadLine());
            while (meat != 1 && meat != 2)
            {
                Console.WriteLine("      Please input 1 or 2");
                Console.Write(" Choose the meat you want (1 or 2) : ");
                meat = int.Parse(Console.ReadLine());
            }
            switch (meat)
            {
                case 1:
                    Console.WriteLine();
                    Console.Write(" Want to enter price(1) or quantity(2) : ");
                    pq = int.Parse(Console.ReadLine());
                    while (pq != 1 && pq != 2)
                    {
                        Console.WriteLine("      Please input 1 or 2");
                        Console.Write(" Want to enter price(1) or quantity(2) : ");
                        pq = int.Parse(Console.ReadLine());
                    }
                    switch (pq)
                    {
                        case 1:
                            Console.WriteLine();
                            Console.Write(" Amount (Bath) : ");
                            amb = int.Parse(Console.ReadLine());
                            kg = amb / 150.0;
                            Console.WriteLine(" --------------------------------------");
                            Console.WriteLine(" You will got {0} kg.", kg);
                            break;
                        case 2:
                            Console.WriteLine();
                            Console.Write(" Amount (kg) : ");
                            amkg = double.Parse(Console.ReadLine());
                            p = amkg * 150.0;
                            Console.WriteLine(" --------------------------------------");
                            Console.WriteLine(" Your pork costs {0} bath.", p);
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine();
                    Console.Write(" Want to enter price(1) or quantity(2) : ");
                    pq = int.Parse(Console.ReadLine());
                    while (pq != 1 && pq != 2)
                    {
                        Console.WriteLine("      Please input 1 or 2");
                        Console.Write(" Want to enter price(1) or quantity(2) : ");
                        pq = int.Parse(Console.ReadLine());
                    }
                    switch (pq)
                    {
                        case 1:
                            Console.WriteLine();
                            Console.Write(" Amount (Bath) : ");
                            amb = int.Parse(Console.ReadLine());
                            kg = amb / 70.0;
                            Console.WriteLine(" --------------------------------------");
                            Console.WriteLine(" You will got {0} kg.", kg);
                            break;
                        case 2:
                            Console.WriteLine();
                            Console.Write(" Amount (kg) : ");
                            amkg = double.Parse(Console.ReadLine());
                            p = amkg * 70.0;
                            Console.WriteLine(" --------------------------------------");
                            Console.WriteLine(" Your chicken costs {0} bath.", p);
                            break;
                    }
                    break; 
            }
            Console.ReadLine();
        }
    }
}
