using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using BookStoreCorrected.Models;

namespace BookStoreCorrected.DAL
{
    public class BookInitializer : DropCreateDatabaseIfModelChanges<BookContext>
    {
        protected override void Seed(BookContext context)
        {
            var author = new Author
            {
                Biography = "Came from planet Krypton, last of his kind, totally awesome, sexy, smart - to put simply:perfect.",
                FirstName = "Dariusz",
                LastName = "Strych",
            };

            var books = new List<Book>
            {
                new Book {
                Author = author,
                Description = "This book is a must read.Contains info about you, simulation theory and everything u dont want to know.",
                ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51ZOvF5cKJL._SX326_BO1,204,203,200_.jpg",
                Isbn = "1234567890",
                Synopsis ="test1234",
                Title = "Nick Bostrom influence over my mind",
                },

                new Book {
                Author = author,
                Description = "We are doomed. So let's be happy while we can.",
                ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51GtzWuMUAL._SY344_BO1,204,203,200_.jpg",
                Isbn = "1234567899",
                Synopsis ="test4321",
                Title = "Nick Bostrom brain rampage",
                },

                new Book {
                Author = author,
                Description = "End of humanity may not look like disaster after all.",
                ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51TQ%2Bkx5hKL._SX331_BO1,204,203,200_.jpg",
                Isbn = "1234567999",
                Synopsis ="test3333",
                Title = "Ray Kurzweil is an alinen.It is confirmed now.100%.",
                },

                new Book {
                Author = author,
                Description = "This book is a must read.Contains info about aliens, simulation theory and everything u dont want to know.",
                ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/41Tz0G86hpL._SX324_BO1,204,203,200_.jpg",
                Isbn = "1234569999",
                Synopsis ="test4444",
                Title = "Ray Kurzweil right again. Plz sb stop him.",
                },

            };

            books.ForEach(b => context.Books.Add(b));
            context.SaveChanges();
        }
    }
}