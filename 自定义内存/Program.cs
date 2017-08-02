using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 自定义内存
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> list = new List<string>();
            while (true)
            {
                
                int _size = Convert.ToInt32(Console.ReadLine());
                list.Clear();
                for (int i = 0; i < _size * 1024 * 1024; i++)
                {
                    list.Add("1");
                }
                
            }
        }
    }
}
