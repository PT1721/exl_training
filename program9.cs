using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    internal class program9
    {
        static void Main(string[] args)
        {
            String[] lines = File.ReadAllLines("d:\\youtube.csv");
            int length = lines.Length;
            /* foreach(string line in lines)
            {
                Console.WriteLine(line);
            }
            */
            Console.WriteLine($"total records : {length-1}");
            string[] channels = new string[length-1];
            long[] views = new long[length-1];
            int c = 0,k=0;
            for(int i = 0; i < length-1; i++) 
            {
                var line = lines[i].Split(",");
                channels[i] = line[4];
                if (channels[i] is "T-Series")
                {
                    views[i]= Convert.ToInt64(line[5]);
                }
            }
            int result = channels.Distinct().Count();
            
            Console.WriteLine("Total unique channels are: " + (result-1));
            var result2 = channels.Distinct();
            Console.WriteLine("Unique channels are :");
            foreach(var  channel in result2)
            {
                Console.WriteLine(channel+" ");
            }
            long max = views.Max();
            Console.WriteLine("Max views for tseries are: " + max);
        }
        
    }
}
