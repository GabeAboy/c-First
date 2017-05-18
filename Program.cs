using System;


namespace helloworld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
          Console.Write("hi");
          int[] array = new int[5] {1,2,3,4,6};
          foreach(var number in array){
            Console.Write(number);
          }
          // for (var i =0; i<5; i++) {
          //   Console.WriteLine(array[i]);
          // }




            //Keep asking user until entered a num between 1-10

            //var num = 0;
            //do
            //{
            //    Console.Write("Enter a number between 1 and 10: ");
            //    num = Convert.ToInt32(Console.ReadLine());
            //} while (num > 10 || num < 1);
            //Console.Write("Finally " + num);

            //Find max of two values
            //var x = 20;
            //var y = 10;
            //Console.Write("Max val is "+Math.Max(x,y));

            //Another
            //int limit;
            //int speed;
            //do
            //{
            //    Console.Write("Enter limit: ");
            //    limit = Convert.ToInt32(Console.ReadLine());
            //} while (limit < 0);
            //Console.Write("Enter your speed: ");
            //speed = Convert.ToInt32(Console.ReadLine());

            //if (limit > speed)
            //{
            //    Console.Write("Under limit");
            //}
            //else if (limit == speed) Console.Write("Cruising speed");
            //else Console.Write("Too fast, slow down");

		}
    }
}
