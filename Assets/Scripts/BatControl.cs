using UnityEngine;

namespace Assets.Scripts
{
    public class BatControl : MonoBehaviour {
        public float PlayerVelocity;
        private Vector3 _playerPosition;
        private Vector2 _mousePosition;

        // Use this for initialization
        void Start () {
            _playerPosition = gameObject.transform.position;
            _mousePosition = Input.mousePosition;


        }
	
        // Update is called once per frame
        void Update () {
            // горизонтальное движение

            _playerPosition.z += ChangePosition(Input.mousePosition) * PlayerVelocity;
            _mousePosition = Input.mousePosition;

            // выход из игры
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }

            // обновим позицию платформы
            transform.position = _playerPosition;
        }

        private int ChangePosition(Vector2 position)
        {
            if (_mousePosition.x < position.x)
            {
                return -1;
            }
            if(_mousePosition.x > position.x)
            {
                return 1;
            }
            return 0;
        }
    }
}
