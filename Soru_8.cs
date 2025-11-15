// Kullanıcıdan Sırasıyla Adını,Soyadını Numarasını ve Bölümünü isteyiniz.
//  Daha sonra bu veriler ile aşağıdaki çıktıyı elde ediniz.

// Adınızı Giriniz:Mukaddes
// Soyadınızı Giriniz:Meral
// Numaranızı Giriniz:535353535
// Bölümünüzü Giriniz:Yönetim Bilişim Sistemleri
// Hoşgeldiniz Mukaddes Meral. Numaranız: 535353535, Bölümünüz: Yönetim Bilisim Sistemleri

Console.Write("Adınızı Giriniz:");
string ad = Console.ReadLine();

Console.Write("Soyadınızı Giriniz:");
string soyad = Console.ReadLine();

Console.Write("Numaranızı Giriniz:");
string numara = Console.ReadLine();


Console.Write("Bölümünüzü Giriniz:");
string bolum = Console.ReadLine();

Console.Write($"Hoşgeldiniz {ad} {soyad}. Numaranız: {numara}, Bölümünüz: {bolum}");