using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++) // "++"为递增运算符
            {
                /*
                Console.WriteLine(i); // 功能1：显示每次迭代的i的值
                */

                if (i == 7) // 功能2：当迭代到7的时候，显示下列字符
                {
                    Console.WriteLine("Found seven!");
                    break; //意思是跳出迭代，执行ReadLine
                }
            }


            for (int x = 0; x < 12; x++)
            {
                Console.Write(x);
            }


            Console.ReadLine();
        }
    }
}
// 
