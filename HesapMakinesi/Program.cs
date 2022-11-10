
using Hesaplama;
Hesap hesap = new Hesap();
Basla();
void Basla()
{
    decimal x = Cevir("1.sayi");
    decimal y = Cevir("2.sayi");
    decimal sonuc = Islem(x, y);
    Console.WriteLine("Sonuc :" + sonuc);
    Console.WriteLine("karekökü " + Hesap.KokAl(Convert.ToDouble(x)));
    Console.WriteLine("karekökü " + Hesap.KokAl(Convert.ToDouble(y)));


}

decimal Islem(decimal x, decimal y)
{
    decimal sonuc = 0;
    Console.WriteLine("İşlem kodu?");
    string iskod = Console.ReadLine();
    if(iskod == "+")
    {
        sonuc = Hesap.Topla(x,y);
    }

  else if (iskod == "-")
    {
        sonuc = Hesap.Cikar(x, y);
    }
    else if (iskod == "*")
    {
        sonuc = Hesap.Carp(x, y);
    }
    else if (iskod == "/")
    {
        sonuc = Hesap.Bol(x, y);
    }


    else
    {
        Console.WriteLine("Yanlış Kod");
       return Islem(x, y);
    }
    return sonuc;
}

decimal Cevir(string txt)
{
    Console.WriteLine(txt);
    return Convert.ToDecimal(Console.ReadLine());
}
