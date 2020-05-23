//DAILY ACCOUNTING

using System;
using System.IO;


namespace classes
{
    class csh
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Mate \nToday is");
            Console.WriteLine(DateTime.Now.ToString("dddd, dd MMMM yyyy"));
            
            
            Console.WriteLine("How much did ya spend today ?");   
            int daily = Convert.ToInt32(Console.ReadLine());
            string path = @"C:\Users\expense.txt";


            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                    {

                        sw.WriteLine("This is your daily expense sheet");
                        sw.WriteLine("unworld11");
                    }
            }
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(DateTime.Now.ToString("dddd, dd MMMM yyyy"));
                    sw.WriteLine(daily);
                }
                using (StreamReader sr = File.OpenText(path))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
                           



        }



    }
}