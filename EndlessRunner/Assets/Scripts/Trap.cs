using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Trap : MonoBehaviour
{
    public bool boolDead = false;
    GameUI gameUI;
    
    private void Start()
    {
        gameUI = GameObject.FindObjectOfType<GameUI>();
    }

    private void FixedUpdate()
    {
        if (boolDead == true)
        {
            Destroy(gameObject);
            gameUI.GameOver();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Trap") || other.CompareTag("Wall"))
        {
            if (boolDead == false)
            {
                
                boolDead = true;
            }
        }
    }

}

