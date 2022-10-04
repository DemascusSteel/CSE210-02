// a class for a deck- 
//     att: num. of cards(52)
//     method: draw card, remove card from deck(list?)
using System;
public class Deck
{
        Random rand = new Random();
        
    
        public int num = 0;
        public int PrevDraw = 0;

        public Card(){}


        public void draw(){
            PrevDraw = num;
            num = rand.Next(1, 14);
        }


}

//nevermind this now :) //Something to pop items from the list

