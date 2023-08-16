using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Driver
{
    public class Collision : MonoBehaviour
    {
        private void OnCollisionEnter2D(Collision2D collision)
        {
            Debug.Log("You collided with " + collision.transform.name);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            Debug.Log("You passed " + collision.transform.name);
        }
    }
}

