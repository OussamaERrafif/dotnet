using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult LoadParagraph(string id)
    {
        return PartialView($"~/Views/Home/Paragraphe{id}.cshtml");
    }

    public IActionResult LoadQuiz(string id)
    {
        return PartialView($"~/Views/Home/Quiz{id}.cshtml");
    }

    
    public IActionResult LoadDefaultPage()
    {
        return PartialView("~/Views/Home/_defaultpage.cshtml");
    }
}
