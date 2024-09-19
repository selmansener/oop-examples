namespace InheritanceExample.HesapMakineleri
{
    internal class BasitHesapMakinesi
    {
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        // Method overload için örnek
        public decimal Topla(decimal sayi1, decimal sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }

        // Method overload için örnek
        public decimal Cikar(decimal sayi1, decimal sayi2)
        {
            return sayi1 - sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        // Method overload için örnek
        public decimal Carp(decimal sayi1, decimal sayi2)
        {
            return sayi1 * sayi2;
        }

        public int Bol(int sayi1, int sayi2)
        {
            return sayi1 / sayi2;
        }

        // Method overload için örnek
        public decimal Bol(decimal sayi1, decimal sayi2)
        {
            return sayi1 / sayi2;
        }
    }
}
