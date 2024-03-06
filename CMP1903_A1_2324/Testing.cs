using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        public static void TestDie()
        {
            Die die = new Die(); // creating a die object for the testing
            int initialDieValue = die.CurrentValue; // retrieves the initial value of the die
            Debug.WriteLine($"Initial value of die: {initialDieValue}"); // displays the inital die value
            int rollResult = die.Roll(); // rolls the die
            int afterRollDieValue = die.CurrentValue; // gets the new value of the die
            Debug.WriteLine($"After rolling, die value: {afterRollDieValue}"); // outputs the value after rolling
            Debug.WriteLine($"Roll result: {rollResult}"); // output result of the roll

            // Test if die value changed after roll
            Debug.Assert(initialDieValue != afterRollDieValue, "Die value did not change after roll.");
        }

        public static void TestGame()
        {
            Game game = new Game(); // Create a Game object for testing
            game.Play();

        }
    }
}
