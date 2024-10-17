using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetParser.Models
{
    public class ENModel
    {
        public class Outcome
        {
            [JsonProperty("G")]
            public string Group { get; set; }

            [JsonProperty("ID")]
            public string Id { get; set; }

            [JsonProperty("IMF")]
            public bool IsMajor { get; set; }

            [JsonProperty("MBS")]
            public string MinBetSelection { get; set; }

            [JsonProperty("N")]
            public string Name { get; set; }

            [JsonProperty("O")]
            public string Odds { get; set; }

            [JsonProperty("OD")]
            public int OddDifference { get; set; }
        }

        public class OutcomeGroup
        {
            [JsonProperty("ID")]
            public string Id { get; set; }

            [JsonProperty("MBS")]
            public string MinBetSelection { get; set; }

            [JsonProperty("N")]
            public string Name { get; set; }

            [JsonProperty("OC")]
            public Dictionary<string, Outcome> Outcomes { get; set; }

            [JsonProperty("SO")]
            public int SelectionOrder { get; set; }
        }

        public class Event
        {
            [JsonProperty("C")]
            public string Category { get; set; }

            [JsonProperty("D")]
            public string Date { get; set; }

            [JsonProperty("DAY")]
            public string Day { get; set; }

            [JsonProperty("HEC")]
            public bool HasExtraConditions { get; set; }

            [JsonProperty("IMF")]
            public bool IsMajorEvent { get; set; }

            [JsonProperty("LN")]
            public string LeagueName { get; set; }

            [JsonProperty("N")]
            public string Name { get; set; }

            [JsonProperty("NID")]
            public string EventId { get; set; }

            [JsonProperty("OCG")]
            public Dictionary<string, OutcomeGroup> OutcomeGroups { get; set; }

            [JsonProperty("S")]
            public string Status { get; set; }

            [JsonProperty("T")]
            public string Time { get; set; }

            [JsonProperty("TYPE")]
            public string Type { get; set; }
        }

        public class Root
        {
            [JsonProperty("Events")]
            public List<Event> Events { get; set; }
        }
    }
}
