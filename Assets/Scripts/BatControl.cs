using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    public class BatControl : MonoBehaviour {
        public float PlayerVelocity;
        private Vector3 _playerPosition;
        private float _mousePosition;

        
        void Start () {
            _playerPosition = gameObject.transform.position;
            _mousePosition = Input.mousePosition.x;


        }
	
        
        void Update () {
            

            _playerPosition.z += ChangePosition(Input.mousePosition.x) * PlayerVelocity;
            
            _mousePosition = Input.mousePosition.x;

           
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                SceneManager.LoadScene("Menu");
            }

            
            _playerPosition = new Vector3(1f, 0.62f, Mathf.Clamp(_playerPosition.z, 4.13f, 14.453f));
            transform.position = _playerPosition;
        }

        private float ChangePosition(float x)
        {
            if (_mousePosition < x)
            {
                return -x/_mousePosition;
            }
            if(_mousePosition > x)
            {
                return x / _mousePosition;
            }
            return 0;
        }
    }
}
