Console.Write("Введите количество копеек: ");
var chislo = int.Parse(Console.ReadLine());


var rubli = chislo / 100;
var kopeiki = chislo % 100;
string outRuble = "";
string outKopeiki = "";
if (rubli == 0)
{ }
else if ((rubli == 1) || ((rubli % 10 == 1)&&(rubli / 10 != 1)))
{
   outRuble=" рубль ";
}
else if (((rubli > 1) && (rubli <= 4)) || ((rubli / 10 > 1) && (rubli / 10 < 5)))
{
    outRuble = " рубля ";
}
else
{
    outRuble = " рублей ";
}
if (kopeiki == 0)
{ }
if ((kopeiki == 1) || (kopeiki % 10 == 1))
{
    outKopeiki =" копейка ";
}
else if (((kopeiki > 1) && (kopeiki <= 4)) || ((kopeiki % 10 > 1) && (kopeiki % 10 < 5)))
{
    outKopeiki = " копейки ";
}
else
{
    outKopeiki = " копеек ";
}


Console.Write(rubli + outRuble + kopeiki + outKopeiki);