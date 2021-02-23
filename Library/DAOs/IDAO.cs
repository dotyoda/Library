using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAOs
{
    interface IDAO<T, I>
    {
        T Save(T entity);
        T GetById(I id);
        List<T> GetAll();
        bool Delete(I id);
    }
}
