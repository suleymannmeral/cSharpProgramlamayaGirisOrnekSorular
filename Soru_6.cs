// Kullanıcıdan 5 tane sayı girmesini isteyen ve bu sayıların toplamını ekrana yazdıran bir program yazınız. 

int[] sayilar = new int[5];
int toplam = 0;

for (int i = 0; i < 5; i++)
{
    Console.Write($"{i + 1}. sayıyı girin: ");
    sayilar[i] = int.Parse(Console.ReadLine());
    toplam += sayilar[i];
}

Console.WriteLine("Toplam: " + toplam);
