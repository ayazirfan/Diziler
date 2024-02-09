
using System.Runtime.InteropServices;
using Diziler;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Birsayı Giriniz:");
        int limit = Convert.ToInt32(Console.ReadLine());
        int[] sayilar = new Dizi().Olustur(limit);

         System.Console.WriteLine(sayilar.Reverse());

        
        

        Console.WriteLine("\n Enbüyük: {0}", Dizi.EnBuyuk(sayilar) );
        System.Console.WriteLine("\n Enküçük: {0}", Dizi.EnKucuk(sayilar) );

    }
   
           
        
}