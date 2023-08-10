using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStuff : MonoBehaviour
{
    public float bulletSpeed = 10f;
    Vector3 moveDirection = new Vector3(0, 10, 0);

    private void FixedUpdate()
    {
        transform.position += moveDirection * Time.fixedDeltaTime;
    }
}
