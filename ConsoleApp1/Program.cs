using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;
using System.Net.Http;

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


        static async void Download()
        {
            await Network.Download();
            Console.WriteLine("Download complete");
        }
    }

    class Network
    {
        private static object i;
        ArrayList WebPageContents = new ArrayList();
        public static async Task Download()
        {
            HttpClient client = new HttpClient();
            String data = await client.GetStringAsync("http://torontopubliclibrary.ca");
            // Console.WriteLine(data);
            foreach (var line in data)
            {
                WebPageContents.Add(i);
            }
        }
    }
}