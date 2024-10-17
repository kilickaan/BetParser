using BetParser.Helper;
using System;
using System.IO;

namespace BetParser
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Lütfen dil seçin: [tr] Türkçe, [en] İngilizce");
            
            try
            {
                string lang = Console.ReadLine();
                string jsonStr = ReadHelper.ReadJsonFile(Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName, "File", "bets.json"));
                if (!string.IsNullOrEmpty(jsonStr))
                {
                    EventHelper.ProcessEvents(jsonStr, lang);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}