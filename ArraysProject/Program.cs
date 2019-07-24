using System;

namespace ArraysProject {
    class Program {
        static void Main(string[] args)
        {
            int[] frames = new int[10];

            frames[0] = 30;
            frames[1] = 30;
            frames[2] = 27;
            frames[3] = 30;
            frames[4] = 30;
            frames[5] = 25;
            frames[6] = 30;
            frames[7] = 30;
            frames[8] = 27;
            frames[9] = 30;

            int total = 0;
            int index = 0;
            while (index < 10)
            {
                total = total + frames[index];
                index = index + 1;
            }
            Console.WriteLine($"Total is {total}.");
        }
    }
}