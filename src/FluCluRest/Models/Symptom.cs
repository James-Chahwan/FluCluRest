using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluCluRest.Models
{
    public class Symptom
    {
        public string Name { get; set; }
        public bool HasSymptom { get; set; }
        public string Key { get; internal set; }

    }
}
