using System;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Books book1 = new Books();
            book1.KitapTuru = "Roman";
            book1.Kitapİsmi = "Tutunamayanlar";
            book1.Yazar = "Oğuz Atay";
            book1.SayfaSayisi = 724;

            Books book2 = new Books();
            book2.KitapTuru = "Roman";
            book2.Kitapİsmi = "Hayvan Çiftliği";
            book2.Yazar = "George Orwel";
            book2.SayfaSayisi = 160;

            Books book3 = new Books();
            book3.KitapTuru = "Roman";
            book3.Kitapİsmi = "İçimizdeki Şeytan";
            book3.Yazar = "Sabahattin Ali";
            book3.SayfaSayisi = 268;

            Console.WriteLine("KİTAPLAR");
            Console.WriteLine(" ");
            Books[] kitaplar = new Books[] { book1, book2, book3 };

            foreach (Books books in kitaplar)
            {
                Console.WriteLine("Kitabın Türü: "+ books.KitapTuru);
                Console.WriteLine("Kitabın İsmi: "+ books.Kitapİsmi);
                Console.WriteLine("Kitabın Yazarı: "+books.Yazar);
                Console.WriteLine("Kitabın Sayfa Sayısı: "+ books.SayfaSayisi);
                Console.WriteLine(" ");
            }

            Console.WriteLine("------------------------------------");
            Methods methods = new Methods();

            Persons persons1 = new Persons();
            persons1.İsim = "Begüm";
            persons1.Soyisim = "Ünal";

            methods.Ekle(book1,persons1);
            methods.Sil(book1, persons1,70);

        }
    }
}
