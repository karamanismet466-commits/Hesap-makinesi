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

// 2 class a ayırmamın sebebi class sistemini anladığımı gösterebilmek eğer ki tek class da yapmak istesem get set kısmını public static int ve privare static int olarak yazıp static void main ile class program arasına yazardım


