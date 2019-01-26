namespace BooksAPI.Migrations
{
    using BooksAPI.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BooksAPI.Models.BooksAPIContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BooksAPI.Models.BooksAPIContext context)
        {
            context.Authors.AddOrUpdate(new Models.Author[] {
                new Author() { AuthorId = 1, Name = "Mehmet Salih Uyan" }, // Anlýyorum Ama Konuþamýyorum
                new Author() { AuthorId = 2, Name = "Carmine Gallo" }, // Hikaye Anlatýcýsýnýn Sýrrý
                new Author() { AuthorId = 3, Name = "Stephen R. Covey" }, // Etkili Ýnsanlarýn 7 Alýþkanlýðý
                new Author() { AuthorId = 4, Name = "Walter Isaacson" }, // Steve Jobs
                new Author() { AuthorId=5, Name="Henry Ford" } // Beynelmilel Yahudi
            });

            context.Books.AddOrUpdate(new Models.Book[] {
                new Book() { BookID = 1,  Title= "Anlýyorum Ama Konuþamýyorum", Genre = "Education",
        PublishDate = new DateTime(2000, 12, 16), AuthorId = 1, Description =
        "Anlýyorum Ama Konuþamýyorum.", Price = 14.95M },

        new Book() { BookID = 2, Title = "Hikaye Anlatýcýsýnýn Sýrrý", Genre = "Education",
            PublishDate = new DateTime(2000, 11, 17), AuthorId = 2, Description =
            "Hikaye Anlatýcýsýnýn Sýrrý.", Price = 12.95M },

        new Book() { BookID = 3, Title = "Etkili Ýnsanlarýn 7 Alýþkanlýðý", Genre = "Education",
            PublishDate = new DateTime(2001, 09, 10), AuthorId = 3, Description =
            "Etkili Ýnsanlarýn 7 Alýþkanlýðý.", Price = 12.95M },

        new Book() { BookID = 4, Title = "Steve Jobs", Genre = "Biography",
            PublishDate = new DateTime(2000, 09, 02), AuthorId = 4, Description =
            "Steve Jobs.", Price = 7.99M },

        new Book() { BookID = 5, Title = "Beynelmilel Yahudi", Genre = "History",
            PublishDate = new DateTime(2000, 11, 02), AuthorId = 4, Description =
            "Beynelmilel Yahudi.", Price = 6.99M}
            });
        }
    }
}
