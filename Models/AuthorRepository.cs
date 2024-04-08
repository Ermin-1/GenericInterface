using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInterface.Models
{
    internal class AuthorRepository : IBookStoreRepository<Author>
    {
        public void Add(Author entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Author Find(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Author> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Author entity)
        {
            throw new NotImplementedException();
        }
    }
}
