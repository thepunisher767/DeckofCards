using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DeckofCards.Models;
using System.Net.Http;

namespace DeckofCards.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetDeck()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://deckofcardsapi.com/");
            var response = await client.GetAsync("/api/deck/new/shuffle/?deck_count=1");
            Deck carddeck = await response.Content.ReadAsAsync<Deck>();
            var response2 = await client.GetAsync($"/api/deck/{carddeck.deck_id}/draw/?count=5");
            Hand playerhand = await response2.Content.ReadAsAsync<Hand>();
            return View(playerhand);
        }



        public IActionResult Privacy()
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
