using System;

namespace ders2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1.soru
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Hello world");
            //}
            #endregion

            #region 2.soru
            //int sayi;
            //Console.WriteLine("sayı giriniz");
            //sayi = Convert.ToInt32(Console.ReadLine());
            //for (int i = 2; i < sayi; i+=2)
            //{
            //    Console.WriteLine(i);


            //}
            #endregion

            #region 3.Soru

            //Console.Write("Bir sayi giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int rakam;
            //Console.Write("Sayinin tersten yazılısı = ");
            //while (sayi > 0)
            //{
            //    rakam = sayi % 10;
            //    Console.Write(rakam);
            //    sayi /= 10;
            //}
            //Console.ReadLine();
            #endregion

            #region 4)Verilen tamsayının sıfır, pozitif ya da negatif olup olmadığını bulan program.

            //int sayi;
            //Console.WriteLine("sayi:");
            //sayi = Convert.ToInt32(Console.ReadLine());

            //if (sayi<0)
            //{
            //    Console.WriteLine("negatif");
            //}
            //if (sayi==0)
            //{
            //    Console.WriteLine("sıfır");
            //}
            //if(sayi>0)
            //{
            //    Console.WriteLine("pozitif");
            //}
            #endregion

            #region 5.Soru) Girilen fiyatın KDV li halini ( % 18 ) ekrana yazdır
            //double satis, fiyat,toplam;
            //Console.Write("Ürün Fiyatını Giriniz");
            //fiyat = Convert.ToInt32(Console.ReadLine());

            //satis = fiyat * 0.18;
            //toplam = fiyat + satis;
            //Console.WriteLine("ürünün kdvli hali:"+toplam);
            #endregion

            #region 6) Vize  Final
            //Console.Write("vize:");
            //int vize = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Final:");
            //int Final = Convert.ToInt32(Console.ReadLine());

            //int hesap = (((vize * 30) / 100) + ((Final * 70) / 100));
            //Console.WriteLine("ortlama:"+hesap);
            #endregion

            #region 7)Kullanıcıdan alınan sayının tek ya da çift olduğunu kontrol edip ekranda yazdırın
            //Console.Write("sayi:");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //if (sayi%2==0)
            //{
            //    Console.WriteLine( "çift");
            //}
            //else Console.WriteLine("tek");
            #endregion

            #region 8)Bir kenar uzunluğu ve o kenara ait yüksekliği girilen üçgenin alanını hesaplayın.
            //Console.Write("taban:");
            //int taban = Convert.ToInt32(Console.ReadLine());
            //Console.Write("yükseklik");
            //int yukseklik = Convert.ToInt32(Console.ReadLine());
            //int alan = taban * (yukseklik / 2);
            //Console.WriteLine(alan);
            #endregion

            #region 9)Girilen bir x sayısının yine girilen bir y sayısına tam bölünüp bölünmediğini ekrana yazdırın.
            //Console.Write("x:");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.Write("y:");
            //int y = Convert.ToInt32(Console.ReadLine());

            //if( x%y==0)
            //    Console.WriteLine("TAM BÖLÜNÜYOR");
            //else
            //    Console.WriteLine("TAM BÖLÜNMÜYOR");

            #endregion

            #region 10)Çarpma operatörü kullanmadan klavyeden girilen sayının 5 katını bulun.
            //Console.WriteLine("sayi:");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int sonuc = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    sonuc = sonuc + sayi;
            //}
            //Console.WriteLine(sonuc);

            #endregion


            #region 11)Klavyeden girilen sayının kaç basamaklı olduğunu bulun.

            //Console.Write("Bir sayi giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int sayac = 0;
            //while (sayi > 0)
            //{
            //    sayi /= 10;
            //    sayac++;
            //}
            //Console.WriteLine("Girdiginiz sayi " + sayac + " basamaklıdır.");

            //Console.ReadLine();
            #endregion

            #region 12) Dışarıdan girilen N sayısına kadar olan asal sayıları bulan program
            //Console.Write("sayi:");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < sayi; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //    }
            //    else
            //        Console.WriteLine("asal sayi:" + i);

            #endregion
            #region  13) N elemanlı bir dizideki en küçük elemanı ve bu elemanın adresini (index no) bulan program
            //int[] sayilar = new int[100];
            //Random rnd = new Random();
            //int min, mak;

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    sayilar[i] = rnd.Next(1, 100);
            //    Console.WriteLine(sayilar[i]);
            //}
            //min = sayilar[0];
            //mak = sayilar[0];
            //for (int i = 1; i < sayilar.Length; i++)
            //{
            //    if (min > sayilar[i])
            //        min = sayilar[i];
            //    if (mak < sayilar[i])
            //        mak = sayilar[i];
            //}
            //Console.WriteLine("Dizi içindeki en büyük sayı:>>" + mak);
            //Console.WriteLine("Dizi içindeki en küçük sayı:>>" + min);
            //Console.ReadKey();
            #endregion
            #region N elemanlı bir diziyi yedek dizi KULLANMADAN tersine çeviren program.

            //int[] dizi = { 1, 5, 6, 9, 88, 77, 555, 222 };
            //for (int i = dizi.Length-1 ; i >=   0 ; i--)
            //{

            //    Console.WriteLine(dizi[i]);
            //}


            #endregion
            #region 14)Dışarıdan girilen bir cümledeki kelime sayısını bulan program.
            //Console.WriteLine("herhabgi bir cümle yaz:");
            //string cumle = Convert.ToString(Console.ReadLine());

            //string[] kelime = cumle.Split(' ');
            //Console.WriteLine("kelime sayısı:"+kelime.Length);
            #endregion
            #region 15)(yapamadım)Dışarıdan girilen en az 5 basamaklı sayının ilk ve son basamakları arasındaki sayıların toplamını bulan program.
            //Console.Write("Bir sayi giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int sayac = 0;
            //int   son_basamak, ilk_basamak;
            //while (sayi > 0)
            //{
            //    sayi /= 10;
            //    sayac++;
            //}
            //if (sayac < 5)
            //{
            //    Console.WriteLine("lütfen 5 basamaklı sayı giriniz");
            //}





            //Console.ReadLine();
            #endregion
            #region 16) Dışarıdan girilen sayının faktöriyelini hesapla
            //Console.WriteLine("sayı:");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //double  faktoriyel = 1;
            //for (int i = 1; i <= sayi; i++)
            //{
            //    faktoriyel = faktoriyel * i;
            //}

            //Console.WriteLine("{0} sayısının faktöriyeli={1}", sayi, faktoriyel);
            //Console.ReadKey();
            #endregion

            #region 17.soru (istediğim gibi olmadı)
            //int sayac = 0, sayi = 16;
            //for (int i = 1; i < sayi; i++)
            //{
            //    //Console.WriteLine(i+"\t");

            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write(i + j);

            //    }
            //    Console.WriteLine();

            //}
            //Console.Read();
            #endregion

            #region 18) Aşağıdaki formu ekrana yazdıran program. (yapamadım)
            //2 3 4 5 6

            //3 5 7 9 11

            //4 7 10 13 16

            //5 9 13 17 21

            //6 11 16 21 26


            #endregion
        }




    }
}

