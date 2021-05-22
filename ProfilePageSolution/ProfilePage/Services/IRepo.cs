using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProfilePage.Services
{
   public interface IRepo<T>
    {

        IEnumerable<T> GetAll();
       
        void Add(T t);
       
       
    }
}
