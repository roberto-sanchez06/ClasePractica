using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IModel<T>
    {
        void Create(T t);
        bool Delete(T t);
        int Update(T t);
        T[] FindAll();
    }
}
