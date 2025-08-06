using System;

namespace GoOrQuitTest{
    class Program{
        public static void Main(){
            bool readInput = true;

            while (readInput){ //iterate while readInput is true
                showMenu();
                string option = Console.ReadLine(); // get the user input

                if (option == "2") //enter block when quit option is selected
                    break; //exit from loop

                else {
                    Console.WriteLine("You have choosen to keep playing.");
                    Console.WriteLine("");
                }
            }
            Console.WriteLine(" The game has been terminated.");
            Console.ReadLine();
        }
        public static void showMenu(){ //show the user option
            Console.WriteLine("** Options **");
            Console.WriteLine("1. Keep Playing the Game. ");
            Console.WriteLine("2. Quit ");  
        }
    }
}