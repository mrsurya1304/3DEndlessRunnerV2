using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    public void reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //To play again
    }
}
