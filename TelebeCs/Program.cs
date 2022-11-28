namespace TelebeCs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine();


            //  TelebeBilgi telebeBilgi = new TelebeBilgi(Console.ReadLine(),Console.ReadLine(),Convert.ToByte(Console.ReadLine()),false);   //True variant
            //  TelebeBilgi telebeBilgi1 = new TelebeBilgi(Console.ReadLine(),Console.ReadLine(),Convert.ToByte(Console.ReadLine()),true);  // False variant

            TelebeBilgi telebeBilgi3 = new TelebeBilgi("Mehemmed", "Ismayilov", 0, true);
            TelebeBilgi telebeBilgi4 = new TelebeBilgi("Hemid", "Cemilli", 90, false);

            GeriQaytar(telebeBilgi3.Name,telebeBilgi3.Surname,telebeBilgi3.GroupPoint,telebeBilgi3.Graduated);
            GeriQaytar(telebeBilgi4.Name,telebeBilgi4.Surname,telebeBilgi4.GroupPoint,telebeBilgi4.Graduated);

            
        }


        static int GeriQaytar (string nameM,string surnameM,byte groupPointM,bool graduatedM)
        {
            

           if (graduatedM==false)

            {
                if(groupPointM>=80)
                {
                    Console.WriteLine("Novbeti imtahana giris haqqi qazandiniz");
                }
                else
                {
                    Console.WriteLine("Novbeti imtahana giris haqqi qazanmadiniz");
                }
            }

           else
            {
                Console.WriteLine("Telebemiz Artiq Mezundur");
            }


           


          
            return 0;
        }
        
    }
}