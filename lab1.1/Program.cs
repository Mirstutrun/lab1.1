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

