using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollecter : MonoBehaviour
{
    [SerializeField]
    private int coin= 0;
    public TextMeshProUGUI coinText;


    private void Start()
    {
        coinText.text = "Coins: " + coin.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            coin++;
            coinText.text = "Coins: " + coin.ToString();
        }
    }

}
