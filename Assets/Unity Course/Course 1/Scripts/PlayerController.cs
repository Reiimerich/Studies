using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.Course
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float vehicleSpeed = 20.0f;
        [SerializeField] private float turnSpeed;

        private float horizontalInput;
        private float verticalInput;

        private void Update()
        {
            horizontalInput = Input.GetAxis("Horizontal");
            verticalInput = Input.GetAxis("Vertical");

            //Move the Vehicle Forward based on vertical Input
            transform.Translate(Vector3.forward * Time.deltaTime * vehicleSpeed * verticalInput);
            //Rotates the vehicle based on Horizontal Input
            transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        }
    }
}

