
using System;


Console.WriteLine("Lütfen aşağıdaki bilgileri giriniz");

Console.Write("T.C. Kimlik Numarası:");
string tckno = Console.ReadLine();

Console.Write("Ad:");
string name = Console.ReadLine();

Console.Write("Soyad:");
string surname = Console.ReadLine();

Console.Write("Telefon Numarası:");
string phonenum = Console.ReadLine();

Console.Write("Yaş:");
int age = int.Parse(Console.ReadLine());

Console.Write("İlk alınan Ürünün Fiyatı:");
int priceFirst = int.Parse(Console.ReadLine());

Console.Write("İkinci Alınan Ürünün Fiyatı:");
int priceSecond = int.Parse(Console.ReadLine());

int priceLast = priceFirst + priceSecond;


Console.WriteLine($"{tckno} T.C. numaralı {name} {surname} isimli kişi için kayıt oluşturulmuştur.");
Console.WriteLine($"{phonenum} telefon numarasına bildirim gönderilmiştir.");
Console.WriteLine($"{priceLast}: toplam harcama karşılığı kazanılan %10 patika puan miktarı {priceLast * 0.1} ");




