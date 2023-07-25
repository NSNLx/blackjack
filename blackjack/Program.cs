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




string[] name = new string[12];
name[11] = "King";
name[10] = "Queen";
name[9] = "Jack";
name[8] = "10";
name[7] = "9";
name[6] = "8";
name[5] = "7";
name[4] = "6";
name[3] = "5";
name[2] = "4";
name[1] = "3";
name[0] = "2";
;
List<cards> ListofCards = new List<cards>();
int totalValue = 0;
Random rnd = new Random();
var firstCard = name[rnd.Next(0, 11)];
if (firstCard == name[0])
{
    totalValue += 2;
}
else if (firstCard == name[0])
{
    totalValue += 3;
}
else if (firstCard == name[2]) {     totalValue += 4; }
else if (firstCard == name[3]) {     totalValue += 5; }
else if (firstCard == name[4]) {     totalValue += 6; }
else if (firstCard == name[5]) {     totalValue += 7; }
else if (firstCard == name[6]) {     totalValue += 8; }
else if (firstCard == name[7]) {     totalValue += 9; }
else if (firstCard == name[8]) {     totalValue += 10; }
else if (firstCard == name[9]) {     totalValue += 10; }
else if (firstCard == name[10]){     totalValue += 10; }
else if (firstCard == name[11]) {    totalValue += 10;  }

Console.WriteLine(firstCard);
var secondCard = name[rnd.Next(0, 11)];

if (secondCard == name[0]) { totalValue += 2; }
else if (secondCard == name[1]) { totalValue += 3; }
else if (secondCard == name[2]) { totalValue += 4; }
else if (secondCard == name[3]) { totalValue += 5; }
else if (secondCard == name[4]) { totalValue += 6; }
else if (secondCard == name[5]) { totalValue += 7; }
else if (secondCard == name[6]) { totalValue += 8; }
else if (secondCard == name[7]) { totalValue += 9; }
else if (secondCard == name[8]) { totalValue += 10; }
else if (secondCard == name[9]) { totalValue += 10; }
else if (secondCard == name[10]){ totalValue += 10; }
else if (secondCard == name[11]){ totalValue += 10; }

Console.WriteLine(secondCard);

int SumofValues = (totalValue);
Console.WriteLine(SumofValues + " value");
Console.WriteLine("do you want to hit(1) or stand(2)?");
int choice = int.Parse(Console.ReadLine());

if (choice == 1)
{
    var thirdCard = name[rnd.Next(0, 11)];
    Console.WriteLine(thirdCard);
}

