//Kullanıcının girdiği sayının faktöriyelini hesaplayan programı yazınız. Beklenen yapı aşağıdaki gibi olmalıdır
//Faktöriyelinin Hesaplanmasını İstediğiniz Sayıyı Giriniz: 5
//Çıktı: 5 Sayısının faktöriyeli 120 dir.

int sayi = 1;
int faktoriyel = 1;

Console.Write("Faktöriyelinin Hesaplanmasını İstediğiniz Sayıyı Giriniz: ");
sayi = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= sayi; i++)
{
    faktoriyel *= i;
}

Console.WriteLine($"{sayi} Sayısının faktöriyeli {faktoriyel} dir.");