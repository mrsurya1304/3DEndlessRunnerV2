using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private GameObject player;
    public Text uiCoins;
    public Text uiDistance;
    private int playercoins = 0;
    private int coinsleft;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
       uiCoins.text = playercoins.ToString()+ "Coins"; //To display coins collected
       int dist = Mathf.RoundToInt(player.transform.position.z)-60;  //To display distance
       uiDistance.text = dist.ToString()+ "m";
    }

    public void CoinsCollected()
    {
        playercoins++; //Increasing coins count when collision with coin
    }
}
