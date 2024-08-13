# Diziler Üzerinde İşlemler - C#

Bu C# programı, diziler üzerinde temel işlemleri gösteren bir örnektir. Program, dört ana aşamadan oluşmaktadır:

## 1. Aşama: 10 Elemanlı Bir Dizi Tanımlama
Program, `int[] sayilar = new int[10];` ifadesi ile 10 adet tamsayı verisi alacak bir dizi tanımlar.

## 2. Aşama: Diziyi For Döngüsü ile Doldurma ve Foreach Döngüsü ile Ekrana Yazdırma
Kullanıcıdan alınan 10 adet sayı, for döngüsü kullanılarak diziye eklenir. Ardından, `foreach` döngüsü ile bu sayıların ekrana yazdırılması sağlanır.

## 3. Aşama: Diziye Yeni Bir Eleman Ekleme
Kullanıcıdan alınan yeni bir sayı, dizinin 11. elemanı olarak eklenir. Bunun için `Array.Resize` metodu kullanılarak dizinin boyutu artırılır.

## 4. Aşama: Diziyi Büyükten Küçüğe Sıralama
`Array.Sort` metodu ile dizi küçükten büyüğe sıralanır. Ardından `Array.Reverse` metodu ile dizi ters çevrilerek büyükten küçüğe sıralanmış hale getirilir.

### Çalıştırma
Bu kodu çalıştırmak için bir C# derleyicisi kullanarak derleyip çalıştırmanız yeterlidir. Program, kullanıcıdan sayı girişi bekleyecek ve sonrasında belirtilen işlemleri gerçekleştirecektir.
