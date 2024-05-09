using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Reflection;
namespace system32_roullete
{
    class Program
    {
        static void Main(string[] args)
        {
            string appDirectory = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            string dfilename = "DealersFile.txt";
            string dfilepath = Path.Combine(appDirectory, dfilename);
            string filecontent = "skibidi toilet";
            int i = 0;
            Random random = new Random();
            Console.WriteLine("Input file you want to bet...");
            string filepath = Console.ReadLine();
            if (File.Exists(filepath))
            {
                Console.WriteLine("file is at gunpoint");
            }
            else
            {
                Console.WriteLine("LIAR!!!! DELETING SYSTEM32");
                Thread.Sleep(8000);
                Environment.Exit(0);
            }
            int[] bullets = { 0, 0, 0, 0, 0, 0 };
            bullets[random.Next(0, 5)] = 1;
           // Console.WriteLine(""+bullets[0]+ bullets[1]+ bullets[2]+ bullets[3]+ bullets[4] + bullets[5] );
            Console.ReadKey();
            while (true)
            {
                Console.WriteLine("shot number " + i++);
                Console.WriteLine("get ready");
                Thread.Sleep(1000);
                Console.Clear();
                if(bullets[i] == 1)
                {
                    
                    Console.WriteLine("you die");
                    Thread.Sleep(1000);
                    Console.Clear();
                    File.Delete(filepath);
                    Console.WriteLine("file:" + filepath + " died");
                    Console.WriteLine("goodbye");
                    Thread.Sleep(2000);
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("empty");
                    Thread.Sleep(2000);
                    i++;
                }
                Console.ReadKey();
                Console.WriteLine("Dealers Turn");
                Thread.Sleep(1000);
                if (bullets[i] == 1)
                {
                    Console.WriteLine("you won");
                    Thread.Sleep(1000);
                    Console.WriteLine("now you get the dealer's file");
                    File.WriteAllText(dfilepath,filecontent);
                    Environment.Exit(0);
                }
                Console.WriteLine("dealer's empty");
                Console.ReadKey();
            }
        }
    }
}
