using System;

class Program
{
    static void Main(string[] args)
    {
        bool devamEt = true;

        while (devamEt)
        {
            Console.WriteLine("Lütfen gitmek istediğiniz lokasyonu giriniz:");
            Console.WriteLine("1 - Bodrum (4000 TL)");
            Console.WriteLine("2 - Marmaris (3000 TL)");
            Console.WriteLine("3 - Çeşme (5000 TL)");

            string lokasyon = "";
            int tatilFiyati = 0;

            while (true)
            {
                Console.Write("Lokasyon: ");
                lokasyon = Console.ReadLine().Trim().ToLower();

                if (lokasyon == "bodrum")
                {
                    tatilFiyati = 4000;
                    lokasyon = "Bodrum";
                    break;
                }
                else if (lokasyon == "marmaris")
                {
                    tatilFiyati = 3000;
                    lokasyon = "Marmaris";
                    break;
                }
                else if (lokasyon == "çeşme" || lokasyon == "cesme")
                {
                    tatilFiyati = 5000;
                    lokasyon = "Çeşme";
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı lokasyon girdiniz. Lütfen 'Bodrum', 'Marmaris' veya 'Çeşme' yazınız.");
                }
            }

            Console.Write("\nKaç kişi için tatil planlıyorsunuz? ");
            int kisiSayisi;
            while (!int.TryParse(Console.ReadLine(), out kisiSayisi) || kisiSayisi <= 0)
            {
                Console.Write("Geçerli bir kişi sayısı giriniz: ");
            }

            Console.WriteLine("\nUlaşım şeklinizi seçiniz:");
            Console.WriteLine("1 - Kara yolu (Kişi başı 1500 TL gidiş-dönüş)");
            Console.WriteLine("2 - Hava yolu (Kişi başı 4000 TL gidiş-dönüş)");

            int ulasimSecimi;
            int ulasimUcreti = 0;
            while (true)
            {
                Console.Write("Seçiminiz (1 veya 2): ");
                if (int.TryParse(Console.ReadLine(), out ulasimSecimi))
                {
                    if (ulasimSecimi == 1)
                    {
                        ulasimUcreti = 1500;
                        break;
                    }
                    else if (ulasimSecimi == 2)
                    {
                        ulasimUcreti = 4000;
                        break;
                    }
                }
                Console.WriteLine("Hatalı seçim yaptınız. Lütfen 1 ya da 2 giriniz.");
            }

            // Bilgilendirme metni
            Console.WriteLine($"\nSeçilen Lokasyon: {lokasyon}");
            Console.WriteLine($"Kişi Sayısı: {kisiSayisi}");
            Console.WriteLine($"Ulaşım Türü: {(ulasimSecimi == 1 ? "Kara yolu" : "Hava yolu")}");

            switch (lokasyon)
            {
                case "Bodrum":
                    Console.WriteLine("Bodrum'da deniz, gece hayatı ve tarihi yerlerle dolu keyifli bir tatil sizi bekliyor!");
                    break;
                case "Marmaris":
                    Console.WriteLine("Marmaris’te doğa yürüyüşleri, koy gezileri ve plaj keyfi yapabilirsiniz.");
                    break;
                case "Çeşme":
                    Console.WriteLine("Çeşme’de sörf, plaj partileri ve Ege mutfağının tadını çıkarabilirsiniz.");
                    break;
            }

            // Toplam ücret hesaplama
            int toplamTutar = kisiSayisi * (tatilFiyati + ulasimUcreti);
            Console.WriteLine($"\nToplam Tatil Tutarı: {toplamTutar} TL");

            // Devam etmek istiyor mu?
            Console.Write("\nBaşka bir tatil planlamak ister misiniz? (E/H): ");
            string cevap = Console.ReadLine().Trim().ToLower();
            if (cevap != "e")
            {
                devamEt = false;
                Console.WriteLine("İyi günler dileriz!");
            }

            Console.WriteLine("\n--------------------------------------------\n");
        }
    }
}
