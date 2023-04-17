using System;

namespace GoTo
{
    class Program
    {
        static void Main(string[]args)
        {
            
            Console.WriteLine("***** Checkers *****");

            int[,] checkers = new int[4,4];

            int y = 0;
            bool sqaureValue = true;

        PopulateChecker:

            checkers[y, 0] = Convert.ToInt32(sqaureValue);
            checkers[y, 1] = Convert.ToInt32(!sqaureValue);
            checkers[y, 2] = Convert.ToInt32(sqaureValue);
            checkers[y, 3] = Convert.ToInt32(!sqaureValue);
            sqaureValue = !sqaureValue;
            y++;

            if(y > 3)
                goto Finish;

            goto PopulateChecker;
        
        Finish:



            Console.WriteLine($"{checkers[0,0]} {checkers[0,1]} {checkers[0,2]} {checkers[0,3]} ");
            Console.WriteLine($"{checkers[1,0]} {checkers[1,1]} {checkers[1,2]} {checkers[1,3]} ");
            Console.WriteLine($"{checkers[2,0]} {checkers[2,1]} {checkers[2,2]} {checkers[2,3]} ");
            Console.WriteLine($"{checkers[3,0]} {checkers[3,1]} {checkers[3,2]} {checkers[3,3]} ");



        }
    }   
}