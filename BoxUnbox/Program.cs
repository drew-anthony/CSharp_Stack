using System;
using System.Collections.Generic;

namespace BoxUnbox
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> boxes = new List<object>();
            boxes.Add(7);
            boxes.Add(28);
            boxes.Add(-1);
            boxes.Add(true);
            boxes.Add("chair");
            int box = 0;
            foreach (var item in boxes)
            {
                if(item is int)
                {
                    box += (int)item;
                    Console.WriteLine(item);
                }
                if(item is bool)
                {
                    Console.WriteLine(item);
                }
                if(item is string)
                {
                    Console.WriteLine(item);
                }
            }
            System.Console.WriteLine(box);
        }
    }
}
