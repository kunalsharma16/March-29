using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace C0727250

// Name :- Kunal Sharma//
  //student id :- c0727250//
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("downloading a file");
            Download();
            Console.ReadLine();
        }


        static void Download()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Download Complete");
        }

    }
}