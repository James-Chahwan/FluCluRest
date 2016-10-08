using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluCluRest.Models
{
    public interface IReporteeRepo
    {
        void Add(Reportee item);
        IEnumerable<Reportee> getAll();
        Reportee Find(string key);
        void update(Reportee item);
    }
}
