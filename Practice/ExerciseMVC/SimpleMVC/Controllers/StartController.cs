using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SimpleMVC.Data;
using SimpleMVC.Data.Entities;
using SimpleMVC.Models;

namespace SimpleMVC.Controllers
{
    public class StartController : Controller
    {
        private SimpleMvcDbContext _db;
        public StartController(SimpleMvcDbContext dbInject)
        {
            _db = dbInject;
        }

        public IActionResult Index()
        {

            List<Product> products = null;
            try
            {
                products = _db.Products.ToList();
            }
            catch (Exception ex)
            {
                return View("ErrorPage", ex);
            }
            List<Card> cards = new List<Card>();
            foreach (Product product in products)
            {
                cards.Add(MapCardWithProduct(product));
            }
            return View(cards);
        }
        #region Helpers
        private Card MapCardWithProduct(Product product)
        {
            Card myCard = new Card();
            if (product != null)
            {
                myCard.CardID = product.ProductID;
                myCard.AlternativeText = "Image of a product";
                myCard.Text = product.Summary;
                myCard.Title = product.ProductName;
                myCard.Image = "products/" + product.ImageName;
            }
            else
            {
                myCard.CardID = 0;
                myCard.AlternativeText = "Image not found";
                myCard.Text = "...";
                myCard.Title = "Not found";
                myCard.Image = "";
            }
           

            return myCard;
        }
        #endregion
    }
}
