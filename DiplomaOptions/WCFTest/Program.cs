using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WCFTest
{
    class Program
    {
        //This is for testing the WCF service
        static void Main(string[] args)
        {
            StudentOptionsService.StudentOptionsServiceClient pxy = new StudentOptionsService.StudentOptionsServiceClient();

            pxy.boolsubmitOptions("", "", "", "", "", "", "");
            Console.ReadKey();
        }
    }
}
