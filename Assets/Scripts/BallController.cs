using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    Rigidbody rb;
    float pushForce = 500f;
    public float horizontalMoveSpeed = 2f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontalMove = Input.GetAxis("Horizontal");//Yatay hareket girdisi    
        rb.AddForce(0, 0, pushForce * Time.fixedDeltaTime);//Pozisyonuna güç uygular
        rb.velocity = new Vector3(horizontalMove*horizontalMoveSpeed, rb.velocity.y,rb.velocity.z);
       
       
        //rb.AddTorque(1, 0, 0, ForceMode.Impulse);//Rotasyonuna güç uygular
    }
}
