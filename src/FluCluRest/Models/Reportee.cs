using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace FluCluRest.Models
{
    public class Reportee
    {
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public List<Symptom> SympList { get; set; }

        public string Key { get; internal set; }
    }
}
