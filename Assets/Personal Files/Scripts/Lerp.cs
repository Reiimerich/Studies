using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerp : MonoBehaviour
{
    [SerializeField] private Vector3 goalPosition;
    [SerializeField] private float time;

    private float initialPosition, finalPosition;

    void Start()
    {
        var myValue = Mathf.Lerp(0, 10, 0.5f);
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0)) finalPosition = finalPosition == 0 ? 1 : 0;

        initialPosition = Mathf.MoveTowards(initialPosition, finalPosition, time);

        transform.position = Vector3.Lerp(Vector3.zero, goalPosition, initialPosition);
    }
}
