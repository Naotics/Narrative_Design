using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeLine2NextScene : MonoBehaviour
{
    public int timer = 0;

    void FixedUpdate()
    {
        timer = timer + 1;

        if (timer == 1250)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
