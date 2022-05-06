using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AreaOfCircle : MonoBehaviour
{

    int radius;
    float area;
    // Start is called before the first frame update
    void Start()
    {
        radius = 0;
        area = (float)Mathf.PI * radius * radius;
        Debug.Log("Radius: " + radius +", Area: " + area);

        radius = 1;
        area = (float)Mathf.PI * radius * radius;
        Debug.Log("Radius: " + radius +", Area: " + area);

        // circle with radius 2
        radius = 2;
        area = (float)Mathf.PI * radius * radius;
        Debug.Log("Radius: " + radius +", Area: " + area);

        // circle with radius 3
        radius = 3;
        area = (float)Mathf.PI * radius * radius;
        Debug.Log ("Radius: " + radius + ", Area: " + area);

        // circle with radius 4
        radius = 4;
        area = (float)Mathf.PI * radius * radius;
       Debug.Log("Radius: " + radius +", Area: " + area);


       // circle with radius 5
        radius = 5;
        area = (float)Mathf.PI * radius * radius;
        Debug.Log("Radius: " + radius +  ", Area: " + area);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
