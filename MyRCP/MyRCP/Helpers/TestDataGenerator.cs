using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace MyRCP.Helpers
{
    public static class TestDataGenerator
    {

        public static int GetLastEmail()
        {
            StreamReader sw = new StreamReader(@"C:\paolo.txt");
            string val = sw.ReadToEnd();
            sw.Close();
            return int.Parse(val);

        }

        public static void IncrementLastEmail()
        {
            StreamReader sr = new StreamReader(@"C:\paolo.txt");
            string val = sr.ReadToEnd();
            sr.Close();
            int LastValue = int.Parse(val) + 1;


            StreamWriter sw = new StreamWriter(@"C:\paolo.txt");
            sw.Write(LastValue.ToString());
            sw.Flush();
            sw.Close();
        }




    }
}
