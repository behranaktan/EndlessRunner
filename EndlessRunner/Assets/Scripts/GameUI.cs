using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour
{
    [SerializeField] private GameObject backGround;
    [SerializeField] private GameObject gameNameText;
    [SerializeField] private GameObject gameOverText;
    [SerializeField] private TextMeshProUGUI pointText;
    private int coin = 0;
    [SerializeField] private GameObject tryAgainButton;


    private void Start()
    {
        gameOverText.SetActive(false);
        backGround.SetActive(false);
        gameNameText.SetActive(false);
        tryAgainButton.SetActive(false);
        pointText.text = "Coins: " + coin.ToString();
    }

    public void StartGame()
    {
        backGround.SetActive(true); 
        gameNameText.SetActive(true);
        tryAgainButton.SetActive(true);
        
    }

    public void GameOver()
    {
        gameOverText.SetActive(true);
        backGround.SetActive(true);
        gameNameText.SetActive(true);
        tryAgainButton.SetActive(true);

    }
    
    
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            coin++;
            pointText.text = "Coins: " + coin.ToString();
        }
    }
    
}
