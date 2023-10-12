using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float _speed = 5;
    public float _leftrightspeed = 5; 
    void Update()
    {
        transform.Translate(Vector3.forward*Time.deltaTime*_speed,Space.World);
        if (Input.GetKey(KeyCode.A)||Input.GetKey(KeyCode.LeftArrow))
        {
            if (gameObject.transform.position.x > LevelBoundary._leftside)
            {
                transform.Translate(Vector3.left*Time.deltaTime*_leftrightspeed);
            }
        }
        if (Input.GetKey(KeyCode.D)||Input.GetKey(KeyCode.RightArrow))
        {
            if (gameObject.transform.position.x < LevelBoundary._rightside)
            {
                transform.Translate(Vector3.left*Time.deltaTime*_leftrightspeed*-1);
            }
        }
    }
}
