using System;

namespace KAMP.INTRO
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği

            string kategoriEtiketi = "Kategori";
            int ogrenciSayısı = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
                
            }
            

            if(sistemeGirisYapmisMi == true )
            {
                Console.WriteLine("Kullanıcı Ayar Butonu");                  
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }



            Console.WriteLine(kategoriEtiketi);

            




        }
    }
}
