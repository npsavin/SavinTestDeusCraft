using UnityEngine;

namespace Assets.Scripts
{
    public class BallControl : MonoBehaviour
    {


        private bool _ballIsActive;
        //private Vector3 _ballPosition;
        private Vector3 _ballInitialForce;

        // GameObject
        public GameObject PlayerObject;
        private Rigidbody _rb;

        // используйте этот метод для инициализации
        private void Start()
        {

            _rb = GetComponent<Rigidbody>();
            // создаем силу
            _ballInitialForce = new Vector3(600.0f, 0, 0);

            // переводим в неактивное состояние
            _ballIsActive = false;

            // запоминаем положение
           // _ballPosition = transform.position;
        }

        private void Update()
        {
            // проверка нажатия на пробел
            if (Input.GetButtonDown("Jump"))
            {
                // проверка состояния
                if (!_ballIsActive)
                {
                    // сброс всех сил
                    _rb.isKinematic = false;
                    _rb.AddForce(_ballInitialForce);
                    // зададим активное состояние
                    _ballIsActive = true;
                }

                //if (!_ballIsActive && PlayerObject != null)
                //{
                //    // задаем новую позицию шарика
                //    _ballPosition.x = PlayerObject.transform.position.x;

                //    // устанавливаем позицию шара
                //    transform.position = _ballPosition;
                //}
                
              
            }
        }
    }
}
