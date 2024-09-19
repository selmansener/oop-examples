using InheritanceExample.HesapMakineleri;

namespace InheritanceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hangi hesap makinesini kullanmak istediğinizi seçiniz:");
            Console.WriteLine("(1) - Basit");
            Console.WriteLine("(2) - Kompleks");
            var secilenHesapMakinesi = Convert.ToInt32(Console.ReadLine());

            if (secilenHesapMakinesi == 1)
            {
                BasitHesapMakinesiniCalistir();
            }
            else if (secilenHesapMakinesi == 2)
            {
                KompleksHesapMakinesiniCalistir();
            }
            else
            {
                Console.WriteLine("Geçersiz bir tür girdiniz.");
            }
        }

        static void BasitHesapMakinesiniCalistir()
        {
            Console.WriteLine("Yapmak istediğiniz işlemi giriniz: Örn: toplama için 1 giriniz");
            Console.WriteLine("(1) - Toplama");
            Console.WriteLine("(2) - Çıkarma");
            Console.WriteLine("(3) - Çarpma");
            Console.WriteLine("(4) - Bölme");
            var islemNumarasi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İlk sayıyı giriniz:");
            var sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci sayıyı giriniz:");
            var sayi2 = Convert.ToInt32(Console.ReadLine());

            var basitHesapMakinesi = new BasitHesapMakinesi();
            int sonuc = 0;
            switch (islemNumarasi)
            {
                case 1:
                    sonuc = basitHesapMakinesi.Topla(sayi1, sayi2);
                    break;
                case 2:
                    sonuc = basitHesapMakinesi.Cikar(sayi1, sayi2);
                    break;
                case 3:
                    sonuc = basitHesapMakinesi.Carp(sayi1, sayi2);
                    break;
                case 4:
                    sonuc = basitHesapMakinesi.Bol(sayi1, sayi2);
                    break;
                default:
                    Console.WriteLine("Geçersiz işlem türü girdiniz");
                    break;
            }

            Dictionary<int, string> islemTuru = new Dictionary<int, string>
            {
                { 1, "Toplama" },
                { 2, "Çıkarma" },
                { 3, "Çarpma" },
                { 4, "Bölme" }
            };

            Console.WriteLine($"{islemTuru[islemNumarasi]} işleminin sonucu: {sonuc}");
        }

        static void KompleksHesapMakinesiniCalistir()
        {
            Console.WriteLine("Yapmak istediğiniz işlemi giriniz: Örn: Faktöryel için 5 giriniz");
            Console.WriteLine("(1) - Toplama");
            Console.WriteLine("(2) - Çıkarma");
            Console.WriteLine("(3) - Çarpma");
            Console.WriteLine("(4) - Bölme");
            Console.WriteLine("(5) - Faktöryel");
            Console.WriteLine("(6) - Üst");
            var islemNumarasi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İlk sayıyı giriniz:");
            var sayi1 = Convert.ToInt32(Console.ReadLine());

            int sayi2 = 0;
            if (islemNumarasi != 5)
            {
                Console.WriteLine("İkinci sayıyı giriniz:");
                sayi2 = Convert.ToInt32(Console.ReadLine());
            }

            var kompleksHesapMakinesi = new KompleksHesapMakinesi();
            int sonuc = 0;
            switch (islemNumarasi)
            {
                case 1:
                    sonuc = kompleksHesapMakinesi.Topla(sayi1, sayi2);
                    break;
                case 2:
                    sonuc = kompleksHesapMakinesi.Cikar(sayi1, sayi2);
                    break;
                case 3:
                    sonuc = kompleksHesapMakinesi.Carp(sayi1, sayi2);
                    break;
                case 4:
                    sonuc = kompleksHesapMakinesi.Bol(sayi1, sayi2);
                    break;
                case 5:
                    sonuc = kompleksHesapMakinesi.Faktoryel(sayi1);
                    break;
                case 6:
                    sonuc = kompleksHesapMakinesi.Ust(sayi1, sayi2);
                    break;
                default:
                    Console.WriteLine("Geçersiz işlem türü girdiniz");
                    break;
            }

            Dictionary<int, string> islemTuru = new Dictionary<int, string>
            {
                { 1, "Toplama" },
                { 2, "Çıkarma" },
                { 3, "Çarpma" },
                { 4, "Bölme" },
                { 5, "Faktöryel" },
                { 6, "Üst" },
            };

            Console.WriteLine($"{islemTuru[islemNumarasi]} işleminin sonucu: {sonuc}");
        }
    }
}
