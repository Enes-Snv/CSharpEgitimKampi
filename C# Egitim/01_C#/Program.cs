using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  YazdırmaKomutları
            //Console.Write("Merhaba Dünya");    //Console.Write komutu cmd'ye yazıyı yazdırır ve aynı satırda kalır.
            //Console.WriteLine("Hello World");  //Console.WriteLine komutu ise cmd'ye yazıyı yazdıktan sonra bir alt satıra geçer.
            //Console.Read();                    //Console.Read komutu ise cmd'nin hemen kapanmaması için kullanılan bir komut aslında Input komutudur fakat burada içerisine hiçbir şey yazılmadığı için etkisiz.
            #endregion
            #region String Degiskenler
            //Kod yazılırken değişkenlerin kullanım şekli (kalıp) şu şekildedir: değişken_türü değişken_adı;
            //string name;
            //name = "Enes";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerEmail;
            //string customerPhone, district, city;  //Bu kod satırında görüldüğü üzere bir satırda birden fazla değişken tanımlanabilir.

            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerEmail = "deneme@gmail.com";
            //customerPhone = "+90 532 555 44 33";
            //district = "Beşiktaş";
            //city = "İstanbul";


            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerEmail + " Telefon: " + customerPhone);    
            //Console.WriteLine("Adres: "+ district + "/" + city);





            #endregion
            #region Int Degiskenler
            //int sayısal tam sayı değişkenlerdir.
            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int lemonadePrice = 30;
            int pizzaPrice = 400;

            Console.WriteLine("**** Menü Fiyat Listesi ****");
            Console.WriteLine();
            Console.WriteLine("Hamburger: "+ hamburgerPrice+ " TL");
            Console.WriteLine("Kola: " + cokePrice + " TL");
            Console.WriteLine("Su: "+ waterPrice+ " TL");
            Console.WriteLine("Limonata: " + lemonadePrice + " TL");
            Console.WriteLine("Pizaa: " + pizzaPrice + " TL");
            #endregion

            Console.Read();
            

        }
    }
}
