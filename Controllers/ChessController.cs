using Microsoft.AspNetCore.Mvc;
using ChessAI.Models;

namespace ChessAI.Controllers
{
    public class ChessController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetAIMove([FromBody] ChessMoveRequest request)//cevapları birbirine gönder
        {
            StockfishEngine engine = new StockfishEngine();

            string bestMove = engine.GetBestMove(request.Fen);

            return Json(new
            {
                move = bestMove
            });
        }

        public class ChessMoveRequest
        {
            public string Fen { get; set; } = "";
        }
    }
}