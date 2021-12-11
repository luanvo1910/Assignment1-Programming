using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Application
    {
        public void Direction()
        {
            Book Book = new Book();
            int choice, removeId, editId, confirm;
            string name, author, category, publicDate;
            do
            {
                Console.Clear();
                Book.PrintBooks();
                Console.Write("What will you do?\n1. Search book\n2. Add a new book\n3. Remove book\n4. Edit book\n5. End\nChoice: ");
                choice = int.Parse(Console.ReadLine());
                
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter name of Book or Author to search: ");
                        string Search = Console.ReadLine();

                        Book.SearchBook(Search);
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.Write("Enter Name: ");
                        name = Console.ReadLine();
                        Console.Write("Enter Author: ");
                        author = Console.ReadLine();
                        Console.Write("Enter Category: ");
                        category = Console.ReadLine();
                        Console.Write("publication Date: ");
                        publicDate = Console.ReadLine();
                        Book.AddBook(name, author, category, publicDate);
                        break;
                    case 3:
                        Console.Write("Enter book's Id to remove book: ");
                        removeId = int.Parse(Console.ReadLine());
                        Book.PrintBook(removeId);
                        Console.Write("Please confirm to delete this book!\n1. Yes\n2. No\nChoice: ");
                        confirm = int.Parse(Console.ReadLine());
                        if (confirm == 1)
                        {
                            Book.Remove(removeId);
                        }    
                        break;
                    case 4:
                        Console.Write("Enter book's Id to edit book: ");
                        editId = int.Parse(Console.ReadLine());
                        Book.PrintBook(editId);
                        Console.Write("Please confirm to edit this book!\n1. Yes\n2. No\nChoice: ");
                        confirm = int.Parse(Console.ReadLine());
                        if (confirm == 1)
                        {
                            Console.Write("Enter Name: ");
                            name = Console.ReadLine();
                            Console.Write("Enter Author: ");
                            author = Console.ReadLine();
                            Console.Write("Enter Category: ");
                            category = Console.ReadLine();
                            Console.Write("publication Date: ");
                            publicDate = Console.ReadLine();
                            Book.Edit(editId, name, author, category, publicDate);
                        }
                        break;
                }
            } while (choice != 5);
        }
    }
}
