using System;

namespace Flippcoin
{
    public class flippCoin
    {
        public int Head = 0;
        public int Tail = 0;
        public void Flip_Coin()
        {
        Console.WriteLine ("Enter how many times do you want to flip a coin");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number <= 0)
            {
                Console.WriteLine("Please enter a correct positive number");
            } 
            else
            {
                for (int i = 0; i < number; i++)
                {
                    Random RandomNumber = new Random();
                    float Random_Number = (float)RandomNumber.NextDouble();
                    if (Random_Number < 0.5)
                    {
                        Head++;
                    }
                    else
                    {
                        Tail++;
                    }

                    //Console.WriteLine(Random_Number);
                }
                Console.WriteLine("Number of Heads occurred; " + Head);
                Console.WriteLine("Numner of Tails occyrred; " + Tail);
                Console.WriteLine("% Head Occured:" + (float)(Head * 100 / number));
                Console.WriteLine("% Tail Occured:" + (float)(Tail * 100 / number));

            }

        }
    }
}
