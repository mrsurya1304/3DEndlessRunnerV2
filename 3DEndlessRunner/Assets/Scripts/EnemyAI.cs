using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float movespeed = 8f; //Speed of enemy
    private Rigidbody enemyrb;
    private GameObject player;
    private float reactdistance = 50f;  //Starts to move towards player only when distance is under 50m

    void Start()
    {
        enemyrb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }
    void Update()
    {
        float distance = Vector3.Distance(player.transform.position,transform.position);
        Vector3 lookdirection;

        Vector3 targetpos = new Vector3(player.transform.position.x,player.transform.position.y,player.transform.position.z); //Direction of enemy towards player

        if(distance<= reactdistance) //When distance between enemy and player is below 50
        {
            if(distance>5f)  //When distance is greater than 5m enemy moves in direction of player
                targetpos.z += (distance/2f);
            lookdirection = (targetpos - transform.position).normalized;
            enemyrb.AddForce(lookdirection*movespeed);
        }
        else //When distance is lesser than 5m enemy holds its direction so the player has a chance to react and dodge it
        {
            lookdirection = (targetpos - transform.position).normalized;
            enemyrb.AddForce(lookdirection*movespeed*0.2f);
        }

        if((transform.position.z - player.transform.position.z) < -3f) //When we pass the enemy we deactivate
            gameObject.SetActive(false);
    }
}
