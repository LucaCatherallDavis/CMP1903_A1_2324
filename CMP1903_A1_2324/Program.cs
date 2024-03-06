using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using CMP1903_A1_2324;
/*
 * Create a Game object and call its methods.
 * Create a Testing object to verify the output and operation of the other classes.
 */

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(); // Create a Game object

            game.Play(); // calling the play method to roll the dice and interact with the user
        }
    }
}

    class Program
{
    static void Main(string[] args)
    {
        Testing testing = new Testing();

        // output messages indicated the testing of the code as it runs
        Debug.WriteLine("Testing Die:");
        Testing.TestDie();

        Debug.WriteLine("\nTesting Game:");
        Testing.TestGame();

        Debug.WriteLine("\nTesting complete.");

        Console.ReadLine(); // To prevent console from closing immediately
    }
}

