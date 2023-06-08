using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public interface InterfazHospital<Z>
    {
        List<Z> GetAll();
        bool Add(Z persona);
        bool Exist(int id);
        bool Delete(int id);
        bool Update(Z id);
    }
}
