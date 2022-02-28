using MadLibs.Models;
using Microsoft.AspNetCore.Mvc;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Instructions()
    {
      return View();
    }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/story")]
    public ActionResult Story(string recipient, string sender)
    {
      StoryVariable myStoryVariable = new StoryVariable();
      myStoryVariable.Person1 = person1;
      myStoryVariable.Person2 = person2;
      myStoryVariable.Noun = noun;
      myStoryVariable.Verb = verb;
      myStoryVariable.Exclamation = exclamation;
      myStoryVariable.Animal = animal;
      return View(myStoryVariable);
    }

  }
}