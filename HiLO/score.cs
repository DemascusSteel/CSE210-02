// Score class
// Score responsibility: keep track of the score value and check
//                       if the guess is correct

namespace CSE21002.HiLo{

    public class Score{
        // Score attributes: the value and guess status.
        public int ScoreValue = 300; // stores the value of score
        public bool IsCorrect = true; // variable to determine if the user guess is correct
        
        public void IsGuessCorrect(int PrevDraw, int Draw, string Guess){
            // this method checks the relationship of the cards and if the guess of
            // "h" or "l" is correct. 
            bool higher = false; // statement of the card relationship

            if (PrevDraw < Draw){
                higher =  true; // true = higher, false = lower
            }
            else {
                higher = false;
            }  

            if (Guess == "h" && higher == true || Guess == "l" && higher == false )
            { // if the guess is the same as the card relationship, then the guess is correct
                IsCorrect = true;
            }
            else
            {// if not, the guess is false 
                IsCorrect = false;
            }            
        }
        public void UpdateScore(){
            // depending on the state of IsCorrect, this method will add or subtract from the score value
            if (IsCorrect == true){
                ScoreValue += 100;
            }
            else{
                ScoreValue -= 75;
            }
                
        }
        
    }
}

