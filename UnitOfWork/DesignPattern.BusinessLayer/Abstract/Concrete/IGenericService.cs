using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BusinessLayer.Abstract.Concrete
{
    public interface IGenericService<T>
    {
        void TInsert(T t);
        void TDelete(T t);
        void TUpdate(T t);
        List<T> TGetList();
        T TGetById(int id);
        void TMultiUpdate(List<T> t);
    }
}
