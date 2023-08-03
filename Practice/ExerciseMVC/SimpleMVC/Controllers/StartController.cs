using Microsoft.AspNetCore.Mvc;
using SimpleMVC.Models;

namespace SimpleMVC.Controllers
{
    public class StartController : Controller
    {
        public IActionResult Index()
        {
            Card myCard = new Card();
            myCard.CardID = 1;
            myCard.Image = "myImg.jpg";
            myCard.Text = "text example for a template card. Simple MVC project info.";
            myCard.AlternativeText = "image of a duck";
            myCard.Title = "Card Example";
            return View(myCard); 
        }
    }
}
