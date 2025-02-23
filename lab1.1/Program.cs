Console.Write("Введите количество копеек: ");
var chislo = int.Parse(Console.ReadLine());
var rubli = chislo / 100;
var kopeiki = chislo % 100;

if (rubli == 0)
{ }
else if ((rubli == 1) || ((rubli % 10 == 1)&&(rubli / 10 != 1)))
{
    Console.Write(rubli + " рубль ");
}
else if (((rubli > 1) && (rubli <= 4)) || ((rubli / 10 > 1) && (rubli / 10 < 5)))
{
    Console.Write(rubli + " рубля ");
}
else
{
    Console.Write(rubli + " рублей ");
}

if (kopeiki == 0)
{ }
if ((kopeiki == 1) || (kopeiki % 10 == 1))
{
    Console.Write(kopeiki + " копейка ");
}
else if (((kopeiki > 1) && (kopeiki <= 4)) || ((kopeiki % 10 > 1) && (kopeiki % 10 < 5)))
{
    Console.Write(kopeiki + " копейки ");
}
else
{
    Console.Write(kopeiki + " копеек ");
}