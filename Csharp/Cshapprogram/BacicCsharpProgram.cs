using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Cshapprogram
{
    public class BacicCsharpProgram
    {
        public static void FindMax()
        {
            Console.WriteLine("Enter the first number : ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number : ");
            int n2 = int.Parse(Console.ReadLine());
            if (n1 > n2)
            {
                Console.WriteLine("Max is :" + n1);
            }
            else
            {
                Console.WriteLine("Max is :" + n2);
            }
        }


    }

    
}
