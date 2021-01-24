using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BankaMusteriTakip
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine($" Müşteri TC: { musteri.TcKimlikNo } \n Müşteri Ad: {musteri.Ad} \n Müşteri Soyad: {musteri.Soyad} \n Müşteri Cinsiyet: {musteri.Cinsiyet} \n Müşteri Yas: {musteri.Yas}");


            Console.WriteLine("-------------Kayıt Başarılı!!!----------------");
        }


        public void MusteriSil(List<Musteri> musteriler, string tcKimlikNo)
        {
            var result = musteriler.Where(x => x.TcKimlikNo == tcKimlikNo);
            Console.WriteLine($" Müşteri TC: { result.FirstOrDefault().TcKimlikNo } \n Müşteri Ad: {result.FirstOrDefault().Ad} \n Müşteri Soyad: {result.FirstOrDefault().Soyad} \n Müşteri Cinsiyet: {result.FirstOrDefault().Cinsiyet} \n Müşteri Yas: {result.FirstOrDefault().Yas}");
            musteriler.RemoveAll(x => x.TcKimlikNo == tcKimlikNo);
            Console.WriteLine("-------------Silme İşlemi Başarılı!!!----------------");
        }


        public void MusteriListele(List<Musteri> musteriler)
        {
            Console.WriteLine("---------------------------" + musteriler.Count + " Adet Müşteri Listelendi------------------------");
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine($" Müşteri TC: { musteri.TcKimlikNo } \n Müşteri Ad: {musteri.Ad} \n Müşteri Soyad: {musteri.Soyad} \n Müşteri Cinsiyet: {musteri.Cinsiyet} \n Müşteri Yas: {musteri.Yas}");
                Console.WriteLine("-------------------------------------------------------------------------------------------");
            }
        }



    }
}
