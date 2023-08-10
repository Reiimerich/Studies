using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStuff : MonoBehaviour
{
    public float speed = 4.0f;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPosition = transform.position;

        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float movementX = horizontalInput * speed * Time.deltaTime;

        Vector3 newPosition = new Vector3(currentPosition.x + movementX, currentPosition.y, currentPosition.z);

        transform.position = newPosition;
    }
}
