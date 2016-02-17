using Assets.Scripts.Model;

namespace Assets.Scripts.ViewModel
{
    class ViewModelLevel2:ViewModelLevel
    {
        private int CountOfPlayerLives = 3;
        private  int CountOfElements = 46;
        private int Scope = 0;
        private  int CountOfLevel = 2;

        public ViewModelLevel2()
        {
            VMLevel = new Level(CountOfPlayerLives, CountOfElements, Scope, CountOfLevel);
        }
    }
}
