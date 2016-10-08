using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluCluRest.Models
{
    public interface ISymptomsRepo
    {

        void Add(Symptom item);
        IEnumerable<Symptom> getAll();
        Symptom Find(string SearchName);
        void update(Symptom item);
    }
}
