namespace Assets.Scripts.Model
{
    public class Level
    {
        public int CountOfPlayerLives { get; set; }
        public int CountOfElements { get; set; }
        public int Scope { get; set; }
        public int CountOfLevel { get; set; }
        

        public Level(int countOfPlayerLives, int countOfElements,  int scope, int coutOfLevel  )
        {
            CountOfPlayerLives = countOfPlayerLives;
            CountOfElements = countOfElements;
            Scope = scope;
            CountOfLevel = coutOfLevel;
            
        }
    }
}
