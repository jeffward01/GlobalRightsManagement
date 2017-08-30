using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace GRM.UI_Inter
{
    public static class CommonMethods
    {
        public static void WriteLine(string message)
        {
            Console.WriteLine(message);
        }

        public static void Write(string message)
        {
            Console.Write(message);
        }

        public static string ReadLine()
        {
            return Console.ReadLine();
        }

        public static void Line()
        {
            WriteLine("------------------------------------------------------");
        }

        public static void Space()
        {
            Console.WriteLine("\n");
        }

        public static void SpaceSm()
        {
            Space();
        }
        public static void SpaceMed()
        {
            Space();
            Space();
        }

        public static void SpaceLg()
        {
            Space();
            Space();
            Space();
            Space();
        }
    }

}

