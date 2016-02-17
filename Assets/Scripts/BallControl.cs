using UnityEngine;

namespace Assets.Scripts
{
    public class BallControl : MonoBehaviour
    {


        public float BallInitialVelocity = 600f;


        private Rigidbody _rb;
        private bool _ballInPlay;
        private Transform _transformParent;
        public AudioClip HitSound;

        private void Start()
        {
            _transformParent = transform.parent;
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
        void OnCollisionEnter(Collision col)
        {
            if (col.gameObject.name == "KillField")
            {

                _ballInPlay = false;
                GM.Instance.SetLives(false);
                transform.parent = _transformParent;
                _rb.isKinematic = true;
                transform.position = GameObject.Find("StartPostion").transform.position;
            }
            else if(_ballInPlay)
            {
                GetComponent<AudioSource>().PlayOneShot(HitSound);
            }
            




        }
    }
}

