using CSE21002.HiLo;

namespace CSE21002
{

    /// <summary>
    /// The program's entry point.
    /// <summary>
    class Program{

        /// <param name="args">The given arguments.</param>
        static void Main(string[] args)
        {
            Director director = new Director();
            director.Play();
        }
    }

// See https://aka.ms/new-console-template for more information

//Game Specs:
// The program must include a README file.
// The program must include class and method comments.
// The program must have at least two classes.
// The program must remain true to game play described in the overview.

/////// game loop
// Input: user guess
// Update: check numbers, calculate new score
// Render: show new score

// a class for a deck- 
//     att: num. of cards(52)
//     method: draw_card, remove_card from deck(list?)
// class for a score
//     att: scoreValue=300
//     method: add100, take75, displayScore
// //class for a player(maybe not this)
// //    resp. : chooses to play a game, has an original score of 300
//      
// director file has instances-- if score == 0, if the player stops, 
//         wrong or right guess.
}
