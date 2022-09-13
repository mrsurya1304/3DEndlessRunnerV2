using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip gameover, coincollect;
    static AudioSource audiosrc;
    void Start()
    {
        coincollect = Resources.Load<AudioClip> ("CoinCollect"); //Loading audioclips from resources folder
        gameover = Resources.Load<AudioClip> ("GameOver");
        audiosrc = GetComponent<AudioSource>();
    }
    public static void playsound(string clip)
    {
        switch(clip)
        {
            case "CoinCollect": //Sound effect for collection of coin
                audiosrc.PlayOneShot(coincollect);
                break;
            case "GameOver":    //Sound effect when game is over
                audiosrc.PlayOneShot(gameover);
                break;
        }
    }
}
