
Console.WriteLine("idag sker fighten som avser vemm av vera och calle som kommer styra universum.");
int heroHp = 100;
int villainHp = 100;

string heroName = "vera";
string villainName = "calle";

Random generator = new Random();

while (heroHp > 0 && villainHp > 0)
{
  Console.WriteLine("lessgo");
  Console.WriteLine($"{heroName}: {heroHp}  {villainName}: {villainHp}\n");

  int heroDamage = generator.Next(20);
  villainHp -= heroDamage;
  villainHp = Math.Max(0, villainHp);
  Console.WriteLine($"{heroName} gör {heroDamage} emotional damage på {villainName}");

  int villainDamage = generator.Next(20);
  heroHp -= villainDamage;
  heroHp = Math.Max(0, heroHp);
  Console.WriteLine($"{villainName} gör {villainDamage} emotional damage på {heroName}");

  Console.WriteLine("klicka K för att ta reda på vem som vinner och kan styra världen");
  Console.ReadKey();
}

Console.WriteLine("boss fight complete");

if (heroHp == 0 && villainHp == 0)
{
  Console.WriteLine("ingen a de tå massiva krafterna vann, de såg isär sina likheter och lever lyckliga i alla sina dar");
}
else if (heroHp == 0)
{
  Console.WriteLine($"{villainName} har nu tagit över världen, ryktet säger att genuset i teknikbranchen aldrig kommer vara densamma.");
}
else
{
  Console.WriteLine($"{heroName} vann, mer erebos till folket");
}

Console.WriteLine("Tryck på valfri knapp för att avsluta.");
Console.ReadKey();
Console.ReadLine();
