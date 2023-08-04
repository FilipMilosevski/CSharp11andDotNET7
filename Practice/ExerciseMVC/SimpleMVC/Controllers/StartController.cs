using Microsoft.AspNetCore.Mvc;
using SimpleMVC.Models;

namespace SimpleMVC.Controllers
{
    public class StartController : Controller
    {
        public IActionResult Index()
        {

            List<Card> cards = new List<Card>();

            Card card1 = new Card();
            card1.CardID = 1;
            card1.Image = "myImg.jpg";
            card1.Text = "Quacking, funny, fast, migratory, feathered, waddling, versatile, herbivorous, adorable, vocal.";
            card1.AlternativeText = "image of a duck";
            card1.Title = "Duck";
            cards.Add(card1);

            Card card2 = new Card();
            card2.CardID = 2;
            card2.Image = "dog.jpg";
            card2.Text = "Loyal, friendly, playful, furry, obedient, protective, affectionate, intelligent, joyful, energetic.";
            card2.AlternativeText = "image of a cat";
            card2.Title = "Dog";
            cards.Add(card2);

            Card card3 = new Card();
            card3.CardID = 3;
            card3.Image = "cat.jpg";
            card3.Text = "Cuddly, agile, whiskered, curious, independent, elegant, playful, mysterious, purring, adorable.";
            card3.AlternativeText = "image of a cat";
            card3.Title = "Cat";
            cards.Add(card3);

            


            return View(cards);


        }
    }
}
