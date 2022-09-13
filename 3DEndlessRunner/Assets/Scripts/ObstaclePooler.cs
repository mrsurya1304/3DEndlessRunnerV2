using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclePooler : MonoBehaviour
{
    [System.Serializable]
    public class Pool  //Pool class to store prefabs of obstacles
    {
        public int tag;
        public GameObject prefab;
        public int size;
    }

    public static ObstaclePooler instance;  //Singleton

    private void Awake()
    {
        instance = this;
    }
    
    public List<Pool> pools;  //List to store various pools
    public Dictionary<int, Queue<GameObject>> poolDictionary;  //Dictionary with tag of prefab pool and a queue of that type of prefab

    // Start is called before the first frame update
    void Start()
    {
        poolDictionary = new Dictionary<int, Queue<GameObject>>();

        foreach(Pool pool in pools)  //Instantiating deactivated prefabs initially and putting into the queue
        {
            Queue<GameObject> objectPool = new Queue<GameObject>();
            for(int i=0; i < pool.size; i++)
            {
                GameObject obj = Instantiate(pool.prefab);
                obj.SetActive(false);
                objectPool.Enqueue(obj);
            }
            poolDictionary.Add(pool.tag, objectPool);  //Adding the pool into the dictionary
        }
        
    }

    public GameObject SpawnFromPool(int tag, Vector3 position, Quaternion rotation)  //Method to spawn prefabs from the pool
    {
        GameObject objectToSpawn = poolDictionary[tag].Dequeue();  //Removing deactive prefab from the queue

        if (objectToSpawn != null)
        {
            objectToSpawn.SetActive(true);  //Activating the prefab
            objectToSpawn.transform.position = position;
            objectToSpawn.transform.rotation = rotation;

            poolDictionary[tag].Enqueue(objectToSpawn);  //Putting back the prefab into the queue for reuse

            return objectToSpawn;
        }
        else
            return null;

    }
}
