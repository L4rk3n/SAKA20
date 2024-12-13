using SAKA20_Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAKA20_Common.Repositories
{
    public interface IVinRepository<TVin, TId> where TVin : IVin
    {
        public IEnumerable<TVin> Get();
        public TVin Get(TId id);
        public bool Create(TVin vin);
        public void Update(TId id, TVin vin);
        public void UpdateDispo (TId id,TVin vin);
        public void Delete(TId id);
    }
}
