using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    private float lastzpos=100f;  //Keeping track of position
    private float spawninterval = 20f; 
    public GameObject enemy;  //Enemy prefab
    ObstaclePooler obstaclePooler; //Obstacle pool

    void Start()
    {
        obstaclePooler = ObstaclePooler.instance; // Getting the singleton instances of the pools
        StartCoroutine(spawnobstacles()); //Starts instantiation of obstacles and enemies
    }

    public IEnumerator spawnobstacles()
    {
            lastzpos += spawninterval;
            obstaclePooler.SpawnFromPool(Random.Range(1,10),new Vector3(-4.5f,1.5f,lastzpos),Quaternion.identity); //Spawning an obstacle prefab from the pools
            if(Random.Range(0,2)==1) //To have a 50 percent chance to instantiate an enemy during each spawning process
            {
                obstaclePooler.SpawnFromPool(11,new Vector3(Random.Range(-4.5f,4.5f),0.5f,lastzpos + Random.Range(0f,11f)),Quaternion.identity); //Tag 11 is enemy in the pool
            }
            yield return new WaitForSeconds(1.5f); //Waits 1.5 seconds after spawning
            StartCoroutine(spawnobstacles());//Recursive call to continue spawning
    }

}
