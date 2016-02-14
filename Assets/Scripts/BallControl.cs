using UnityEngine;

namespace Assets.Scripts
{
    public class BallControl : MonoBehaviour
    {


        public float BallInitialVelocity = 600f;


        private Rigidbody _rb;
        private bool _ballInPlay;

        private void Awake()
        {

            _rb = GetComponent<Rigidbody>();

        }

        private void Update()
        {
            if (Input.GetButtonDown("Fire1") && _ballInPlay == false)
            {
                transform.parent = null;
                _ballInPlay = true;
                _rb.isKinematic = false;
                _rb.AddForce(new Vector3(BallInitialVelocity, 0, 0));
            }
        }
    }
}

