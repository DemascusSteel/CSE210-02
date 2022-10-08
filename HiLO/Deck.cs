// a class for a deck- 
//     att: num. of cards(52)
//     method: draw card, remove card from deck(list?)
using System;
public class Deck
{
//Incorporate the random object    
        Random rand = new Random();
        
        //create a new number to keep track of the previous number and set current num to zero
        public int num = 0;
        public int PrevDraw = 0;


        //previous num is printed and the new number is generated
        public void draw(){
            PrevDraw = num;
            num = rand.Next(1, 14);
        }

}

