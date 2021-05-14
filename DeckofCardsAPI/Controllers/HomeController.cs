using DeckofCardsAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DeckofCardsAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private DeckofCardsDAL deckofcardsDAL = new DeckofCardsDAL();
        private DrawCardsDAL drawcardsDAL = new DrawCardsDAL();
        
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            DeckofCardsModel cardDeck = deckofcardsDAL.ConvertJsontoDeckofCardsModel();
            DrawCardsModel drawCards = deckofcardsDAL.ConvertJsontoDrawCardsModel(cardDeck.deck_id, 5);

            return View(drawCards);
        }  
        
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult DeckofCards()
        {
            
            return View();
        }

        public IActionResult DrawCards()
        {
            
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
