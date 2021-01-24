using System;
using System.Collections.Generic;
using System.Linq;
namespace BankaMusteriTakip
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager manager = new MusteriManager();
           

           var musteriler = new List<Musteri>();

            MusteriEkle(manager,musteriler);



            bool kontrol = true;
            while (kontrol == true)
            {
                Console.WriteLine("Müşterileri Listelemek İçin 1'e Müşteri Eklemek İçin 2'ye Müşteri Silmek İçin 3'e Çıkış İçin 4'e Basınız:");
                string press = Console.ReadLine();
                if (press == "1")
                {
                    manager.MusteriListele(musteriler);
                }
                else if (press == "2")
                {
                    MusteriEkle(manager, musteriler);
                }
                else if (press == "3")
                {
                    Console.Write("Silmek İstediğiniz Müşterinin TC Numarasını Girin: ");
                    string tckimlikno = Console.ReadLine();
                    manager.MusteriSil(musteriler,tckimlikno);
                }
                else if (press == "4")
                {
                    Console.WriteLine("Çıkış İşlemi Başarılı!!!");
                    kontrol = false;
                }
                else
                {
                    Console.WriteLine("Lütfen Geçerli Bir Değer Giriniz!!!");
                }
            }       
            Console.ReadLine();
        }
        static void MusteriEkle(MusteriManager manager, List<Musteri> musteriler)
        {
            Console.Write("Müşteri Girişi Yapınız! Kaç Adet Müşteri Girişi Yapacaksınız: ");

            int musteriAdet = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < musteriAdet; i++)
            {
                Musteri musteri = new Musteri();
                Console.WriteLine("Müşteri TC No Giriniz: ");
                musteri.TcKimlikNo = Console.ReadLine();
                Console.WriteLine("Müşteri Ad Giriniz: ");
                musteri.Ad = Console.ReadLine();
                Console.WriteLine("Müşteri Soyad Giriniz: ");
                musteri.Soyad = Console.ReadLine();
                Console.WriteLine("Müşteri Cinsiyet Giriniz: ");
                musteri.Cinsiyet = Console.ReadLine();
                Console.WriteLine("Müşteri Yaş Giriniz: ");
                musteri.Yas = Convert.ToInt32(Console.ReadLine());
                manager.MusteriEkle(musteri);
                musteriler.Add(musteri);
            }

        }
    }
}
