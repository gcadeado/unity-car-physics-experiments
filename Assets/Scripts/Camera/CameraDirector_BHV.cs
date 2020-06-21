using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDirector_BHV : MonoBehaviour {

    [SerializeField]
    private CameraMan_BHV[] cameras;

    [SerializeField]
    private string start;

    private void Awake()
    {
        ActivateByName(start);
    }

    public void ActivateByName(string cameraName)
    {
        bool found = false;
        if (name == null || name.Length == 0)
        {
            Debug.Log("[CameraDirector_BHV] String name must exists");
            return;
        }
        else
        {
            for (int i = 0; i < cameras.Length; i++)
            {
                if (cameras[i].cameraName.Equals(cameraName))
                {
                    cameras[i].Activate();
                    found = true;
                }
            }
            if (found)
            {
                for (int i = 0; i < cameras.Length; i++)
                {
                    if (!cameras[i].cameraName.Equals(cameraName))
                    {
                        cameras[i].Deactivate();
                    }
                }
            }
            return;
        }
    }
}
