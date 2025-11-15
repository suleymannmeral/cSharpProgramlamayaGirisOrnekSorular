// 1’den 20’ye kadar olan sayıları ekrana yazdıran bir program yazınız. 
// Her bir sayı için, sayı tek ise yanına “tektir”, çift ise “çifttir” yazdırınız.

for (int i = 1; i <= 20; i++)
{
    if (i % 2 == 0)
        Console.WriteLine($"{i} çifttir");
    else
        Console.WriteLine($"{i} tektir");
}
