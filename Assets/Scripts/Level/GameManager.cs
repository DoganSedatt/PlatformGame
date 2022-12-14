using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    private BallController ballController;//BallController scriptine eri?mek i?in de?i?ken 
    int currentScore;
    public TextMeshProUGUI scoreText;
    
    public GameObject levelAnimPanel;
    public Animator levelAnim;
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
        SceneManager.LoadScene("SampleScene");//Sahneyi yeniden y?kl?yor 
        //ballController.transform.position = ballController.startPos;//Ve ballcontroller startpos de?erini topun yeniden do?u? pozisyonuna at.
        //ballController.gameObject.SetActive(true);//Daha sonra ballController scriptini aktif et.
        //Burada deaktif ve aktif etme durumu topun hareketini durdurmak ve ba?latmak i?in yap?l?yor.
    }
    public void ScoreUp(int scoreValue)
    {
        currentScore += scoreValue;
        scoreText.text = currentScore.ToString();
    }
    public void LevelAnim() {
        levelAnimPanel.SetActive(true);
       
        levelAnim.Play("LevelAnim");
    }

}
