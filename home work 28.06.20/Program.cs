using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._06._20_Hw
{

    class Program
    {


        static void PrintGame(Game g)
        {
            Console.WriteLine(g);
            int number = g.TellMeHowManyPlayers();
            Console.WriteLine(number);
        
        }
        static void Main(string[] args)
        {
            Game Damka = new Game()
            {
                _name = "Backgammon",
                _numberOfPlayers = 2,
                _originCountry = "China",
                _rating = 3.5f


            };

            Game Ball = new Game("Basketball", 5.5f)
            {
                _numberOfPlayers = 10,
                _originCountry = "USA"
            };

            Game Ball2 = new Game("Soccer", 22, 5.5f, "England");

            Game T = new Game("GameBoy", "Japan")
            {
                _numberOfPlayers = 1,
                _rating = 4.1f
            };


            PrintGame(Ball);
            // Home Work answers:
            // * the command in IL is "newobj"
            // * yes because its static function which we know that has to be the letter 's' next to it 
            //* call , callvirt
            //* I think thats happen because cw is simpler function that dosen't need to called in a specefied way 
            //  and "TellMeHowManyPlayers()" probbly needed to be call in a more specefied way. 
                                            

                
        }
    }
}
