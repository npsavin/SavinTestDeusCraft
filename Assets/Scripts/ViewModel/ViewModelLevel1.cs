using Assets.Scripts.Model;

namespace Assets.Scripts.ViewModel
{
    class ViewModelLevel1:ViewModelLevel
    {
        private int CountOfPlayerLives = 3;
        private  int CountOfElements = 26;
        private int Scope = 0;
        private  int CountOfLevel = 1;

        public ViewModelLevel1()
        {
            VMLevel = new Level(CountOfPlayerLives, CountOfElements, Scope, CountOfLevel);
        }

        

        

        
    }
}
