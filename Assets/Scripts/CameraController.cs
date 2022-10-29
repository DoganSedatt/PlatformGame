using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public Vector3 ofset;
    float smootSpeed = 0.50f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 desiredPos=target.position + ofset;//
        Vector3 smootPos = Vector3.Lerp(transform.position, desiredPos, smootSpeed);
        this.transform.position = smootPos;
       
    }
}
