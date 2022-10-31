using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    Rigidbody rb;
    float pushForce = 200f;
    public float horizontalMoveSpeed;
    public Vector3 startPos;
    private GameManager gameManager;//GameManager scriptine eri�mek i�in de�i�ken
    void Start()
    {
        startPos = this.transform.position;
        rb = GetComponent<Rigidbody>();
        gameManager = FindObjectOfType<GameManager>();//GameManager objesini bul ve de�i�kene at
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontalMove = Input.GetAxis("Horizontal");//Yatay hareket girdisi
        float verticalMove = Input.GetAxis("Vertical");
        //transform.Translate(new Vector3(0, 0, verticalMove*horizontalMoveSpeed* Time.fixedDeltaTime));
        rb.AddForce(0, 0, pushForce * Time.fixedDeltaTime);//Pozisyonuna g�� uygular.�leri itme
        rb.velocity = new Vector3(horizontalMove*horizontalMoveSpeed, rb.velocity.y,rb.velocity.z);//Sa�a sola hareket
        //rb.AddTorque(0, 0, -(horizontalMove * horizontalMoveSpeed));
        //rb.AddTorque(1, 0, 0, ForceMode.Impulse);//Rotasyonuna g�� uygular
    }
    private void OnCollisionEnter(Collision collision)
    {
        //Bariyere �arp�nca karakter ba�a d�ns�n.StartPos
        if (collision.collider.CompareTag("barier"))
        {
            gameManager.RespwanPlayer();//Bariyere �arp�nca gameManagerin respawnPlayer metodunu �a��r.
            //O metod i�inde de 2 saniye gecikmeli start pozisyonunda tekrar do�u� ger�ekle�iyor
        }
        
    }
}
