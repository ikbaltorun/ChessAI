using System.Diagnostics;

namespace ChessAI.Models
{
    public class StockfishEngine
    {
        private readonly string stockfishPath;

        public StockfishEngine()
        {
            stockfishPath = Path.Combine(
                Directory.GetCurrentDirectory(),
                "Engines",
                "stockfish-windows-x86-64-avx2.exe"
            );
        }

        public string GetBestMove(string fen)
        {
            using Process process = new Process();

            process.StartInfo = new ProcessStartInfo
            {
                FileName = stockfishPath,
                UseShellExecute = false,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true
            };

            process.Start();

            process.StandardInput.WriteLine("uci");
            process.StandardInput.WriteLine("isready");
            process.StandardInput.WriteLine($"position fen {fen}");
            process.StandardInput.WriteLine("go depth 15");

            string? line;

            while ((line = process.StandardOutput.ReadLine()) != null)
            {
                if (line.StartsWith("bestmove"))
                {
                    return line.Split(' ')[1];
                }
            }

            return "";
        }
    }
}