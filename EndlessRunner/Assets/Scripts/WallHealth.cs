using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WallHealth : MonoBehaviour
{
    
    public int wallHealth = 50;
    public TextMeshProUGUI healthText;

    private void Update()
    {
        if (wallHealth == 0)
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        healthText.text = "" + wallHealth;
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {

            wallHealth--;
            healthText.text =""+ wallHealth;
        }
    }
}
