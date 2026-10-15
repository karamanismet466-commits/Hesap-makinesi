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
               

