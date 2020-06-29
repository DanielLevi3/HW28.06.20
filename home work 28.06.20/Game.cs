using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _28._06._20_Hw
{
   public  class Game
    {
        public string _name;
        public int _numberOfPlayers;
        public float _rating;
        public string _originCountry;



        public Game()
        {
            
           
        }

        public Game(string name, float rating = 5.5f)
        {
            _name = name;
            _rating = rating;
     
        }

        public Game(string name, int numberOfPlayers, float rating, string originCountry)
        {
            _name = name;
            _numberOfPlayers = numberOfPlayers;
            _rating = rating;
            _originCountry = originCountry;
        }

        public Game(string name, string originCountry)
        {
            _name = name;
            _originCountry = originCountry;
        }


        public int TellMeHowManyPlayers()
        {

            return this._numberOfPlayers;

        }

        public override string ToString()
        {
            return $"name: {_name} numberOfPlayers : {_numberOfPlayers} originCountry: {_originCountry} rating : {_rating} ";
        }
    }
}
