using UnityEngine;

namespace Assets.Scripts
{
    public class BricksControl : MonoBehaviour
    {
        private Rigidbody _rb;
        void Start()
        {
            _rb = GetComponent<Rigidbody>();

        }

        void Update()
        {
            _rb.AddForce(0, -10.0f, 0);
        }
        void OnCollisionEnter(Collision col)
        {
        
            if (col.gameObject.name == "Ball")
            {
                
                Destroy(gameObject);
                
            }
        
        }
    }
}