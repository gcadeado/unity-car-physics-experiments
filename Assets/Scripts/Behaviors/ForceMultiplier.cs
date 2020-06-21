using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceMultiplier : MonoBehaviour
{

    public float multiplier = 1.0f;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision collision)
    {
        // Simple force to add some exaggeration to colisions
        // TODO make collisions more epic :)
        rb.AddForce((collision.relativeVelocity + Vector3.up) * multiplier);
    }

}
