using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;


public class LevelGenerator : MonoBehaviour
{
    public ObjectPool objectPool;
    public float generationInterval = 2f;
    public float spawnDistance = 100f;
    public float levelDespawnTime = 20f; // Seviyenin kaybolma süresi (örnek: 5 saniye)
    private float lastSpawnPositionZ = 0f;
    private GameObject lastSpawnedSection;

    private void Start()
    {
        objectPool.Initialize(5);
        StartCoroutine(GenerateSections());
    }

    IEnumerator GenerateSections()
    {
        while (true)
        {
            yield return new WaitForSeconds(generationInterval);

            // Geçmişte bırakılan seviyeyi devre dışı bırak
            if (lastSpawnedSection != null)
            {
                StartCoroutine(DespawnSection(lastSpawnedSection));
            }

            GameObject section = objectPool.GetObject(); // Havuzdan bir nesne al
            if (section != null)
            {
                section.transform.position = new Vector3(0, 0, lastSpawnPositionZ + spawnDistance);
                lastSpawnPositionZ += spawnDistance; // Son spawn pozisyonunu güncelle
                lastSpawnedSection = section; // Son spawn edilen seviyeyi kaydet
            }
        } 
    }

    IEnumerator DespawnSection(GameObject section)
    {
        yield return new WaitForSeconds(levelDespawnTime);
        section.SetActive(false); // Seviyeyi devre dışı bırak
    }
}

