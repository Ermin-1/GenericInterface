using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInterface.Models
{
    internal interface IBookStoreRepository<TEntity>
    {
        IEnumerable<TEntity>GetAll();

        TEntity Find(int id);

        void Add(TEntity entity);
        void Delete(int id);
        void Update(int id, TEntity entity);


    }
}
