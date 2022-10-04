using System;
namespace CSE21002.HiLo{


public class Director{
    //Director's attributes
        
       Boolean playInput = true;
        int score = 300;
        public string Guess = "";

    //start game loop
        public void Play(){
            
            //choice is condition and remains true until user types no
            // draw card
            // this while loop is the main loop and only stops when IsPlaying = False\

            while (getInputs())
            {
                //game loop
            }
                // print last card drawn named "PrevDraw"
                // ask for prediction 
                // Higher or lower  named "Guess"

                //call draw method

                // call UpdateScore method
               
                //print score
                
                // ask to continue playing "Answer"
                //if false print final score and call game over sequence
                }
        public bool getInputs(){
            //while player continue answer y or score > 0
            
    
            Console.Write("Would you like to enter another guess? Enter y or n");
            bool choice = true;
            bool playInput = true;
            while (choice){
               string play = Console.ReadLine();

                if (play = 'y' && ScoreValue > 0){
                    choice = false;
                    playInput = true;
                }
                else if (play = 'n' || ScoreValue = 0){
                    choice = false;
                    playInput = false;
                }
                else {
                    choice = true;
                    Console.WriteLine("Enter a valid input such as y or n");
                }
                return playInput;
            }
        }

        }

    }

