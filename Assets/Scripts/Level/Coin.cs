using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private GameManager gameManager;
    public int coinScoreValue;//Mevcut coin objesinin score'a katacaðý deðer.
    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
    }
    void FixedUpdate()
    {
        transform.Rotate(0,0,180f*Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            Destroy(this.gameObject);
            gameManager.ScoreUp(coinScoreValue);
        }
    }
}
