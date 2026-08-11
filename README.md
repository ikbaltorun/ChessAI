# ChessAI

ChessAI, ASP.NET Core MVC kullanılarak geliştirilmiş web tabanlı bir satranç uygulamasıdır.

Uygulamada kullanıcı, ekrandaki satranç tahtası üzerinden Stockfish satranç motoruna karşı oynar. Kullanıcının yaptığı hamle sonrasında mevcut oyun durumu FEN formatında hazırlanır ve C# tarafına gönderilir. Controller üzerinden Stockfish çalıştırılarak en uygun hamle alınır ve AI'ın hamlesi tekrar satranç tahtasında gösterilir.

## Kullanılan Teknolojiler

- C#
- ASP.NET Core MVC
- HTML
- CSS
- JavaScript
- Bootstrap
- Stockfish Chess Engine

## Projenin Çalışma Mantığı

Kullanıcının yaptığı hamle JavaScript tarafından algılanır.
Güncel satranç pozisyonu FEN formatına dönüştürülür ve `ChessController` içerisindeki API'ye gönderilir.
Controller, `StockfishEngine` sınıfını kullanarak Stockfish'i çalıştırır. Stockfish pozisyonu analiz eder ve en uygun hamleyi belirler.
AI'ın hamlesi JavaScript'e gönderilir ve satranç tahtasında uygulanır.
```text
Kullanıcı hamlesi
       ↓
JavaScript
       ↓
FEN
       ↓
ChessController
       ↓
Stockfish
       ↓
AI hamlesi
       ↓
Satranç tahtası
```
## Proje Yapısı
Controllers → Kullanıcı isteklerini ve AI hamlelerini yönetir.
Models → Stockfish ile iletişimi sağlayan sınıfları içerir.
Views → Uygulamanın web arayüzünü içerir.
wwwroot → CSS, JavaScript ve görsel dosyalarını içerir.
Engines → Stockfish motorunun bulunduğu klasördür.

## Kurulum
Projeyi GitHub üzerinden indirin:
```bash
git clone https://github.com/ikbaltorun/ChessAI.git
```
Daha sonra ChessAI.sln dosyasını Visual Studio ile açın.

## Stockfish Kurulumu

Stockfish dosyası GitHub'a dosya boyutu nedeniyle eklenmemiştir.
Stockfish'in resmi indirme sayfasından Windows için uygun sürümü indirin:
[Stockfish resmi indirme sayfası](https://stockfishchess.org/download/)
Windows x64 için AVX2 sürümü çoğu modern bilgisayar için önerilmektedir.
İndirdiğiniz Stockfish çalıştırılabilir dosyasını şu klasöre koyun:
ChessAI -> Engines -> stockfish -> stockfish-windows-x86-64-avx2.exe
Dosyanın adı, StockfishEngine.cs içerisindeki dosya adıyla aynı olmalıdır.
Daha sonra projeyi Visual Studio üzerinden çalıştırabilirsiniz.

### Geliştirici
*İkbal Torun*
