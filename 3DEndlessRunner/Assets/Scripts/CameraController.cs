using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform Player2;
    private float yoffset = 2f;      //Camera offset positions
    private float zoffset =-5f;
    // Start is called before the first frame update
    void Start()
    {
        Player2 = GameObject.Find("Player").transform; //Finding the Player instance
    }

    // LateUpdate is called once player has completed its movement for camera to follow
    void LateUpdate()
    {
        transform.position = new Vector3(Player2.position.x,Player2.position.y+yoffset,Player2.position.z+zoffset);
    }
}
