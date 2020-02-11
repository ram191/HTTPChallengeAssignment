# HTTPChallengeAssignment

Create a new class called `Fetcher`. This class should simplify the usage of HTTP request.

Expected usage:

```csharp
var getJsonResponse = await Fetcher.Get("https://httpbin.org/get");
var deleteJsonResponse = await Fetcher.Delete("https://httpbin.org/delete");

var jsonData = @"
  {
    ""id"": 30,
    ""name"": ""Someone""
  }
";

var postJsonResponse = await Fetcher.Post("https://httpbin.org/post", data);
var putJsonResponse = await Fetcher.Put("https://httpbin.org/put", data);
var patchJsonResponse = await Fetcher.Patch("https://httpbin.org/put", data);
```
Fetch data from https://mul14.github.io/data/employees.json

1. Find employees which have salary more than Rp15.000.000
2. Find employees which life in Jakarta
3. Find employees which birthday on March
4. Find employees in Research and Development departement
5. Find how many each employee absences in October 2019


Fetch data from https://jsonplaceholder.typicode.com/posts and https://jsonplaceholder.typicode.com/users. Then combine `posts` and `users` based on `userId`.

Expected output:

```json
[
  {
    "userId": 1,
    "id": 1,
    "title": "sunt aut facere repellat provident occaecati excepturi optio reprehenderit",
    "body": "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto",
    "user": {
      "id": 1,
      "name": "Leanne Graham",
      "username": "Bret",
      "email": "Sincere@april.biz",
      "address": {
        "street": "Kulas Light",
        "suite": "Apt. 556",
        "city": "Gwenborough",
        "zipcode": "92998-3874",
        "geo": {
          "lat": "-37.3159",
          "lng": "81.1496"
        }
      },
      "phone": "1-770-736-8031 x56442",
      "website": "hildegard.org",
      "company": {
        "name": "Romaguera-Crona",
        "catchPhrase": "Multi-layered client-server neural-net",
        "bs": "harness real-time e-markets"
      }
    }
  },
  {
    "userId": 1,
    "id": 2,
    "title": "qui est esse",
    "body": "est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla",
    "user": {
      "id": 1,
      "name": "Leanne Graham",
      "username": "Bret",
      "email": "Sincere@april.biz",
      "address": {
        "street": "Kulas Light",
        "suite": "Apt. 556",
        "city": "Gwenborough",
        "zipcode": "92998-3874",
        "geo": {
          "lat": "-37.3159",
          "lng": "81.1496"
        }
      },
      "phone": "1-770-736-8031 x56442",
      "website": "hildegard.org",
      "company": {
        "name": "Romaguera-Crona",
        "catchPhrase": "Multi-layered client-server neural-net",
        "bs": "harness real-time e-markets"
      }
    }
  },
  {
    "userId": 6,
    "id": 53,
    "title": "ut quo aut ducimus alias",
    "body": "minima harum praesentium eum rerum illo dolore\nquasi exercitationem rerum nam\nporro quis neque quo\nconsequatur minus dolor quidem veritatis sunt non explicabo similique",
    "user": {
      "id": 6,
      "name": "Mrs. Dennis Schulist",
      "username": "Leopoldo_Corkery",
      "email": "Karley_Dach@jasper.info",
      "address": {
        "street": "Norberto Crossing",
        "suite": "Apt. 950",
        "city": "South Christy",
        "zipcode": "23505-1337",
        "geo": {
          "lat": "-71.4197",
          "lng": "71.7478"
        }
      },
      "phone": "1-477-935-8478 x6430",
      "website": "ola.org",
      "company": {
        "name": "Considine-Lockman",
        "catchPhrase": "Synchronised bottom-line interface",
        "bs": "e-enable innovative applications"
      }
    }
  }
]
```
Use https://www.themoviedb.org/ REST API v3 with this criteria:

1. Get 10+ titles of Indonesian movies
2. Get movie list played by Keanu Reeves
3. Get movie list played by Robert Downey Jr. and Tom Holland
4. Get popular movie list that released on 2016 and the votes above 7.5

Get headlines from https://www.kompas.com/

Output example:

```
Title: Cerita Sripun, Dara Asal Semarang yang Taklukkan Hati David Beckham (1)
URL: https://regional.kompas.com/read/2018/03/29/07265661/cerita-sripun-dara-asal-semarang-yang-taklukkan-hati-david-beckham-1

Title: Aplikator Sepakat Tingkatkan Pendapatan Ojek "Online", Pengemudi Ngotot di Angka Rp 3.500
URL: https://nasional.kompas.com/read/2018/03/29/08514041/aplikator-sepakat-tingkatkan-pendapatan-ojek-online-pengemudi-ngotot-di

Title: Penampilan Modis Istri Kim Jong Un Saat Berkunjung ke China
URL: https://lifestyle.kompas.com/read/2018/03/29/063700020/penampilan-modis-istri-kim-jong-un-saat-berkunjung-ke-china

Title: Rusia Tantang Balik Inggris untuk Buktikan Tak Terlibat Racuni Skripal 
URL: https://internasional.kompas.com/read/2018/03/29/10534231/rusia-tantang-balik-inggris-untuk-buktikan-tak-terlibat-racuni-skripal
```

Get all information about new movies in theaters for today from CGV website

Output example:

```
A WRINKLE IN TIME

Jenis Film: Adventure, Family, Fantasy
Produser: Catherine Hand, Jim Whitaker
Sutradara: Ava Duvernay
Penulis: Jennifer Lee, Madeleine L'engle
Produksi: Walt Disney Pictures
Casts: Storm Reid, Oprah Winfrey, Chris Pine, Gugu Mbatha-raw, Reese Witherspoon, Michael Pea
Trailer: http://www.21cineplex.com/video/trailer-hd/a-wrinkle-in-time,4799.htm

Sinopsis
Diangkat dari novel fantasi karya Madeline L’Engle. A Wrinkle in Time menyuguhkan petualangan menakjubkan seorang anak bernama Meg Murrry (Storm Reid) menjelajahi ruang dan waktu untuk menemukan sang ayah yang menghilang secara misterius.
Disana ia menemukan tiga sosok ajaib yang membantu dirinya melewati berbagai rintangan dalam melintasi dunia..

------------------------------------------------------------------------------------------------------

JUNGLE

Jenis Film: Action, Adventure, Drama
Produser: Todd Fellman, Mike Gabrawy Gary Hamilton, Mark Lazarus, Dana Lustig, Greg Mclean
Sutradara: Greg Mclean
Penulis: Justin Monjo, Yossi Ghinsberg
Produksi: Momentum Pictures
Casts: Daniel Radcliffe, Alex Russell, Thomas Kretschmann, Yasmin Kassim, Joel Jackson, Jacek Koman
Trailer: http://www.21cineplex.com/video/trailer-hd/jungle,4815.htm

Sinopsis
Empat pelancong berangkat ke jantung hutan Amazon. Namun petualangan itu berubah menjadi mimpi buruk saat sebuah kecelakaan terjadi. Yossi (Daniel Radcliffe) harus bertahan hidup sendirian di tengah hutan selama berminggu-minggu.

Terdampar tanpa pisau, peta atau keterampilan bertahan hidup. Yossi mulai menyerah, ia bertanya-tanya apakah dia akan berhasil keluar dari hutan hidup-hidup.
```
