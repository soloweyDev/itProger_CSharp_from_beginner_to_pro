using SimpleBlog.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SimpleBlog.Controllers
{
    public class ArticlesController : Controller
    {
        // GET: Articles
        public ActionResult Index()
        {
            List<ArticlesModel> articles = new List<ArticlesModel>();
            articles.Add(new ArticlesModel("Новый стартам от Google", "Что-то тут нужно было писать", "Георгий"));
            articles.Add(new ArticlesModel("Новый стартам от Google", "Что-то тут нужно было писать", "Георгий"));
            articles.Add(new ArticlesModel("Новый стартам от Google", "Что-то тут нужно было писать", "Георгий"));
            articles.Add(new ArticlesModel("Новый стартам от Google", "Что-то тут нужно было писать", "Георгий"));

            return View(articles);
        }
    }
}