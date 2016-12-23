using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using WickhamAthletics.BusinessLogic;
using WickhamAthletics.Models;

namespace WickhamAthletics.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Check our prices and contact us for more information.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Ryan()
        {
            return View();
        }

        public ActionResult Jimmy()
        {
            return View();
        }

        public ActionResult Members()
        {
            return View();
        }

        //public ActionResult Charity()
        //{
        //    ViewData["view"] = SpecialPageManager.GetCharityViewData();
        //    return View();
        //}

        //public ActionResult Testimonials()
        //{
        //    return View();
        //}

        public ActionResult Videos()
        {
            return View();
        }

        [HttpPost]
        public async Task<PartialViewResult> Submit(EmailModel model)
        {
            bool isMessageSent = true;

            if (ModelState.IsValid)
            {
                try
                {
                    await WickhamAthletics.Services.EmailService.SendContactForm(model);
                }
                catch (Exception ex)
                {
                    isMessageSent = false;
                }
            }
            else
            {
                isMessageSent = false;
            }
            return PartialView("_SubmitMessage", isMessageSent);
        }
    }
}