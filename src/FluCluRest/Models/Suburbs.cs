using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FluCluRest.Models
{
    public class Suburbs
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SuburbID { get; set; }
        public string name { get; set; }
        public int population { get; set; }
        public string coords { get; set; }
    }
}
