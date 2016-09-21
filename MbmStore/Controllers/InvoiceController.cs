using MbmStore.Infrastructure;
using System.Web.Mvc;

namespace MbmStore.Controllers
{
    public class InvoiceController : Controller
    {
        // GET: Invoice
        public ActionResult Index()
        {
            Repository repo = new Repository();

            ViewBag.Invoices = repo.Invoices;

            return View();
        }
    }
}