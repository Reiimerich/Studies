using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.Course
{
    public class FollowPlayer : MonoBehaviour
    {
        public GameObject player;
        private Vector3 cameraOffset = new Vector3(0, 5, -7);

        private void LateUpdate()
        {
            transform.position = player.transform.position + cameraOffset;
        }
    }
}
