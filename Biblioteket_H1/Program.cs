using System;
using System.Collections.Generic;

namespace Biblioteket_H1
{
    class Program
    {
        static void Main(string[] args)
        {
                             
            // Making a list to store available books.
            List<Book> booksAvailable = new List<Book>();

            // Instantiating a number of objects from the class Book and
            // adding the new objects to the list.
            booksAvailable.Add(new Book(1, "Den gamle bog", "Gammelsmølf", "Gorm", 1948, 1033));
            booksAvailable.Add(new Book(2, "Den gule bog", "Pedal", "Peter", 1978, 47));
            booksAvailable.Add(new Book(3, "Jordens søjler", "Follet", "Ken", 988, 1989));
            booksAvailable.Add(new Book(4, "Ægyptens pyramider", "Lehner", "Mark", 1997, 256));
            booksAvailable.Add(new Book(5, "Kunstens historie", "Gombrich", "E.H.", 436, 1950));
            booksAvailable.Add(new Book(6, "Vi er vejret", "Foer", "Jonathan", 2019, 311));
            booksAvailable.Add(new Book(7, "Ferskvandsøkologi", "Sand-Jensen", "Kaj", 2004, 312));
            

            // Counting the number of elements in the list to know how many times the for loop needs to run.
            int length = booksAvailable.Count; 
           
            // Making a stack to keep the books that needs to be borrowed.
            Stack<Book> checkOutList = new Stack<Book>();    
            
            while (length > 0)
            {
                Console.WriteLine("Books available");

                // Printing the list af the available books using a method

                BooksAvailable(booksAvailable);

                int bookNumber = GetAnswer("Choose a book (nr)");
                                
                int indexNumber = 0;
                for (int i = 0; i < length; i++)
                {
                    // Condition.
                    if (booksAvailable[i].Id == bookNumber) 
                    {
                        indexNumber = i;

                    }

                }
                // Instansiating a new object.
                Book bookChosen = new Book(booksAvailable[indexNumber].Id, booksAvailable[indexNumber].Title, booksAvailable[indexNumber].Forfatter_efternavn,
                                booksAvailable[indexNumber].Forfatter_fornavn, booksAvailable[indexNumber].Udgivelsesår, booksAvailable[indexNumber].Sideantal);

                // Removing an element at the index number when the condition is met.
                booksAvailable.RemoveAt(indexNumber); 

                // Updating the length.
                length = booksAvailable.Count;

                // For loop to update the indexNumber after an elemet has been removed from the list.
                for (int i = 0; i < length; i++)
                {
                    if (booksAvailable[i].Id == bookNumber)
                    {
                        indexNumber = i;
                    }
                }

                // Adding the chosen book to the stack of books to be borrowed.
                checkOutList.Push(bookChosen);
                
                
                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You have following boks to check out at the counter:");
            Console.ForegroundColor = ConsoleColor.White;
            
            // Printing the books in the stack.
            foreach (Book books in checkOutList)
            {
                Console.WriteLine(books.Title);
            }
            
            int lengthStack = checkOutList.Count;
            while (lengthStack >0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Next book to check out");
                Console.ForegroundColor = ConsoleColor.White;
                checkOutList.Peek();
                checkOutList.Pop();
                lengthStack = checkOutList.Count;
                foreach(Book books in checkOutList)
                {
                    Console.WriteLine(books.Title);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            
            }
        public static void BooksAvailable(List<Book> navn)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("nr                title       efternavn    fornavn udg.år sideantal");
            Console.ForegroundColor = ConsoleColor.White;
            foreach ( Book book in navn)
            {
                Console.WriteLine($"{book.Id} {book.Title,21} {book.Forfatter_efternavn,15} {book.Forfatter_fornavn,10} {book.Udgivelsesår,6} {book.Sideantal,6}");
            }
            
        }
        // Method to get the users answer og which book they have chosen.
        public static int GetAnswer(string question)
        {
            Console.WriteLine(question);
            int output;//Erklærer en variabel der skal bruges til at indeholde brugerens svar
            while (!int.TryParse(Console.ReadLine(), out output))/*Brugerens indtastning gemmes i output og 
                                                                 * der testes for om der er indtastet et heltal.
                                                                 * whileløkken kører indtil det er et tal der er indtastet*/
            {
                Console.WriteLine("Invalid input, try again");
            }
            return output;
        }
        
        
        
    }
}
