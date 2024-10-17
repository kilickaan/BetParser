using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetParser.Models
{
    public class TRModel
    {
        public class BahisSecenegi
        {
            [JsonProperty("G")]
            public string Grup { get; set; }

            [JsonProperty("ID")]
            public string Id { get; set; }

            [JsonProperty("IMF")]
            public bool AnaBahisMi { get; set; }

            [JsonProperty("MBS")]
            public string MinimumBahis { get; set; }

            [JsonProperty("N")]
            public string Isim { get; set; }

            [JsonProperty("O")]
            public string Oran { get; set; }

            [JsonProperty("OD")]
            public int OranFarki { get; set; }
        }

        public class BahisGrubu
        {
            [JsonProperty("ID")]
            public string Id { get; set; }

            [JsonProperty("MBS")]
            public string MinimumBahis { get; set; }

            [JsonProperty("N")]
            public string Isim { get; set; }

            [JsonProperty("OC")]
            public Dictionary<string, BahisSecenegi> BahisSecenekleri { get; set; }

            [JsonProperty("SO")]
            public int Sira { get; set; }
        }

        public class Etkinlik
        {
            [JsonProperty("C")]
            public string Kategori { get; set; }

            [JsonProperty("D")]
            public string Tarih { get; set; }

            [JsonProperty("DAY")]
            public string Gun { get; set; }

            [JsonProperty("HEC")]
            public bool EkKosulVarMi { get; set; }

            [JsonProperty("IMF")]
            public bool AnaEtkinlikMi { get; set; }

            [JsonProperty("LN")]
            public string LigAdi { get; set; }

            [JsonProperty("N")]
            public string Isim { get; set; }

            [JsonProperty("NID")]
            public string EtkinlikId { get; set; }

            [JsonProperty("OCG")]
            public Dictionary<string, BahisGrubu> BahisGruplari { get; set; }

            [JsonProperty("S")]
            public string Durum { get; set; }

            [JsonProperty("T")]
            public string Saat { get; set; }

            [JsonProperty("TYPE")]
            public string Tip { get; set; }
        }

        public class Kok
        {
            [JsonProperty("Events")]
            public List<Etkinlik> Etkinlikler { get; set; }
        }
    }
}
