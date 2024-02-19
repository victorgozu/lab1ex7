/*
 Ex 7
Se citesc doua numere de la tastatura, x si y. Scrieti un program care va verifica
daca x este divizibil cu y.
 In cazul in care x este divizibil cu y, programul va afisa “divizibil” iar in caz contrar,
“indivizibil”.
*/

Console.WriteLine("Introduceti numarul intreg x:");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Introduceti numarul intreg y:");
int y = int.Parse(Console.ReadLine());


if (x % y == 0)
{
    Console.WriteLine("divizil");
}
else
{
    Console.WriteLine("indivizil");
}
