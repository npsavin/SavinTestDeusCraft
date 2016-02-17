using Assets.Scripts.Model;

namespace Assets.Scripts.ViewModel
{
    class ViewModelLevel3 : ViewModelLevel
    {
        private int CountOfPlayerLives = 3;
        private int CountOfElements = 60;
        private int Scope = 0;
        private int CountOfLevel = 3;

        public ViewModelLevel3()
        {
            VMLevel = new Level(CountOfPlayerLives, CountOfElements, Scope, CountOfLevel);
        }
    }
}
