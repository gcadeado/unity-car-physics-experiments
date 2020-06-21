using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace CarPhysicsExperiments
{
    [RequireComponent(typeof(CarController))]
    public class CarUserControl : MonoBehaviour
    {
        public Transform spawnPoint;
        private CarController m_Car;

        private Rigidbody m_Rb;

        private void Awake()
        {
            m_Car = GetComponent<CarController>();
            m_Rb = GetComponent<Rigidbody>();
        }


        private void FixedUpdate()
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxisRaw("Vertical");

            float handbrake = Input.GetAxis("Jump");

            if (Input.GetKeyUp(KeyCode.Backspace))
            {
                Debug.Log("Reset car");
                gameObject.transform.position = spawnPoint.position;
                gameObject.transform.rotation = spawnPoint.rotation;
                m_Rb.rotation = spawnPoint.rotation;
                m_Rb.velocity = new Vector3(0.0f, 0.0f, 0.0f);
            }
            else if (Input.GetKeyUp(KeyCode.R))
            {
                Debug.Log("Reset scene");
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
            else
            {

                m_Car.Move(h, v, v, handbrake);
            }

        }
    }
}

