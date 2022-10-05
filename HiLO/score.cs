

// class for a score
//     att: ScoreValue=300
//     method: HiLo, UpdateScore, DisplayScore
namespace CSE21002.HiLo{
    Director director = new Director();
    public class Score{
        public int ScoreValue = 300;
        
        public bool HiorLO(){

            bool higher = false;

            if (PrevDraw > Draw){
                higher =  true; // true = high, false = low
            }
            else {
                higher = false;
            }  

            if (director.Guess == "h" && higher == true || director.Guess == "l" && higher == false )
            {
                bool correct = true;
            }
            else
            {
                correct = false;
            }            
        }
        public void UpdateScore(){
            if (correct = true){
                ScoreValue += 100;
            }
            else{
                ScoreValue -= 75;
            }
            
            Console.WriteLine($"Your new score is {ScoreValue}")
                
        }
        
    }
}

