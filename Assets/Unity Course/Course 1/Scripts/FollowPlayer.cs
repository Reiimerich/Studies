using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.Course
{
    public class FollowPlayer : MonoBehaviour
    {
        public GameObject player;
        private Vector3 cameraOffset = new Vector3(0.0f, 4.75f, -5.5f);

        private void LateUpdate()
        {
            transform.position = player.transform.position + cameraOffset;
        }
    }
}
