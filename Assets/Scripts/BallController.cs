using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    Rigidbody rb;
    float pushForce = 200f;
    public float horizontalMoveSpeed;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontalMove = Input.GetAxis("Horizontal");//Yatay hareket girdisi
        float verticalMove = Input.GetAxis("Vertical");
        //transform.Translate(new Vector3(0, 0, verticalMove*horizontalMoveSpeed* Time.fixedDeltaTime));
        rb.AddForce(0, 0, pushForce * Time.fixedDeltaTime);//Pozisyonuna güç uygular.Ýleri itme
        rb.velocity = new Vector3(horizontalMove*horizontalMoveSpeed, rb.velocity.y,rb.velocity.z);//Saða sola hareket
        //rb.AddTorque(0, 0, -(horizontalMove * horizontalMoveSpeed));
        //rb.AddTorque(1, 0, 0, ForceMode.Impulse);//Rotasyonuna güç uygular
    }
}
