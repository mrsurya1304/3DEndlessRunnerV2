using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    RoadSpawner rs;
    ObstacleSpawner os;
    void Start()
    {
        rs = GetComponent<RoadSpawner>();
        os = GetComponent<ObstacleSpawner>();
        os.spawnobstacles(); //To spawn obstacles
    }

    //Method executed when we enter the trigger created at the end of the road
    public void SpawnTriggerEntered()
    {
        rs.moveroad();  //To move road
    }
}
