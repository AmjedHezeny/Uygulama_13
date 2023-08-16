using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Microsoft'un sunduğu bazı hazır string metodları sayesinde işlemlerimizi kolaylaştırabiliriz.
            // En sık kullanılan string metodlarını örneklerle inceleyelim.

            //-------------------------------------------------------------

            string metin = "Merhaba Dünya";

            int karakterUzunlugu = metin.Length; // Metni karakter sayısını alır
            int indexA = metin.IndexOf('a'); // İlk 'a' karakterinin indexini bulur
            int sonAIndex = metin.LastIndexOf('a'); // Son 'a' karakterinin indexini bulur
            bool iceriyorMu = metin.Contains("Merhaba"); // Metin içinde "Merhaba" kelimesini arar
            string yeniMetin = metin.Replace("Dünya", "Ay"); // "Dünya"yı "Ay" ile değiştirir
            string buyukHarfli = metin.ToUpper(); // Metni büyük harflere çevirir
            string kucukHarfli = metin.ToLower(); // Metni küçük harflere çevirir
            string metin1 = "          Selam       ";
            string temizMetin1 = metin1.Trim(); // Metin başındaki ve sonundaki boşlukları temizler
            string metinler = "Ahmet Mehmet Ali Ayşe";
            string[] isimler = metinler.Split(' '); // Metni belirli bir karakterle böler

            Console.WriteLine("Karakter Uzunluğu: " + karakterUzunlugu);
            Console.WriteLine("'a' Karakterinin İndexi: " + indexA);
            Console.WriteLine("Son 'a' Karakterinin İndexi: " + sonAIndex);
            Console.WriteLine("Metin içeriyor mu? " + iceriyorMu);
            Console.WriteLine("Değiştirilmiş Metin: " + yeniMetin);
            Console.WriteLine("Büyük Harfli Metin: " + buyukHarfli);
            Console.WriteLine("Küçük Harfli Metin: " + kucukHarfli);
            Console.WriteLine("Temiz Metin 1: " + temizMetin1);
            Console.WriteLine("Bölünmüş İsimler:");
            foreach (string isim in isimler)
            {
                Console.WriteLine(isim);
            }

            Console.ReadKey();  
        }
    }
}
