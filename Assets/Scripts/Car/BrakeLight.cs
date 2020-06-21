using System;
using UnityEngine;

namespace CarPhysicsExperiments
{
    public class BrakeLight : MonoBehaviour
    {
        public CarController car; // reference to the car controller, must be dragged in inspector

        private Light m_Light;


        private void Start()
        {
            m_Light = GetComponent<Light>();
        }


        private void FixedUpdate()
        {
            // enable the Renderer when the car is braking, disable it otherwise.
            m_Light.enabled = car.BrakeInput > 0f;
        }
    }
}
