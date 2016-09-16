using MbmStore.Infrastructure;
using MbmStore.Models;
using System.Linq;
using System.Web.Mvc;

namespace MbmStore.Controllers
{
    public class CatalogController : Controller
    {
        private Repository repo = new Repository();

        // GET: Catalog
        public ActionResult Index()
        {
            //List<Book> books = new List<Book>();
            //List<MusicCD> cds = new List<MusicCD>();

            //Book book = new Book("Steve Turner", "A Hard Day's Write: The Stories Behind Every Beatles Song", 150m, 2005);
            //book.Publisher = "It Books";
            //book.ISBN = "0060844094";
            //book.ImageUrl = "AHardDaysWrite.jpg";
            //books.Add(book);

            //book = new Book("Stephen King", "The Shining: The Deluxe Special Edition", 199m, 2016);
            //book.Publisher = "Cemetery Dance Publications";
            //book.ISBN = "978-1-58767-530-0";
            //book.ImageUrl = "TheShining.jpg";
            //books.Add(book);

            //MusicCD cd = new MusicCD("Beatles", "Abbey Road (Remastered)", 128m, 2009);
            //cd.Label = "EMI";
            //cd.ImageUrl = "AbbeyRoadAlbumCover.jpg";
            //cd.AddTrack(new Track { Title = "Come Together", Composer = "Lennon/McCartney", Length = new System.TimeSpan(0, 4, 20) });
            //cd.AddTrack(new Track { Title = "Something", Composer = "Harrison", Length = new System.TimeSpan(0, 3, 3) });
            //cd.AddTrack(new Track { Title = "Maxwell's Silver Hammer", Composer = "Lennon/McCartney", Length = new System.TimeSpan(0, 3, 27) });
            //cd.AddTrack(new Track { Title = "Oh! Darling", Composer = "Lennon/McCartney", Length = new System.TimeSpan(0, 3, 26) });
            //cd.AddTrack(new Track { Title = "Octopus's Garden", Composer = "Starr", Length = new System.TimeSpan(0, 2, 51) });
            //cd.AddTrack(new Track { Title = "I Want You (She's So Heavy)", Composer = "Lennon/McCartney", Length = new System.TimeSpan(0, 7, 47) });
            //cd.AddTrack(new Track { Title = "Here Comes The Sun", Composer = "Harrison", Length = new System.TimeSpan(0, 3, 5) });
            //cd.AddTrack(new Track { Title = "Because", Composer = "Lennon/McCartney", Length = new System.TimeSpan(0, 2, 45) });
            //cd.AddTrack(new Track { Title = "You Never Give Me Your Money", Composer = "Lennon/McCartney", Length = new System.TimeSpan(0, 4, 2) });
            //cd.AddTrack(new Track { Title = "Sun King", Composer = "Lennon/McCartney", Length = new System.TimeSpan(0, 2, 26) });
            //cd.AddTrack(new Track { Title = "Mean Mr. Mustard", Composer = "Lennon/McCartney", Length = new System.TimeSpan(0, 1, 6) });
            //cd.AddTrack(new Track { Title = "Polythene Pam", Composer = "Lennon/McCartney", Length = new System.TimeSpan(0, 1, 12) });
            //cd.AddTrack(new Track { Title = "She Came In Through The Bathroom Window", Composer = "Lennon/McCartney", Length = new System.TimeSpan(0, 1, 57) });
            //cd.AddTrack(new Track { Title = "Golden Slumbers", Composer = "Lennon/McCartney", Length = new System.TimeSpan(0, 1, 31) });
            //cd.AddTrack(new Track { Title = "Carry The Weight", Composer = "Lennon/McCartney", Length = new System.TimeSpan(0, 1, 36) });
            //cd.AddTrack(new Track { Title = "The End", Composer = "Lennon/McCartney", Length = new System.TimeSpan(0, 2, 5) });
            //cd.AddTrack(new Track { Title = "Her Majesty", Composer = "Lennon/McCartney", Length = new System.TimeSpan(0, 0, 23) });
            //cds.Add(cd);

            //cd = new MusicCD("Fields of the Nepthilim", "Earth Inferno", 99m, 1991);
            //cd.Label = "Beggars Banquet";
            //cd.ImageUrl = "Earth_Inferno_Fields_of_the_Nephilim.jpeg";
            //cd.AddTrack(new Track { Title = "Intro (Dead But Dreaming)", Composer = "Fields of the Nephilim", Length = new System.TimeSpan(0, 16, 8) });
            //cd.AddTrack(new Track { Title = "Moonchild", Composer = "Fields of the Nephilim", Length = new System.TimeSpan(0, 5, 25) });
            //cd.AddTrack(new Track { Title = "Submission", Composer = "Fields of the Nephilim", Length = new System.TimeSpan(0, 7, 34) });
            //cd.AddTrack(new Track { Title = "Preacher Man", Composer = "Fields of the Nephilim", Length = new System.TimeSpan(0, 4, 51) });
            //cd.AddTrack(new Track { Title = "Love Under Will", Composer = "Fields of the Nephilim", Length = new System.TimeSpan(0, 6, 17) });
            //cd.AddTrack(new Track { Title = "Sumerland", Composer = "Fields of the Nephilim", Length = new System.TimeSpan(0, 8, 26) });
            //cd.AddTrack(new Track { Title = "Last Exit for the Lost", Composer = "Fields of the Nephilim", Length = new System.TimeSpan(0, 10, 18) });
            //cd.AddTrack(new Track { Title = "Psychonaut", Composer = "Fields of the Nephilim", Length = new System.TimeSpan(0, 9, 5) });
            //cd.AddTrack(new Track { Title = "Dawnrazor", Composer = "Fields of the Nephilim", Length = new System.TimeSpan(0, 9, 9) });
            //cds.Add(cd);

            //ViewBag.Books = books;
            //ViewBag.CDs = cds;

            ViewBag.Books = repo.Products.OfType<Book>().ToList();
            ViewBag.CDs = repo.Products.OfType<MusicCD>().ToList();
            ViewBag.Movies = repo.Products.OfType<Movie>().ToList();

            return View();
        }
    }
}