﻿// See https://aka.ms/new-console-template for more information
using blackjack;
using Microsoft.VisualBasic;
using System;
using System.ComponentModel.Design;
/*
var cardProperties = new List<cardProperties> {
new cardProperties() { power=1, name="1"},
new cardProperties() { power=2, name="2"}
};
*/
CardProperties One= new CardProperties();
One.Name = "1";
One.Power = 1;
CardProperties Two= new CardProperties();
Two.Name = "2";
Two.Power = 2;
CardProperties Three= new CardProperties();
Three.Name = "3";
Three.Power = 3;
CardProperties Four= new CardProperties();
Four.Name = "4";
Four.Power = 4;
CardProperties Five= new CardProperties();
Five.Name = "5";
Five.Power = 5;
CardProperties Six= new CardProperties();
Six.Name = "6";
Six.Power = 6;
CardProperties Seven= new CardProperties();
Seven.Name = "7";
Seven.Power = 7;
CardProperties Eight= new CardProperties();
Eight.Name = "8";
Eight.Power = 8;
CardProperties Nine= new CardProperties();
Nine.Name = "9";
Nine.Power = 9;
CardProperties Ten= new CardProperties();
Ten.Name = "10";
Ten.Power = 10;
CardProperties Jack= new CardProperties();
Jack.Name = "Jack";
Jack.Power = 10;
CardProperties  Queen= new CardProperties();
Queen.Name = "Queen";
Queen.Power = 10;
CardProperties King = new CardProperties();
Queen.Name = "King";
Queen.Power = 10;
int tokens = 50;
Console.WriteLine($"You currently have {tokens} tokens");
Random rndDealer = new Random();
var Dealer = rndDealer.Next(12, 22);

Console.WriteLine("For how many tokens do you wish to play?");
int tokensChoice = Int32.Parse(Console.ReadLine());
Console.WriteLine($"Dealer has {Dealer}");

string[] name = new string[13];
name[12] = "Ace";
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
//List<cards> ListofCards = new List<cards>();
Random rnd = new Random();
int totalValue = 0;
int SumofValues = (totalValue);

while (true)
    {
        Tokens:
        if (tokensChoice > tokens) { Console.WriteLine("You cannot afford that."); Console.WriteLine("For how many tokens do you wish to play?"); tokensChoice = Int32.Parse(Console.ReadLine()); ; goto Tokens; }
        if (Dealer > 21) { Console.Write(" Dealer has busted, you won."); tokens += tokensChoice; Console.WriteLine($"You currently have {tokens} tokens"); Console.WriteLine("For how many tokens do you wish to play?"); tokensChoice = Int32.Parse(Console.ReadLine()); totalValue = 0; Dealer = rndDealer.Next(12, 22); Console.WriteLine($"Dealer has {Dealer}"); }
        var Card = name[rnd.Next(0, 13)];
        if (Card == name[0]) { totalValue += 2; }
        else if (Card == name[1]) { totalValue += 3; }
        else if (Card == name[2]) { totalValue += 4; }
        else if (Card == name[3]) { totalValue += 5; }
        else if (Card == name[4]) { totalValue += 6; }
        else if (Card == name[5]) { totalValue += 7; }
        else if (Card == name[6]) { totalValue += 8; }
        else if (Card == name[7]) { totalValue += 9; }
        else if (Card == name[8]) { totalValue += 10; }
        else if (Card == name[9]) { totalValue += 10; }
        else if (Card == name[10]) { totalValue += 10; }
        else if (Card == name[11]) { totalValue += 10; }
        else if (Card == name[12]) { if (SumofValues > 10) { totalValue += 1; } else { totalValue += 11; } }
    Console.WriteLine("Your card is: " + Card);
        SumofValues = (totalValue);
        Console.WriteLine(" Sum of yours cards values is: " + SumofValues);
        if (SumofValues > 21) { Console.WriteLine("It is a bust"); tokens -= tokensChoice; Console.WriteLine($"You currently have {tokens} tokens"); Console.WriteLine("For how many tokens do you wish to play?"); tokensChoice = Int32.Parse(Console.ReadLine()); totalValue = 0; Dealer = rndDealer.Next(12, 22); Console.WriteLine($"Dealer has {Dealer}"); }
        Console.WriteLine("do you want to hit(1) or stand(2)?");
        int choice = Int32.Parse(Console.ReadLine());
        if (choice == 2)
        {
            if (SumofValues > Dealer) { Console.WriteLine("You won!"); tokens += tokensChoice; Console.WriteLine($"You currently have {tokens} tokens"); Console.WriteLine("For how many tokens do you wish to play?"); tokensChoice = Int32.Parse(Console.ReadLine()); totalValue = 0; Dealer = rndDealer.Next(12, 22); Console.WriteLine($"Dealer has {Dealer}"); }
            else if (SumofValues < Dealer) { Console.WriteLine("You lost!"); tokens -= tokensChoice; Console.WriteLine($"You currently have {tokens} tokens"); Console.WriteLine("For how many tokens do you wish to play?");  tokensChoice = Int32.Parse(Console.ReadLine()); totalValue = 0; Dealer = rndDealer.Next(12, 22); Console.WriteLine($"Dealer has {Dealer}"); }
            else if (SumofValues == Dealer) { Console.WriteLine("It is a push, no one won,"); Console.WriteLine($"You currently have {tokens} tokens"); Console.WriteLine("For how many tokens do you wish to play?"); tokensChoice = Int32.Parse(Console.ReadLine()); totalValue = 0; Dealer = rndDealer.Next(12, 22); Console.WriteLine($"Dealer has {Dealer}"); }


        }
    

    }


/*
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
else if (secondCard == name[10]) { totalValue += 10; }
else if (secondCard == name[11]) { totalValue += 10; }

Console.WriteLine(secondCard);

int SumofValues = (totalValue);
Console.WriteLine(SumofValues + " value");
Console.WriteLine("do you want to hit(1) or stand(2)?");
int choice = int.Parse(Console.ReadLine());

*/