using Decrypto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Decrypto.Controllers
{
    public class HomeController : Controller
    {
        DecryptoDbContext _db = new DecryptoDbContext();

        public ActionResult Index()
        {
            var model = _db.GameRounds.First();

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(GameRound gameRound)
        {
            var gr = _db.GameRounds.Where(x => x.Id == gameRound.Id).Single();
            gr.Clue1.Hint = gameRound.Clue1.Hint;
            gr.Clue1.Word = gameRound.Clue1.Word;

            _db.SaveChanges();

            return View(gameRound);
        }

        [HttpPost]
        public ActionResult Guess(GameRound gameRound)
        {
            var gr = _db.GameRounds.Where(x => x.Id == gameRound.Id).Single();
            gr.Clue1.Hint = gameRound.Clue1.Hint;
            gr.Clue1.Word = gameRound.Clue1.Word;

            _db.SaveChanges();

            return View(gameRound);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}