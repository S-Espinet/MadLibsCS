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
    public ActionResult Story(string person1, string person2, string noun, string verb, string exclamation, string animal)
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

    [Route("/form2")]
    public ActionResult Form2() { return View(); }

    [Route("/story2")]
    public ActionResult Story2(string adjective1, string adjective2, string adjective3, string adjective4, string noun1, string noun2, string noun3, string verb1, string ptVerb1, string ptVerb2, string adverb1, string adverb2)
    {
      Story2Variable myStory2Variable = new Story2Variable();
      myStory2Variable.Adjective1 = adjective1;
      myStory2Variable.Adjective2 = adjective2;
      myStory2Variable.Adjective3 = adjective3;
      myStory2Variable.Adjective4 = adjective4;
      myStory2Variable.Noun1 = noun1;
      myStory2Variable.Noun2 = noun2;
      myStory2Variable.Noun3 = noun3;
      myStory2Variable.Verb1 = verb1;
      myStory2Variable.PtVerb1 = ptVerb1;
      myStory2Variable.PtVerb2 = ptVerb2;
      myStory2Variable.Adverb1 = adverb1;
      myStory2Variable.Adverb2 = adverb2;
      return View(myStory2Variable);
    }

  }
}