using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperWeb._1_Infra
{
    interface IDapper<T>
    {
        IEnumerable<T> listar();
        T BuscarPorID(int Id);
        int insert(T item);
        bool Delete(int id,T item);
        bool Update(T item);
    }
}
