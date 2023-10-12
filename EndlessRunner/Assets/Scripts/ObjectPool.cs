using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public GameObject[] objectPrefabs;
    private List<GameObject> pooledObjects = new List<GameObject>();

    public void Initialize(int poolSize)
    {
        for (int i = 0; i < poolSize; i++)
        {
            int randomIndex = Random.Range(0, objectPrefabs.Length);
            GameObject obj = Instantiate(objectPrefabs[randomIndex]);
            obj.SetActive(false);
            pooledObjects.Add(obj);
        }
    }

    public GameObject GetObject()
    {
        foreach (GameObject obj in pooledObjects)
        {
            if (!obj.activeInHierarchy)
            {
                obj.SetActive(true);
                return obj;
            }
        }
        return null;
    }

    public void ReturnObject(GameObject obj)
    {
        obj.SetActive(false);
    }
}
