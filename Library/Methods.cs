using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Methods:Books
    {
        public void Ekle(Books books,Persons persons)
        {
            
            Console.WriteLine("İsim: " + persons.İsim);
            Console.WriteLine("Soyisim: " + persons.Soyisim);
            Console.WriteLine("Teslim Alınan Kitap: " + books.Kitapİsmi);
            TeslimSuresi(books);
        }
        public void Sil(Books books,Persons persons,int Sure)
        {
            Console.WriteLine("İsim: " + persons.İsim);
            Console.WriteLine("Soyisim: " + persons.Soyisim);
            Console.WriteLine("İade Edilen Kitap: "+ books.Kitapİsmi);
            
            if (Sure<= (books.SayfaSayisi - (books.SayfaSayisi % 10)) / 10)
            {
                Console.WriteLine("Kitabı zamanında getirdiğiniz için teşekkür ederiz");
            }
            else
            {
                Console.WriteLine("kitabı zamanında getirmediğiniz için 1 ay boyunca yeni kitap alamazsınız!");
            }
        }
        public int TeslimSuresi(Books books)
        {
            int t;
            t = (books.SayfaSayisi - (books.SayfaSayisi % 10)) / 10;
            Console.WriteLine("Teslim Süresi: "+ t+"gün");
            Console.WriteLine("Lütfen Teslim Gününü Geçmeyiniz!");
            return t;
        }
    }
}
