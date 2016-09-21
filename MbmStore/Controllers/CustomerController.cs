using MbmStore.Models;
using System.Web.Mvc;

namespace MbmStore.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {

            Customer john = new Customer("John", "Wayne", "OK Corral", "83", "Tombestone");
            john.AddPhone("555-928374");
            john.AddPhone("233-293844");
            john.Birthdate = new System.DateTime(1907, 5, 26);
            Customer maz = new Customer("Maz", "Jobrani", "31st street", "9384", "New York");
            maz.AddPhone("515-394851");
            maz.Birthdate = new System.DateTime(1972, 2, 26);
            Customer liz = new Customer("Lizzy", "Hale", "Upper Crest", "1342", "Oklahoma");
            liz.AddPhone("442-930285");
            //liz.BirthDate = new System.DateTime(1845, 9, 18);

            ViewBag.John = john;
            ViewBag.Maz = maz;
            ViewBag.Liz = liz;

            return View();
        }
    }
}