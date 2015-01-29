using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyRCP.Helpers;
using System.IO;
using System.Diagnostics;

    public static class TestDataGlobals
    
           
    {
        private static string _globalTestFirstName = "";
        private static string _globalTestLastName = "";
        private static string _globalTestEmail = "";

        
        /// <summary>
        /// Now get the value from the file to add the next number
        /// 
        /// </summary>

        public static string GlobalTestFirstName 

        {
            get { return _globalTestFirstName + GetNextTestUser().ToString(); }
            set { _globalTestFirstName = value;}
        }

        public static string GlobalTestLastName
        {
            get { return _globalTestLastName + GetNextTestUser().ToString(); }
            set { _globalTestLastName = value; }
        }

        public static string GlobalTestEmail
        {
            get { return _globalTestEmail + GetNextTestUser().ToString() + "@gmail.com"; }
            set { _globalTestEmail = value; }
        }
                


        // Read a text file to user to append in the user name in order to create a new one.
       
        public static int GetNextTestUser()
        {
            StreamReader sw = new StreamReader(@"C:\paolo.txt");
            string val = sw.ReadToEnd();
            sw.Close();
            return int.Parse(val);
        }



        //The value is incremented once the test has passed.Called from the results page   
        public static void IncrementLastUser()
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


        public static TimeSpan Time(Action action)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            action();
            stopwatch.Stop();
            return stopwatch.Elapsed;
        }

    }

