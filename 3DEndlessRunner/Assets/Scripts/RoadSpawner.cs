using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class RoadSpawner : MonoBehaviour
{
    public List<GameObject> roads;
    public float length = 30f; //Length of each road block
    void Start()
    {
        if(roads != null && roads.Count>0)
        {
            roads = roads.OrderBy(r => r.transform.position.z).ToList();   // Sorting the road blocks by their position initially
        }
    }

    //Method to move the road towards the back to the front
    //This way we improve performance as we dont spawn anything new
    public void moveroad()
    {
        GameObject movedroad = roads[0];
        roads.Remove(movedroad);
        float newz = roads[roads.Count-1].transform.position.z + length;  //new z position in the front
        movedroad.transform.position = new Vector3(roads[roads.Count-1].transform.position.x,roads[roads.Count-1].transform.position.y,newz);
        roads.Add(movedroad);
    }
}
