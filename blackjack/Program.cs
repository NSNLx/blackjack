// See https://aka.ms/new-console-template for more information
using blackjack;
using Microsoft.VisualBasic;
using System;
/*
var cardProperties = new List<cardProperties> {
new cardProperties() { power=1, name="1"},
new cardProperties() { power=2, name="2"}
};
*/
string[] name = new string[3];
name[0] = "King";
name[1] = "Queen";
name[2] = "Jack";
Random rnd = new Random();
Console.WriteLine(name[rnd.Next(0, 2)]);
var result = Console.ReadLine(name[rnd.Next(0, 2)]);
