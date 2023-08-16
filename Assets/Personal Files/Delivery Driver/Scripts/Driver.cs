using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Driver
{
    public class Driver : MonoBehaviour
    {
        [SerializeField] private float rotateSpeed = 0.1f;
        [SerializeField] private float moveSpeed = 0.01f;

        private void Update()
        {
            MovePlayer();
        }

        private void MovePlayer()
        {
            //Rotate the player in Z to change direction
            float steerAmount = Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime;
            transform.Rotate(0, 0, -steerAmount);

            //Move the player forward in the Y axis
            float speedAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
            transform.Translate(0, speedAmount, 0);

        }
    }
}

