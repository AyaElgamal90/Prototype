using Microsoft.AspNetCore.Mvc;
using Web_Prototvpe.Areas.Prototype.Models;

namespace Web_Prototvpe.Areas.Prototype.Controllers
{
    public class DMLController
    {
        public ActionResult Index()
        {
            var model = new DMLModel();
            model.PageTitle = "Digital Micro Loan";

            return View(model);
        }

        private ActionResult View(DMLModel model)
        {
            throw new NotImplementedException();
        }
    }
}
