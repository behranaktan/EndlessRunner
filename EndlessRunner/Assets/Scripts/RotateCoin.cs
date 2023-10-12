using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCoin : MonoBehaviour
{
    public float rotateSpeed = 100f;


    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(Vector3.up , rotateSpeed * Time.deltaTime);
    }
}
