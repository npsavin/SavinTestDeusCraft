using System.Text;
using Assets.Scripts.Model;
using Assets.Scripts.ViewModel;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class GM : MonoBehaviour
    {
        private ViewModelLevel VM;
      
        public AudioClip PointSound;
        public AudioClip LifeSound;
        private int _level;
        
        public static GM Instance { get; private set; }

        public void Awake()
        {
            Instance = this;
        }
        void OnGUI()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Live's: ");
            sb.Append(VM.VMLevel.CountOfPlayerLives);
            sb.Append(" Scope:");
            sb.Append(VM.VMLevel.Scope);
            sb.Append(" Level:");
            sb.Append(VM.VMLevel.CountOfLevel);
            GUI.Label(new Rect(5.0f, 3.0f, 200.0f, 200.0f), sb.ToString());
        }
       

        void Start()
        {
            _level = SceneManager.sceneCount;
            if (_level == 1)
            {
                VM = new ViewModelLevel1();
            }
            if (_level == 2)
            {
                VM = new ViewModelLevel2();
            }
            if (_level == 3)
            {
                VM = new ViewModelLevel3();
            }


        }
        public void SetCountOfBrick()
        {
            VM.VMLevel.CountOfElements--;
            if (VM.VMLevel.CountOfElements == 0)
            {
                if (_level == 1)
                {
                    SceneManager.LoadScene("Level2");
                }
                if (_level == 2)
                {
                    SceneManager.LoadScene("Level3");
                }
            
            }
        }

        public void SetCountOfScope(int scope)
        {
            VM.VMLevel.Scope += scope;
            GetComponent<AudioSource>().PlayOneShot(PointSound);
        }

        public void SetLives(bool flag)
        {
            if (flag)
            {
                VM.VMLevel.CountOfPlayerLives++;
            }
            else
            {
                VM.VMLevel.CountOfPlayerLives--;
                GetComponent<AudioSource>().PlayOneShot(LifeSound);
                if (VM.VMLevel.CountOfPlayerLives == 0)
                {
                    SceneManager.LoadScene("Menu");
                }
            }
            
        }
    }
}
