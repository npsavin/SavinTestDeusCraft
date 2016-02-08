using UnityEngine;
using System.Collections;

public class BricksControl : MonoBehaviour
{

    public GameObject brickParticle;
    
    void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
    }
}