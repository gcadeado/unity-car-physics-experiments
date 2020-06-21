using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class CameraFollow_BHV : MonoBehaviour
{
    public Transform target;
    public float distanceFromTarget = 3.0f;

    public float distanceToLookForward = 20.0f;
    public float height = 3.0f;
    public float damping = 5.0f;
    public bool smoothRotation = true;
    private bool followBehind = true;
    public float rotationDamping = 10.0f;

    void FixedUpdate()
    {
        Vector3 wantedPosition;
        if (followBehind)
        {
            wantedPosition = target.TransformPoint(0, height, -distanceFromTarget);
        }
        else
            wantedPosition = target.TransformPoint(0, height, distanceFromTarget);

        transform.position = Vector3.Lerp(transform.position, wantedPosition, Time.fixedDeltaTime * damping);

        if (smoothRotation)
        {
            Vector3 whereToLookAt = target.position + (target.forward * distanceToLookForward);
            Quaternion wantedRotation = Quaternion.LookRotation(whereToLookAt - transform.position, target.up);
            transform.rotation = Quaternion.Slerp(transform.rotation, wantedRotation, Time.fixedDeltaTime * rotationDamping);
        }
        else transform.LookAt(target, target.up);
    }
}
