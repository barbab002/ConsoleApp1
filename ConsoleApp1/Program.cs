// See https://aka.ms/new-console-template for more information
float licznik;
float Dzieler;
float Months;
float Years;
float YearInMonths;
float Wynik;


Console.Clear();
Console.WriteLine("Dagmara to dla Ciebie :> \n Oliczanie ułamków z lat \n\nWprowadz liczbe lat");
Years = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Podaj liczb miesiecy");
Months = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Podaj gorna czesc ulamka");
licznik = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Podaj dzielnik");
Dzieler = Convert.ToInt32(Console.ReadLine());



YearInMonths = (12 * Years) + Months;
float Dzielnik = (licznik / Dzieler);


Console.WriteLine("lata \n" + YearInMonths);
Console.WriteLine("Dzielnik\n" + Dzielnik);

Wynik = ((YearInMonths * Dzielnik) / 12);


Console.WriteLine(" \nWynik to: " + Wynik + "Lat");

Console.ReadKey();