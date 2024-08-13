int[] sayilar = new int[10];

// 2. Aşama: Dizinin elemanlarını for döngüsü ile doldurma
for (int i = 0; i < sayilar.Length; i++)
{
    Console.Write($"Lütfen {i + 1}. sayıyı giriniz: ");
    sayilar[i] = int.Parse(Console.ReadLine());
}

// Foreach döngüsü ile diziyi ekrana yazdırma
Console.WriteLine("\nGirdiğiniz sayılar:");
foreach (int sayi in sayilar)
{
    Console.WriteLine(sayi);
}

// 3. Aşama: Kullanıcıdan alınan yeni bir değeri diziye ekleme (11. eleman olarak)
Console.Write("\nLütfen diziye eklenecek 11. sayıyı giriniz: ");
int yeniSayi = int.Parse(Console.ReadLine());

// Yeni eleman eklemek için diziyi genişletme
Array.Resize(ref sayilar, sayilar.Length + 1);
sayilar[sayilar.Length - 1] = yeniSayi;

// 4. Aşama: Diziyi büyükten küçüğe sıralayıp ekrana yazdırma
Array.Sort(sayilar);
Array.Reverse(sayilar);

Console.WriteLine("\nBüyükten küçüğe sıralanmış dizi:");
foreach (int sayi in sayilar)
{
    Console.WriteLine(sayi);
}