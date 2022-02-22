using System;

namespace Alıştırma
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] bilgi = {"Cemal","Çakmak"};
            
            
            Console.WriteLine($"Adınız: {bilgi[0]}");
            Console.WriteLine($"Soyadınız: {bilgi[1]}");
            Console.WriteLine($"Merhaba {bilgi[0]} {bilgi[1]}");

            Console.WriteLine("***Alıştırma 2***");
            //Kullanıcıdan 2 sayı isteyerek bu sayıların toplamını bulan program

            Console.Write("Lütfen İlk Sayıyı Giriniz: ");
            int sayi1= Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen İkinci Sayıyı Giriniz: ");
            int sayi2= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sayıların Toplamı = " + (sayi1 + sayi2));

            Console.WriteLine("***Alıştırma 3***");
            //Dikdörtgenin alanını ve çevresini hesaplayarak ekranda gösteren program

            Console.Write("Lütfen Kısa Kenarı Giriniz: ");
            int kisaKenar=Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen Uzun Kenarı Giriniz: ");
            int uzunKenar=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Alan = " + (kisaKenar*uzunKenar));
            Console.WriteLine("Çevre = " + 2*(kisaKenar+uzunKenar));

            Console.WriteLine("***Alıştırma 4***");
            // Girilen sayının tek mi çift mi olduğunu bulan program
             Console.Write("Lütfen Bir Sayı Giriniz: ");
             int sayi3 = Convert.ToInt32(Console.ReadLine());
             if ( sayi3%2==0)
             {
                 Console.WriteLine("Girilen Sayı çifttir");
             }
             else
             {
                 Console.WriteLine("Girilen sayı tektir");
             }
              
             Console.WriteLine("***Alıştırma 5***"); 
             //Girilen sayının 0-100 arasında olup olmadığını kontrol eden program
             Console.Write("Lütfen Bir Sayı Giriniz: ");
             int sayi4= Convert.ToInt32(Console.ReadLine());
            

                if( sayi4 < 100)
                {
                    Console.WriteLine("Sayı 0 ile 100 arasındadır");
                }
                else
                {
                    Console.WriteLine("Sayı 0 ile 100 arasında değildir");
                }

            Console.WriteLine("***Alıştırma 6***");

            //: Vücut Kitle İndeksi hesaplayan program
            double kilo,boy,indeks = 0;
            Console.Write("Lütfen Kilonuzu Giriniz: ");
            kilo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Lütfen Boyunuzu Giriniz (Or:1,71): ");
            boy = Convert.ToDouble(Console.ReadLine());
            indeks = kilo / (boy * boy);
             Console.WriteLine("Vücut Kitle İndexiniz : {0}",indeks);

             Console.WriteLine("***Alıştırma 7***");
             //Cümledeki harf sayısını bulan program           
             
             string cumle = "Harf sayısını bulalım. ";
             cumle=cumle.Replace(" ","");
             
             Console.WriteLine("Yukarıdaki cümlede toplam {0} harf vardır.", cumle.Length);           
        }
    }
}
