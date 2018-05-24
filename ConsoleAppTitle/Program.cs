using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppTitle
{
    class Program
    {
        static void Main(string[] args)
        {

            string progressBar = "Hello how are you today?";

            var title = "";


            for (int i = 0 ;i < progressBar.Length;i++)
            {
                title += progressBar[i];
                Console.Title = title;
                Thread.Sleep(100);
            }

            title = "";
        }
    }
}
