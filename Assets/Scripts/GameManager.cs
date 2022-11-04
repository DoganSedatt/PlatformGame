using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class GameManager : MonoBehaviour
{
    
    private BallController ballController;//BallController scriptine eriþmek için deðiþken 
    int currentScore;
    public TextMeshProUGUI scoreText;
    void Start()
    {
        ballController = FindObjectOfType<BallController>();
    }

    public void RespwanPlayer()
    {
        StartCoroutine("RespawnCoroutine");
    }
    public IEnumerator RespawnCoroutine()
    {
        ballController.gameObject.SetActive(false);//ballController scriptini durdur.
        yield return new WaitForSeconds(2f);//2 saniye bekle
        ballController.transform.position = ballController.startPos;//Ve ballcontroller startpos deðerini topun yeniden doðuþ pozisyonuna at.
        ballController.gameObject.SetActive(true);//Daha sonra ballController scriptini aktif et.
        //Burada deaktif ve aktif etme durumu topun hareketini durdurmak ve baþlatmak için yapýlýyor.
    }
    public void ScoreUp(int scoreValue)
    {
        currentScore += scoreValue;
        scoreText.text = currentScore.ToString();
    }
}
