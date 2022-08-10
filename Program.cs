// Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
System.Console.WriteLine("Pozitif Bir sayı giriniz:");
int sayi=int.Parse(Console.ReadLine());
System.Console.WriteLine(sayi);
int sayiuzunluk=sayi;
int[] sayilar=new int[sayiuzunluk];

    for (int i = 0; i < sayiuzunluk; i++)
    {
    System.Console.WriteLine("{0}. sayıyı giriniz:",i+1);  
    sayilar[i]=int.Parse(Console.ReadLine());
    }

    foreach (var item in sayilar)
    {
    if (item%2==0)
        Console.WriteLine(item);   
    }
// Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

System.Console.WriteLine(" Bir sayı giriniz:");
int n=int.Parse(Console.ReadLine());
System.Console.WriteLine(" Bir sayı giriniz:");
int m=int.Parse(Console.ReadLine());
int[] diziler=new int[n];

    for (int i = 0; i < n; i++)
    {
        System.Console.WriteLine("{0}. sayıyı giriniz:",i+1);  
        diziler[i]=int.Parse(Console.ReadLine());
    }

     foreach (var deger in diziler)
     {
        if(deger==m || deger%m==0)
            Console.WriteLine(deger);
     }

// Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

System.Console.WriteLine(" Bir sayı giriniz:");
int sayilar2=int.Parse(Console.ReadLine());
string[] kelimeler=new string[sayilar2];

    for (int i = 0; i < sayilar2; i++)
    {
        System.Console.WriteLine("{0}. kelimeyi giriniz:",i+1);  
        kelimeler[i]=Console.ReadLine();
    }
    kelimeler.Reverse();
    foreach (var kelime in kelimeler)
    {
        Console.WriteLine(kelime);
    }

 // Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
    Console.WriteLine("Cümle Yazınız:");
      string cumle = Console.ReadLine();
      var kelimeadı = cumle.Split(' ');
      int kelimeSayisi = 0;
      int harfSayisi = 0;
      string harfler = "ABCÇDEFGĞHİIJKLMNOÖPRSŞTUÜVYZabcçdefgğhiıjklmnoöprsştuüvyz";
      for (int i = 0; i < cumle.Length; i++)
      {
        //karakter katarkter kontrol ediyoruz.
        if (harfler.Contains(cumle[i]))
        {
          harfSayisi++;
        }
      }
        foreach (var item in kelimeadı)
      {
        kelimeSayisi++;
      }

      Console.WriteLine("Girdiğiniz Cümlede {0} Adet Kelime, {1} Adet Harf Bulunmaktadır.", kelimeSayisi,harfSayisi);
      Console.ReadKey();