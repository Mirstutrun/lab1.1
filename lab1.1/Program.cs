
namespace FirstApp
{
    public class Logic
    {

        public static string CountMoney(int chislo)
        {
            var rubli = chislo / 100;
            var kopeiki = chislo % 100;
            string outRuble = "";
            string outKopeiki = "";
            string outMessage = "";
            if (rubli == 0)
            { }
            else if ((rubli == 1) || ((rubli % 10 == 1) && (rubli / 10 != 1)))
            {
                outRuble = rubli + " рубль ";
            }
            else if (((rubli > 1) && (rubli <= 4)) || ((rubli % 10 > 1) && (rubli % 10 < 5)) && !((rubli >= 12) && (rubli <= 14)))
            {
                outRuble = rubli + " рубля ";
            }
            else
            {
                outRuble = rubli + " рублей ";
            }
            outMessage += outRuble;
            if (kopeiki == 0)
            { return outMessage;
            }
            if ((kopeiki == 1) || ((kopeiki % 10 == 1) && (kopeiki / 10 != 1)))
            {
                outKopeiki = kopeiki + " копейка ";
            }
            else if (((kopeiki > 1) && (kopeiki <= 4)) || ((kopeiki % 10 > 1) && (kopeiki % 10 < 5))&& !((kopeiki>=12)&&(kopeiki<=14)))
            {
                outKopeiki = kopeiki + " копейки ";
            }
            else
            {
                outKopeiki = kopeiki + " копеек ";
            }
            outMessage += outKopeiki;
            return outMessage;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

         Console.Write("Введите количество копеек: ");
         var chislo = int.Parse(Console.ReadLine());
         var outMessage = Logic.CountMoney(chislo);
            Console.WriteLine(outMessage);
        }
    }
}

          





