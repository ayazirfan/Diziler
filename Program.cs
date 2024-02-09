
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Birsayı Giriniz:");
        int limit = Convert.ToInt32(Console.ReadLine());
        int[] sayilar = new int[limit];
        for (int i = 0; i < limit; i++)
        {
            sayilar[i] = new Random().Next(1, 100);
            Console.WriteLine("{0,5}", sayilar[i]);
        }
        System.Console.WriteLine("\n Enbüyük: {0}", EnBuyuk(sayilar) );
        System.Console.WriteLine("\n Enküçük: {0}", EnKucuk(sayilar) );

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