using System;

class Program
{
    static void Main()
    {
        SayiKontrol islemler = new SayiKontrol();
        string girilen = "";

        while (girilen != "N" && girilen != "n")
        {
            Console.WriteLine("Bir sayı giriniz (Çıkış yapmak N kullanabilirsiniz):");
            girilen = Console.ReadLine();

            int sayi;
            if (int.TryParse(girilen, out sayi))
            {
                islemler.Sayi = sayi;

                if (islemler.CiftMi())
                {
                    Console.WriteLine(islemler.Sayi + " sayısı çifttir.");
                }
                else
                {
                    Console.WriteLine(islemler.Sayi + " sayısı tektir.");
                }
            }
        }
    }

    class SayiKontrol
    {
        private int sayiDegeri;

        public int Sayi
        {
            get
            {
                return sayiDegeri;
            }
            set
            {
                sayiDegeri = value;
            }
        }

        public bool CiftMi()
        {
            if (sayiDegeri % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}




