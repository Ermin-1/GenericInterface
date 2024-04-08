using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInterface.Models
{
    internal class BookRepository : IBookStoreRepository<Book>
    {

        List<Book> books;

        public BookRepository()
        {
            books = new List<Book>()
            {
                new Book()
                { BookID = 1,Title = "C# Programing",Description = "C# for begginers",Author = new Author() {AuthorID = 1,Name = "Ermin"}},


                new Book()
                { BookID = 2,Title = "Java Programing",Description = "Java for begginers",Author = new Author() {AuthorID = 2,Name = "Oskar"}},

                new Book()
                { BookID = 3,Title = "Phyton Programing",Description = "Phyton for begginers",Author = new Author() {AuthorID = 3,Name = "Ludde"}},





            };
        }
        public void Add(Book entity)
        {
            entity.BookID = books.Max(b => b.BookID) +1;
            books.Add(entity);
        }

        public void Delete(int id)
        {
            var book = Find(id);
            books.Remove(book);
        }

        public Book Find(int id)
        {
            var book = books.FirstOrDefault(b => b.BookID == id);
            return book;
        }

        public IEnumerable<Book> GetAll()
        {
            return books;
        }

        public void Update(int id, Book entity)
        {
            var book = Find(id);

            book.Title = entity.Title;

        }
    }
}
