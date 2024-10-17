using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetParser.Helper
{
    public class ReadHelper
    {
        public static string ReadJsonFile(string filePath)
        {
            // Dosya mevcut mu kontrol et ve JSON verisini oku
            if (File.Exists(filePath))
            {
                try
                {
                    return File.ReadAllText(filePath);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
            else
            {
                Console.WriteLine("bets.json dosyası bulunamadı.");
                return null;
            }
        }
    }
}