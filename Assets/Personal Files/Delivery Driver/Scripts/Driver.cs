using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Driver
{
    public class Driver : MonoBehaviour
    {
        [SerializeField] private float rotateSpeed = 0.1f;
        [SerializeField] private float moveSpeed = 0.01f;
        void Update()
        {
            //Rotate the player in Z to change direction
            transform.Rotate(0, 0, rotateSpeed);

            //Move the player forward in the Y axis.
            transform.Translate(0, moveSpeed, 0);
        }
    }
}

