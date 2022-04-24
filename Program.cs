using System;

namespace Hata_yönetimi
{
    class Program
{
        static void Main(string[] args){ 
        try 
        {
             Console.WriteLine("Bi sayı giriniz");
            int sayi=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girmiş olduğunu sayı " +sayi);

            
        }
        catch(Exception ex)
        {
            Console.WriteLine("Hata: " + ex.Message.ToString());
        }
        finally
        {
            Console.WriteLine("İşlem tammalandı.");
        } 

        try
        {
           int a=int.Parse(null);
            int b= int.Parse("-20000000000");
        }
        catch (ArgumentException ex)
        {    
            Console.WriteLine("Boş değer girdiniz");
            Console.WriteLine(ex);
         
        }
        catch(OverflowException br)
         {
             Console.WriteLine("Çok küçük yada büyük bir sayı girdiniz.");
             Console.WriteLine(br);
        }
     }

    }
}
