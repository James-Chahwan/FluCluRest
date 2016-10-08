using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluCluRest.Models
{
    public class symptomsRepository : ISymptomsRepo
    {
        private static ConcurrentDictionary<string, Symptom> _Symptoms = new ConcurrentDictionary<string, Symptom>();
        public symptomsRepository()
        {
            Symptom flu = new Symptom { Name = "flu", HasSymptom = false };
            Symptom vomiting = new Symptom { Name = "vomiting", HasSymptom = false };
            Symptom headache = new Symptom { Name = "headache", HasSymptom = false };
            Symptom fever = new Symptom { Name = "fever", HasSymptom = false };
            Symptom coughing = new Symptom { Name = "coughing", HasSymptom = false };
            Symptom earAche = new Symptom { Name = "ear ache", HasSymptom = false };
            Add(flu);
            Add(vomiting);
            Add(headache);
            Add(fever);
            Add(coughing);
            Add(earAche);
        }
        public void Add(Symptom item)
        {
            item.Key = Guid.NewGuid().ToString();
            _Symptoms[item.Key] = item;
        }

        public Symptom Find(string SearchName)
        {
            Symptom item;
            _Symptoms.TryGetValue(SearchName, out item);
            return item;
        }

        public IEnumerable<Symptom> getAll()
        {
             return _Symptoms.Values;
        }

        public void update(Symptom item)
        {
            _Symptoms[item.Key] = item;
        }
    }
}
