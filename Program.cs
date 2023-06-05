﻿void Shin(string frase, int fun)
{
    if (fun == 00)
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
    }
    else if (fun == 01)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
    }
        else if (fun == 02)
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
    }
for (int i = 00; i < frase.Length; i++)
{
Console.Write(frase[i]);
Thread.Sleep(40);
}
}
double calcular(double etan, double gaso)
{
    return etan/gaso;
}
double checker(double etanol, double gasolina)
{
    return calcular(etanol,gasolina);
}
Console.ForegroundColor = ConsoleColor.Cyan;
Shin("Qual é o preço do Etanol: ",04);
Console.ForegroundColor = ConsoleColor.White;
double eta = Convert.ToDouble(Console.ReadLine()!.Trim());
Console.ForegroundColor = ConsoleColor.DarkGreen;
Shin("Qual é o preço do Gasolina: ",04);
Console.ForegroundColor = ConsoleColor.White;
double gas = Convert.ToDouble(Console.ReadLine()!.Trim());
Shin($"\n\nA porcentagem de Etanol comparando a Gasolina é de {(checker(eta,gas)*100):N1}%\n\nUtilize ",01);
if (checker(eta,gas) >= 0.73)
{
    Shin("gasolina.",00);
}
else
{
    Shin("etanol.",00);
}
Console.ResetColor();