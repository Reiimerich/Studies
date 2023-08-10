using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    private Color startColor;
    private Color endColor;
    private Material material;
    private float time = 5.0f;

    private void Awake()
    {
        startColor = Random.ColorHSV();
        endColor = Random.ColorHSV();
    }

    void Start()
    {
        transform.position = new Vector3(7, 5, 9);
        transform.localScale = Vector3.one * 2.5f;
        
        material = GetComponent<Renderer>().material;
        material.color = startColor;
    }
    
    void Update()
    {
        transform.Rotate(0.0f, 13.5f * Time.deltaTime, 0.0f);
        ChangeColor();
    }

    void ChangeColor()
    {
        material.color = Color.Lerp(startColor, endColor, time * Time.deltaTime);
    }
}
