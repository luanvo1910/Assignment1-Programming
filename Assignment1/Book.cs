using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Book
    {
        public int Id {get; set;}

        public string Name { get; set; }

        public string Author { get; set; }

        public string Category { get; set; }

        public string PublicationDate { get; set; }

        public List<Book> Books = new List<Book>();

        public void PrintBooks()
        {
            Console.WriteLine("Id\tName\t\tAuthor\t\t\tCategory\tPublication Date");
            foreach (var item in Books)
            {
                Console.WriteLine($"{item.Id}\t{item.Name}\t{item.Author}\t\t{item.Category}\t\t{item.PublicationDate}");
            }
            Console.WriteLine("\n");
        }

        public void PrintBook(int Id)
        {
            Console.WriteLine("Id\tName\t\tAuthor\t\t\tCategory\tPublication Date");
            foreach (var item in Books)
            {
                if (item.Id == Id)
                {
                    Console.WriteLine($"{item.Id}\t{item.Name}\t{item.Author}\t\t{item.Category}\t\t{item.PublicationDate}");
                }         
            }
        }

        public void AddBook(string Name, string Author, string Cate, string publibDate)
        {
            Books.Add(new Book() { Id = Books.Count + 1, Name = Name, Author = Author, Category = Cate, PublicationDate = publibDate });
        }

        public void SearchBook(string searchString)
        {
            foreach(var item in Books)
            {
                if (item.Name == searchString || item.Author == searchString)
                {
                    Console.WriteLine($"ID: {item.Id}\nName: {item.Name}\nAuthor: {item.Author}\nCategory: {item.Category}\nPublication Date: {item.PublicationDate}");
                }    
            }    
        }

        public void Remove(int RemoveId)
        {
            var bookToRemove = Books.Single(b => b.Id == RemoveId);
            Books.Remove(bookToRemove);

        }

        public void Edit(int EditId, string Name, string Author, string Cate, string publibDate)
        {
            var bookToRemove = Books.Single(b => b.Id == EditId);
            Books.Remove(bookToRemove);

            Books.Add(new Book() { Id = EditId, Name = Name, Author = Author, Category = Cate, PublicationDate = publibDate });
        }

    }
}
