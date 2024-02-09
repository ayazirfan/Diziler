
namespace Diziler;
public class Dizi2:Dizi
{
    /// <summary>
    /// Bu dizideki tek sayıların sayısını döner.
    /// </summary>
    /// <param name="X">X</param>
    /// <returns>Sonuc: Tek sayıları sayısı</returns>
    public int TekSayilarinSayisi(int[] X)
    {
        int tekSayilarinSayisi = 0;
        for (int i = 0; i < X.Length; i++)
        {
            if (X[i]%2==1)
            {
                tekSayilarinSayisi++;                
            }
                       
        } return tekSayilarinSayisi;
    }
    /// <summary>
    /// Bu dizideki çift sayıların sayısını döner.
    /// </summary>
    /// <param name="X">X</param>
    /// <returns>Sonuc: çift sayıları sayısı</returns>
    public int CiftSayilarinSayisi(int[] X)
    {
        int ciftSayilarinSayisi = 0;
        for (int i = 0; i < X.Length; i++)
        {
            if (X[i]%2==0)
            {
                ciftSayilarinSayisi++;                
            }
                       
        } return ciftSayilarinSayisi;
        
    }
/// <summary>
/// Bu dizideki tek sayılardan yeni bir dizi oluşturur
/// </summary>
/// <param name="X">Dizi</param>
/// <returns>Tek sayılardan oluşan diziyi temsil eder</returns>
    public int[] TekDiziOlustur (int[] X)
    {
        int [] tekDizi = new int[TekSayilarinSayisi(X)];
        int y =0;
        for (int i = 0; i < X.Length; i++)
        {
            if (X[i]%2==1)
            {
                tekDizi[y] = X[i];
                y++;
            }
            
        }return tekDizi;
    }

    /// <summary>
/// Bu dizideki çift sayılardan yeni bir dizi oluşturur
/// </summary>
/// <param name="X">Dizi</param>
/// <returns>Çift sayılardan oluşan diziyi temsil eder</returns>
    public int[] CiftDiziOlustur (int[] X)
    {
        int [] ciftDizi = new int[CiftSayilarinSayisi(X)];
        int y =0;
        for (int i = 0; i < X.Length; i++)
        {
            if (X[i]%2==0)
            {
                ciftDizi[y] = X[i];
                y++;
            }
            
        }return ciftDizi;
    }
/// <summary>
/// Parametre olarak diziyi ekrana yazdırır. 
/// </summary>
/// <param name="X"></param>
    public static void Yazdir(int[] X)
    {
        System.Console.WriteLine("");
        for (int i = 0; i <X.Length; i++)
        {
            System.Console.WriteLine("{0,3}", X[i]);
            System.Console.WriteLine("");
            
        }
    }

    


}
