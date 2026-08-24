# ♟️ ChessAI: Web Tabanlı Yapay Zeka Satranç Deneyimi

**ChessAI**, kullanıcıların doğrudan tarayıcı üzerinden dünyanın en güçlü ve popüler satranç motorlarından biri olan **Stockfish**'e karşı mücadele edebildiği, **ASP.NET Core MVC** mimarisiyle geliştirilmiş modern bir satranç uygulamasıdır. 

Kullanıcı dostu arayüzü ve güçlü arka plan mimarisi sayesinde, tahtadaki her hamleniz sunucu tarafında milisaniyeler içinde analiz edilir ve yapay zekanın karşı hamlesi akıcı bir şekilde ekrana yansır.

---

## 🚀 Projenin Çalışma Mantığı ve Veri Akışı

Sistem, istemci (tarayıcı) ile sunucu arasında kusursuz işleyen asenkron bir iletişim üzerine inşa edilmiştir:

1. **Hamle Algılama:** Kullanıcının satranç tahtası üzerinde yaptığı fiziksel hamle, JavaScript tarafından anında yakalanır.
2. **FEN Dönüşümü:** Tahtanın o anki güncel dizilimi, evrensel satranç notasyonu olan **FEN (Forsyth-Edwards Notation)** formatına çevrilerek paketlenir.
3. **API İletişimi:** Elde edilen FEN verisi, sunucu tarafındaki `ChessController` uç noktasına (endpoint) gönderilir.
4. **Motor Analizi:** Controller, `StockfishEngine` sınıfını tetikleyerek pozisyonu Stockfish motoruna besler. Motor derinlemesine bir analiz yaparak en optimal hamleyi hesaplar.
5. **AI Hamlesi:** Yapay zekanın kararı tekrar istemciye (JavaScript) döndürülür ve tahtada otomatik olarak oynanır.

**Sistem Akış Şeması:**
> Kullanıcı Hamlesi ➔ `JavaScript` ➔ `FEN Verisi` ➔ `ChessController` ➔ `Stockfish Engine` ➔ `AI Hamlesi` ➔ Satranç Tahtası

---

## 💻 Kullanılan Teknolojiler

Proje, hem front-end hem de back-end tarafında güncel teknolojiler harmanlanarak geliştirilmiştir:

* **Back-end:** C#, ASP.NET Core MVC
* **Satranç Motoru:** Stockfish Chess Engine
* **Front-end:** HTML5, CSS3, JavaScript
* **Tasarım / UI:** Bootstrap

---

## 📂 Proje Yapısı

MVC mimarisine uygun olarak organize edilen proje dizini şu şekildedir:

* **`Controllers/`** ➔ Kullanıcı isteklerini karşılayan ve AI entegrasyonunu yöneten kontrolcüler.
* **`Models/`** ➔ Stockfish ile iletişimi (process yönetimi) sağlayan motor sınıfları.
* **`Views/`** ➔ Kullanıcının etkileşime girdiği dinamik web arayüzleri.
* **`wwwroot/`** ➔ Projeye ait statik dosyalar (CSS, JavaScript, satranç taşlarının görselleri).
* **`Engines/`** ➔ Stockfish motorunun `.exe` dosyasını barındıran çekirdek klasör.

---

## ⚙️ Kurulum ve Çalıştırma

**1. Projeyi Klonlayın:**
```bash
git clone [https://github.com/ikbaltorun/ChessAI.git](https://github.com/ikbaltorun/ChessAI.git)
```

**2. Projeyi Açın:**
İndirdiğiniz klasördeki ChessAI.sln dosyasını Visual Studio ile açın.

**3. Stockfish Kurulumu (Önemli):**
Dosya boyutu kısıtlamaları nedeniyle Stockfish motoru bu depoya (repository) dahil edilmemiştir. Projenin çalışabilmesi için:
Stockfish Resmi İndirme Sayfasına gidin. [Stockfish Resmi İndirme Sayfası](https://stockfishchess.org/download/)
Windows x64 için AVX2 sürümünü (çoğu modern bilgisayar için en performanslı olan) indirin.
İndirdiğiniz .exe dosyasını proje dizininde şu yola yerleştirin:
ChessAI -> Engines -> stockfish -> stockfish-windows-x86-64-avx2.exe
(Not: Dosya adının StockfishEngine.cs içerisindeki tanımlamayla birebir aynı olduğundan emin olun.)

**4. Çalıştırın:**
Tüm adımları tamamladıktan sonra projeyi Visual Studio üzerinden (F5) başlatarak hemen oynamaya başlayabilirsiniz!

👨‍💻 Geliştirici
*İkbal Torun*
