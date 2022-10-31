using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    Rigidbody rb;
    float pushForce = 200f;
    public float horizontalMoveSpeed;
    public Vector3 startPos;
    private GameManager gameManager;//GameManager scriptine eriþmek için deðiþken
    void Start()
    {
        startPos = this.transform.position;
        rb = GetComponent<Rigidbody>();
        gameManager = FindObjectOfType<GameManager>();//GameManager objesini bul ve deðiþkene at
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
    private void OnCollisionEnter(Collision collision)
    {
        //Bariyere çarpýnca karakter baþa dönsün.StartPos
        if (collision.collider.CompareTag("barier"))
        {
            gameManager.RespwanPlayer();//Bariyere çarpýnca gameManagerin respawnPlayer metodunu çaðýr.
            //O metod içinde de 2 saniye gecikmeli start pozisyonunda tekrar doðuþ gerçekleþiyor
        }
        
    }
}
