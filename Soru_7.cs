// Kullanıcıdan vize ve final notunu isteyiniz. Ortalaması 60 ve 60 dan büyük ise geçti,
// 60’dan küçük ise ekrana kaldı yazınız. Beklenen yapı aşağıda verilmiştir.

// Vize notunu girin: 80
// Final notunu girin: 100
// Ortalamanız: 92 Geçtiniz


Console.Write("Vize notunu girin: ");
int vize = int.Parse(Console.ReadLine());

Console.Write("Final notunu girin: ");
int final = int.Parse(Console.ReadLine());

double average = vize*0.4 + final*0.6;

if (average < 60)
{
    Console.WriteLine($"Ortalamanız: {average} Kaldınız");
}
else
{
    Console.WriteLine($"Ortalamanız: {average} Geçtiniz");
}
