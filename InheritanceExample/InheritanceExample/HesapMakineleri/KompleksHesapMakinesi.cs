namespace InheritanceExample.HesapMakineleri
{
    internal class KompleksHesapMakinesi : BasitHesapMakinesi
    {
        public int Faktoryel(int sayi)
        {
            int sonuc = 1;
            for (int i = sayi; i > 1; i--)
            {
                sonuc = Carp(sonuc, i);
            }

            return sonuc;
        }

        public int Ust(int sayi, int ust)
        {
            int sonuc = sayi;

            for (int i = 0; i < ust - 1; i++)
            {
                sonuc = Carp(sonuc, sayi);
            }

            return sonuc;
        }
    }
}
