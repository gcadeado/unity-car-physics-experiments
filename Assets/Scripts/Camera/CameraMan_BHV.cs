using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMan_BHV : MonoBehaviour {

    //public GameObject target;

    // Update is called once per frame
    //void Update () {
    //Aways look at target
    //transform.LookAt(target.transform.position, Vector3.up);
    //}

    //[SerializeField]
    public string cameraName;

    public void Activate()
    {
        this.enabled = true;
        this.GetComponent<Camera>().enabled = true;
        this.GetComponent<AudioListener>().enabled = true;
    }

    public void Deactivate()
    {
        this.enabled = false;
        this.GetComponent<Camera>().enabled = false;
        this.GetComponent<AudioListener>().enabled = false;
    }
}
