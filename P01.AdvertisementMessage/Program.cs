using System;
using System.Collections.Generic;

namespace P01.AdvertisementMessage
{
    class Message
    {
        public string Phrases { get; set; }
        public string Events { get; set; }
        public string Authors { get; set; }
        public string Cities { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Message> messages = new List<Message>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split('_',
                    StringSplitOptions.RemoveEmptyEntries)
                string 
            }
        }
    }
}
