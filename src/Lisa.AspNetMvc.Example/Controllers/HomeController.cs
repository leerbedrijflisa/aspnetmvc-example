using System.Web.Mvc;

namespace Lisa.AspNetMvc.Example
{
    public class NitwitController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(PersonViewModel viewModel)
        {
            var person = new Person();
            person.FirstName = viewModel.FirstName;
            person.LastName = viewModel.LastName;

            var db = new ExampleContext();
            db.Persons.Add(person);
            db.SaveChanges();

            return View();
        }
    }
}