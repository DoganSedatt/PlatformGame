using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(0,0,180f*Time.deltaTime);
    }
}
