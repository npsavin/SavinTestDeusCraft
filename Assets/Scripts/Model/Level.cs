using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Model
{
    class Level
    {
        public int CountOfPlayerLives { get; set; }
        public int CountOfElements { get; set; }
        public int Scope { get; set; }
        public int CountOfLevel { get; set; }
        public int CountOfElement { get; set; }

        public Level(int countOfPlayerLives, int countOfElements, int countOfElement, int scope, int coutOfLevel )
        {
            CountOfPlayerLives = countOfPlayerLives;
            CountOfElements = countOfElements;
            Scope = scope;
            CountOfLevel = coutOfLevel;
            CountOfElement = countOfElement;
        }
    }
}
