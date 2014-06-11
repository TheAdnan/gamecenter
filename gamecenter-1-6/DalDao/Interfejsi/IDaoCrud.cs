using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Interfejsi
{
    public interface IDaoCrud<T>
    {
        void create(T entity);
        T read(T entity);
        T update(T entity);
        void delete(T entity);
        T getById(int id);
        List<T> getAll();
        List<T> getByExample(string name, string value);
    }
}