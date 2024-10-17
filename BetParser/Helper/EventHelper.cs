using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BetParser.Models.ENModel;
using static BetParser.Models.TRModel;

namespace BetParser.Helper
{
    internal class EventHelper
    {
        public static void ProcessEvents(string json, string language)
        {
            switch (language.ToLower())
            {
                case "tr":
                    ConvertTr(JsonConvert.DeserializeObject<List<Etkinlik>>(json));
                    break;
                case "en":
                    ConvertEn(JsonConvert.DeserializeObject<List<Event>>(json));
                    break;
                default:
                    Console.WriteLine("Geçersiz dil seçimi. / Invanlid language selection.");
                    break;
            }
        }
        private static void ConvertEn(List<Event> events)
        {
            foreach (var e in events)
            {
                // Event Information
                Console.WriteLine("=========================================");
                Console.WriteLine($"Event: {e.Name}");
                Console.WriteLine($"Category: {e.Category}  |  League: {e.LeagueName}");
                Console.WriteLine($"Date: {e.Date} ({e.Day})  |  Time: {e.Time}  |  Status: {e.Status}");
                Console.WriteLine("=========================================\n");

                // Table Headers for Outcome Groups
                Console.WriteLine($"{"Outcome Group",-30} {"Min Bet Selection",-20} {"Selection Order",-15}");
                Console.WriteLine(new string('-', 70));

                foreach (var og in e.OutcomeGroups)
                {
                    // Print Outcome Group Info
                    Console.WriteLine($"{og.Value.Name,-30} {og.Value.MinBetSelection,-20} {og.Value.SelectionOrder,-15}");

                    // Outcome Headers
                    Console.WriteLine($"    {"Outcome",-15} {"Group",-10} {"Odds",-10} {"Is Major",-10} {"Odd Diff",-10}");
                    Console.WriteLine($"    {new string('-', 65)}");

                    // Print Each Outcome in the Group
                    foreach (var oc in og.Value.Outcomes)
                    {
                        Console.WriteLine($"    {oc.Value.Name,-15} {oc.Value.Group,-10} {oc.Value.Odds,-10} {oc.Value.IsMajor,-10} {oc.Value.OddDifference,-10}");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine(new string('*', 70));
            }
        }

        private static void ConvertTr(List<Etkinlik> etkinlikler)
        {
            foreach (var etkinlik in etkinlikler)
            {
                // Etkinlik Bilgisi
                Console.WriteLine("=========================================");
                Console.WriteLine($"Etkinlik: {etkinlik.Isim}");
                Console.WriteLine($"Kategori: {etkinlik.Kategori}  |  Lig: {etkinlik.LigAdi}");
                Console.WriteLine($"Tarih: {etkinlik.Tarih} ({etkinlik.Gun})  |  Saat: {etkinlik.Saat}  |  Durum: {etkinlik.Durum}");
                Console.WriteLine("=========================================\n");

                // Bahis Grupları Tablo Başlıkları
                Console.WriteLine($"{"Bahis Grubu",-30} {"Minimum Bahis",-20} {"Sıra",-15}");
                Console.WriteLine(new string('-', 70));

                foreach (var bahisGrubu in etkinlik.BahisGruplari)
                {
                    // Bahis Grubu Bilgisi Yazdırma
                    Console.WriteLine($"{bahisGrubu.Value.Isim,-30} {bahisGrubu.Value.MinimumBahis,-20} {bahisGrubu.Value.Sira,-15}");

                    // Bahis Seçenekleri Başlıkları
                    Console.WriteLine($"    {"Seçenek",-15} {"Grup",-10} {"Oran",-10} {"Ana Bahis",-10} {"Fark",-10}");
                    Console.WriteLine($"    {new string('-', 65)}");

                    // Her Bahis Seçeneğini Yazdırma
                    foreach (var bahisSecenegi in bahisGrubu.Value.BahisSecenekleri)
                    {
                        Console.WriteLine($"    {bahisSecenegi.Value.Isim,-15} {bahisSecenegi.Value.Grup,-10} {bahisSecenegi.Value.Oran,-10} {bahisSecenegi.Value.AnaBahisMi,-10} {bahisSecenegi.Value.OranFarki,-10}");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine(new string('*', 70));
            }
        }
    }
}
