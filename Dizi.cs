namespace Diziler;

public class Dizi
{
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


}
