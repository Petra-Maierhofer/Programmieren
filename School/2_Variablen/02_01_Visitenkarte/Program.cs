/*--------------------------------------------------------------
 *			Visitenkarte
 *--------------------------------------------------------------
*/

using System;

string name;
string livingPlace;

Console.Write("What is your name: ");
name = Console.ReadLine();

Console.Write("What is your living place: ");
livingPlace = Console.ReadLine();

Console.WriteLine("*****************************");
Console.WriteLine($"* {name, -25} *");
Console.WriteLine("*****************************");
Console.WriteLine($"* {livingPlace,-25} *");
Console.WriteLine("*****************************");

