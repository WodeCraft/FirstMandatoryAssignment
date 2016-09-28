using MbmStore.Infrastructure;
using System.Web.Mvc;

namespace MbmStore.Controllers
{
    public class InvoiceController : Controller
    {
        // GET: Invoice
        public ActionResult Index()
        {
            // Instantiate the repository
            Repository repo = new Repository();

            // Add all invoices to the ViewBag
            ViewBag.Invoices = repo.Invoices;

            return View();
        }
    }
}