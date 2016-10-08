using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FluCluRest.Models
{
    public class ForecastSuburb
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FCastSubID { get; set; }
        public DateTime forecastDay { get; set; }
        public int sick { get; set; }
        public int sampleSize { get; set; }
        public DateTime ranDate { get; set; }

    }
}
