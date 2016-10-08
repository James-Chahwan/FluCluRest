using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace FluCluRest.Models
{
    public class ReporteeRepository : IReporteeRepo
    {
        private static ConcurrentDictionary<string, Reportee> _reportees = new ConcurrentDictionary<string, Reportee>();
        public ReporteeRepository()
        {
            Symptom flu = new Symptom { Name = "flu", HasSymptom = true };
            Symptom vomiting = new Symptom { Name = "vomiting", HasSymptom = false };
            List<Symptom> sympsList = new List<Symptom>();
            sympsList.Add(flu);
            sympsList.Add(vomiting);
            Add(new Reportee { Longitude = "45", Latitude = "45", SympList = sympsList });
            Add(new Reportee { Longitude = "27", Latitude = "45", SympList = sympsList });
            Add(new Reportee { Longitude = "35", Latitude = "38", SympList = sympsList });
            Add(new Reportee { Longitude = "26", Latitude = "22", SympList = sympsList });
            Add(new Reportee { Longitude = "11", Latitude = "37", SympList = sympsList });
        }
        public void Add(Reportee item)
        {
            item.Key = Guid.NewGuid().ToString();
            _reportees[item.Key] = item;
        }
        public Reportee Find(string key)
        {
            Reportee item;
            _reportees.TryGetValue(key, out item);
            return item;
        }
        public void Update(Reportee item)
        {
            _reportees[item.Key] = item;
        }
        public IEnumerable<Reportee> GetAll()
        {
            return _reportees.Values;
        }

        public IEnumerable<Reportee> getAll()
        {
            return _reportees.Values;
        }

        public void update(Reportee item)
        {
            throw new NotImplementedException();
        }
    }
}
