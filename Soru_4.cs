//Kullanıcıdan sınıf mevcudunu isteyiniz. Daha sonra kullanıcıdan sınav sayısı isteyiniz.
//Sırayla ogrencilerin ortalamsını hesaplayıp yazdırınız. Son olarak genel ortalamayı yazdırınız.
//Beklenen çıktı aşağıdaki gibi olmalıdır.


//Sinif mevcudunu giriniz: 3 //girdi
//Her ögrenci için kaç sinav notu girilecek: 2 //girdi

//1.ögrencinin notlarini giriniz:
//  1.sinav notu: 20 //girdi
//  2.sinav notu: 25 //girdi
//1.ögrencinin ortalamasi: 22,50

//2.ögrencinin notlarini giriniz:
//  1.sinav notu: 50 //girdi
//  2.sinav notu: 60 //girdi
//2.ögrencinin ortalamasi: 55,00

//3.ögrencinin notlarini giriniz:
//  1.sinav notu: 70 //girdi
//  2.sinav notu: 80//girdi
//3.ögrencinin ortalamasi: 75,00

//Sinifin genel ortalamasi: 50,83


Console.Write("Sınıf mevcudunu giriniz: ");
int ogrenciSayisi = Convert.ToInt32(Console.ReadLine());

Console.Write("Her öğrenci için kaç sınav notu girilecek: ");
int sinavSayisi = Convert.ToInt32(Console.ReadLine());

double genelToplam = 0;

for (int i = 1; i <= ogrenciSayisi; i++)
{
    double ogrenciToplam = 0;

    Console.WriteLine($"\n{i}. öğrencinin notlarını giriniz:");

    for (int j = 1; j <= sinavSayisi; j++)
    {
        Console.Write($"  {j}. sınav notu: ");
        double not = Convert.ToDouble(Console.ReadLine());
        ogrenciToplam += not;
    }

    double ogrenciOrt = ogrenciToplam / sinavSayisi;
    Console.WriteLine($"{i}. öğrencinin ortalaması: {ogrenciOrt:F2}");

    genelToplam += ogrenciOrt;
}

double sinifOrt = genelToplam / ogrenciSayisi;
Console.WriteLine($"\nSınıfın genel ortalaması: {sinifOrt:F2}");
