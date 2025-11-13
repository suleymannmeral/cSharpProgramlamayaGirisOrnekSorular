//Kullanıcıdan sıcaklık değeri isteyiniz. Sıcaklık 0 değerinin altında ise “Soğuk”, 
//0 ile 10 derecenin arasında ise “ılık”, 10 derecenin üstünde ise konsol ekranına “sıcak” yazdırınız.   

Console.Write("Sıcaklık değerini giriniz: ");
double sicaklik = Convert.ToDouble(Console.ReadLine());

if (sicaklik < 0)
{
    Console.WriteLine("Soğuk");
}
else if (sicaklik >= 0 && sicaklik <= 10)
{
    Console.WriteLine("Ilık");
}
else // sicaklik > 10
{
    Console.WriteLine("Sıcak");
}