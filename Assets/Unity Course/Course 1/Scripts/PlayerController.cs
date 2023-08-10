using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.Course
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float vehicleSpeed = 20.0f;

        private void Update()
        {
            //Move the Vehicle Forward
            transform.Translate(Vector3.forward * Time.deltaTime * vehicleSpeed);
        }
    }
}

