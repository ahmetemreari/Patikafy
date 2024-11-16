# Sanatçı Listesi ve Sorgular

Bu proje, belirli sanatçılar için bir veri tablosu oluşturur ve bu tablo üzerinden çeşitli sorgular gerçekleştirir. Proje, C# programlama dili kullanılarak geliştirilmiştir.

## Kullanılan Teknolojiler

- C#
- .NET Framework

## Proje Açıklaması

Bu proje, sanatçılar hakkında bilgi içeren bir liste oluşturur ve bu liste üzerinden çeşitli sorgular gerçekleştirir. Sorgular şunlardır:

1. Adı 'S' ile başlayan şarkıcılar
2. Albüm satışları 10 milyon'un üzerinde olan şarkıcılar
3. 2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar (Çıkış yıllarına göre gruplayarak, alfabetik bir sıra ile)
4. En çok albüm satan şarkıcı
5. En yeni çıkış yapan şarkıcı ve en eski çıkış yapan şarkıcı

## Kod Açıklaması

### Sanatci Sınıfı

Sanatçı bilgilerini tutmak için `Sanatci` adında bir sınıf oluşturulmuştur. Bu sınıfın dört özelliği vardır:

- `Ad`: Sanatçının adı
- `MuzikTuru`: Sanatçının yaptığı müzik türü
- `CikisYili`: Sanatçının çıkış yılı
- `AlbumSatislari`: Sanatçının albüm satışları (milyon cinsinden)

### Program Sınıfı

`Program` sınıfı, sanatçı listesini oluşturur ve istenen sorguları gerçekleştirir.

#### Sanatçı Listesi

Sanatçı bilgileri, `List<Sanatci>` kullanılarak bir listeye eklenir.

#### Sorgular

1. **Adı 'S' ile başlayan şarkıcılar**:
    ```csharp
    var sIleBaslayanlar = sanatcilar.Where(s => s.Ad.StartsWith("S")).ToList();
    ```

2. **Albüm satışları 10 milyon'un üzerinde olan şarkıcılar**:
    ```csharp
    var onMilyonUzeri = sanatcilar.Where(s => s.AlbumSatislari > 10).ToList();
    ```

3. **2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar**:
    ```csharp
    var ikiBinOncesiPop = sanatcilar
        .Where(s => s.CikisYili < 2000 && s.MuzikTuru.Contains("Pop"))
        .OrderBy(s => s.CikisYili)
        .ThenBy(s => s.Ad)
        .ToList();
    ```

4. **En çok albüm satan şarkıcı**:
    ```csharp
    var enCokAlbumSatan = sanatcilar.OrderByDescending(s => s.AlbumSatislari).FirstOrDefault();
    ```

5. **En yeni ve en eski çıkış yapan şarkıcılar**:
    ```csharp
    var enYeniCikisYapan = sanatcilar.OrderByDescending(s => s.CikisYili).FirstOrDefault();
    var enEskiCikisYapan = sanatcilar.OrderBy(s => s.CikisYili).FirstOrDefault();
    ```

## Nasıl Çalıştırılır

1. Projeyi bir C# geliştirme ortamında (örneğin, Visual Studio) açın.
2. `Program.cs` dosyasını çalıştırın.
3. Konsolda sorgu sonuçlarını görebilirsiniz.

## Katkıda Bulunma

Katkıda bulunmak isterseniz, lütfen bir pull request gönderin veya bir issue açın.

## Lisans

Bu proje MIT Lisansı ile lisanslanmıştır.
