using myCodeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Scrape mypage = new Scrape();

           string value = mypage.ScrapeWebpage("http://msdn.microsoft.com");

            Console.WriteLine(value);
            
        }
    }
}
