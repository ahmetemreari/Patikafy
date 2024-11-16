using System;
using System.Collections.Generic;
using System.Linq;

public class Sanatci
{
    public string Ad { get; set; }
    public string MuzikTuru { get; set; }
    public int CikisYili { get; set; }
    public int AlbumSatislari { get; set; }
}

public class Program
{
    public static void Main()
    {
        List<Sanatci> sanatcilar = new List<Sanatci>
        {
            // Ad, Müzik Türü, Çıkış Yılı, Albüm Satışları ekleme 

            new Sanatci { Ad = "Ajda Pekkan", MuzikTuru = "Pop", CikisYili = 1968, AlbumSatislari = 20 },
            new Sanatci { Ad = "Sezen Aksu", MuzikTuru = "Türk Halk Müziği / Pop", CikisYili = 1971, AlbumSatislari = 10 },
            new Sanatci { Ad = "Funda Arar", MuzikTuru = "Pop", CikisYili = 1999, AlbumSatislari = 3 },
            new Sanatci { Ad = "Sertab Erener", MuzikTuru = "Pop", CikisYili = 1994, AlbumSatislari = 5 },
            new Sanatci { Ad = "Sıla", MuzikTuru = "Pop", CikisYili = 2009, AlbumSatislari = 3 },
            new Sanatci { Ad = "Serdar Ortaç", MuzikTuru = "Pop", CikisYili = 1994, AlbumSatislari = 10 },
            new Sanatci { Ad = "Tarkan", MuzikTuru = "Pop", CikisYili = 1992, AlbumSatislari = 40 },
            new Sanatci { Ad = "Hande Yener", MuzikTuru = "Pop", CikisYili = 1999, AlbumSatislari = 7 },
            new Sanatci { Ad = "Hadise", MuzikTuru = "Pop", CikisYili = 2005, AlbumSatislari = 5 },
            new Sanatci { Ad = "Gülben Ergen", MuzikTuru = "Pop / Türk Halk Müziği", CikisYili = 1997, AlbumSatislari = 10 },
            new Sanatci { Ad = "Neşet Ertaş", MuzikTuru = "Türk Halk Müziği / Türk Sanat Müziği", CikisYili = 1960, AlbumSatislari = 2 }
        };

        // Adı 'S' ile başlayan şarkıcıları listeleme
        var sIleBaslayanlar = sanatcilar.Where(s => s.Ad.StartsWith("S")).ToList();
        Console.WriteLine("Adı 'S' ile başlayan şarkıcılar:");
        sIleBaslayanlar.ForEach(s => Console.WriteLine(s.Ad));

        // Albüm satışları 10 milyon'un üzerinde olan şarkıcıları listeleme
        var onMilyonUzeri = sanatcilar.Where(s => s.AlbumSatislari > 10).ToList();
        Console.WriteLine("\nAlbüm satışları 10 milyon'un üzerinde olan şarkıcılar:");
        onMilyonUzeri.ForEach(s => Console.WriteLine(s.Ad));

        // 2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcıları listeleme ve sıralama
        var ikiBinOncesiPop = sanatcilar
            .Where(s => s.CikisYili < 2000 && s.MuzikTuru.Contains("Pop"))
            .OrderBy(s => s.CikisYili)
            .ThenBy(s => s.Ad)
            .ToList();
        Console.WriteLine("\n2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar:");
        ikiBinOncesiPop.ForEach(s => Console.WriteLine($"{s.CikisYili} - {s.Ad}"));

        // En çok albüm satan şarkıcı ve albüm satış sayısını bulma ve yazdırma
        var enCokAlbumSatan = sanatcilar.OrderByDescending(s => s.AlbumSatislari).FirstOrDefault();
        Console.WriteLine($"\nEn çok albüm satan şarkıcı: {enCokAlbumSatan.Ad}");

        // En yeni ve en eski çıkış yapan şarkıcıları bulma ve yazdırma
        var enYeniCikisYapan = sanatcilar.OrderByDescending(s => s.CikisYili).FirstOrDefault();
        var enEskiCikisYapan = sanatcilar.OrderBy(s => s.CikisYili).FirstOrDefault();
        Console.WriteLine($"\nEn yeni çıkış yapan şarkıcı: {enYeniCikisYapan.Ad}");
        Console.WriteLine($"En eski çıkış yapan şarkıcı: {enEskiCikisYapan.Ad}");
    }
}
