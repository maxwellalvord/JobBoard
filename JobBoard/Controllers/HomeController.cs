using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;


namespace JobBoard.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index() {return View(); }

    [Route("/postcard")]
    public ActionResult Postcard(string adjective1, string noun1, string verb, string adjective2, string noun2)
    {
      Job myJob = new Job();
      myJob.Adjective1 = adjective1;
      myJob.Noun1 = noun1;
      myJob.Verb = verb;
      myJob.Adjective2 = adjective2;
      myJob.Noun2 = noun2;
      return View(myJob);
    }

    [Route("/ML2")]
    public ActionResult ML2(string adjective1_2, string noun1_2, string verb_2, string adjective2_2, string noun2_2)
    {
      Job myJob = new Job();
      myJob.Adjective1 = adjective1_2;
      myJob.Noun1 = noun1_2;
      myJob.Verb = verb_2;
      myJob.Adjective2 = adjective2_2;
      myJob.Noun2 = noun2_2;
      return View(myJob);
    }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/form2")]
    public ActionResult Form2() { return View(); }
  }
}