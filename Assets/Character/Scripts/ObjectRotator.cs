using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotator : MonoBehaviour
{
    public float rotSpeed = 0.5f; 
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
          transform.Rotate(rotSpeed * Time.deltaTime, 0,0) ; 
    }
}
