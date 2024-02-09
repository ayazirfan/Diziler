namespace Diziler;

public class Dizi
{
    /// <summary>
    /// tek boyutlu dizi oluşturmak için kullanılan fonksiyondur
    /// </summary>
    /// <param name="limit">Dizinin uaunluğunu belirtir</param>
    /// <returns>Belirtilen uzunlukta rasgele sayılrdan oluşmuş diziyi döner</returns>
    public int[] Olustur(int limit)
    {
    int[] sayilar = new int[limit];
        for (int i = 0; i < limit; i++)
        {
            sayilar[i] = new Random().Next(1, 100);
            Console.Write("{0,5}", sayilar[i]);
        }
        return sayilar;
    }    
        /// <summary>
        /// Parametre olarak aldığı dizideki en büyük elemanı döner
        /// </summary>
        /// <param name="dizi">Dizi</param>
        /// <returns></returns>
    

     public static int EnBuyuk(int[] dizi)

        {
            int eb = dizi[0];
            for (int i = 1; i < dizi.Length; i++)
            {
                if (dizi[i]>eb)
                {
                    eb = dizi[i];
                }
            }
            return eb;
        }
        /// <summary>
        /// Parametre olarak aldığı dizideki en küçük elemanı döner
        /// </summary>
        /// <param name="dizi">Dizi</param>
        /// <returns></returns>
        public static int EnKucuk(int[] dizi)
        {
            int ek = dizi[0];
            for (int i = 1; i < dizi.Length; i++)
            {
                if (dizi[i]<ek)
                {
                    ek = dizi[i];
                }
            }return ek;
        } 
        /// <summary>
        /// Parametre olarak aldığı dizinin aritmetik ortalamasını hesaplar ve döner
        /// </summary>
        /// <param name="X">Dizi</param>
        /// <returns>Aritmetik ortalama</returns>
        public static double AritmetikOrtalama (int[] X)
        {
            double toplam = 0;
            for (int i = 0; i <X.Length; i++)
            {
                toplam+=X[i];                
            }return toplam/X.Length;            
        }



}
