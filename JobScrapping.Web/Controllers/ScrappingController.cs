using System.Web.Mvc;
using JobScrapping.Web.ViewModels;

namespace JobScrapping.Web.Controllers
{
    public class ScrappingController : Controller
    {
        //
        // GET: /Scrapping/
        public ActionResult Create(string assignmentId)
        {

            var viewModel = new CreateEntryViewModel
            {
                AssignmentId = assignmentId,
                ScrappingUrl = "http://www.jobs.cz"
            };

            return View("CreateEntry", viewModel);
        }
	}
}