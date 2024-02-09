
using System.Runtime.InteropServices;
using Diziler;

internal class Program
{
    private static void Main(string[] args)
    {
        // Console.WriteLine("Birsayı Giriniz:");
        // int limit = Convert.ToInt32(Console.ReadLine());
        // int[] sayilar = new Dizi().Olustur(limit);


        // Console.WriteLine("\n Enbüyük: {0}", Dizi.EnBuyuk(sayilar) );
        // System.Console.WriteLine("\n Enküçük: {0}", Dizi.EnKucuk(sayilar) );

        System.Console.Write("Bir n değeri giriniz:");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] X = new Dizi().Olustur(n);
        
        System.Console.WriteLine("\nDizinin Aritmetik ortalaması: {0:F2}", Dizi.AritmetikOrtalama(X));
        System.Console.WriteLine("\nDizinin Standart sapması: {0:F2}", Dizi.StandartSapma(X));


        

    }
   
           
        
}