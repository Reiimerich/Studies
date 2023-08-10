using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.Course
{
    public class Propeller : MonoBehaviour
    {
        void Update()
        {
            transform.Rotate(Vector3.forward);
        }
    }
}

