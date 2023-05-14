/*
ObjectPoolManager.cs
Author: CireWire

Description:
    This script provides object pooling functionality for Unity.
    Objects can be retrieved from the pool and returned for reuse.

*/

using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolManager : MonoBehaviour
{
    public static ObjectPoolManager Instance { get; private set; }

    public GameObject prefab;
    public int poolSize = 10;

    private List<GameObject> pooledObjects = new List<GameObject>();

    private void Awake()
    {
        // Singleton pattern to ensure only one instance of this ObjectPoolManager exists
        Instance = this;
    }

    private void Start()
    {
        // Instantiate the initial pool of objects
        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(prefab);
            obj.SetActive(false);
            pooledObjects.Add(obj);
        }
    }

    public GameObject GetPooledObject()
    {
        // Find the first inactive object in the pool and return it
        foreach (GameObject obj in pooledObjects)
        {
            if (!obj.activeInHierarchy)
            {
                obj.SetActive(true);
                return obj;
            }
        }

        // If no inactive object was found, create a new one and add it to the pool
        GameObject newObj = Instantiate(prefab);
        newObj.SetActive(true);
        pooledObjects.Add(newObj);
        return newObj;
    }

    public void ReturnToPool(GameObject obj)
    {
        // Return the object to the pool
        obj.SetActive(false);
    }
}