using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireController : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint;
    public float bulletForce = 15f;
    public AudioSource throwSound;
    public float fireRate = 5f;
    public float fireRateOne = 10f;
    public float fireRateTwo = 20f;
    public int bulletDamage = 1;
    private float nextFireTime = 0f;
    private float currentFireRate;

    private void Start()
    {
        currentFireRate = fireRate;
    }

    private void Update()
    {
        if (Time.time >= nextFireTime)
        {
            ThrowBullet();
            nextFireTime = Time.time + 1f / currentFireRate;
        }
    }

    private void ThrowBullet()
    {
        GameObject newBullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);

        Rigidbody bulletRb = newBullet.GetComponent<Rigidbody>();

        bulletRb.AddForce(bulletSpawnPoint.forward * bulletForce, ForceMode.Impulse);
        
        throwSound.Play();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SpeedOne"))
        {
            currentFireRate = fireRateOne;
            Debug.Log("deneme1");
        }
        else if (other.CompareTag("SpeedTwo"))
        {
            currentFireRate = fireRateTwo;
        }
    }
}




