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
        foreach (ContactPoint contact in collision.contacts)
        {
            Debug.DrawRay(contact.point, contact.normal, Color.white);
        }
        rb.AddForce((collision.relativeVelocity + Vector3.up) * multiplier);
    }

}
