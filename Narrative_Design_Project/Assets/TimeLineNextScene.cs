using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeLineNextScene : MonoBehaviour
{
    public int timer = 0;

    // Update is called once per frame
    void FixedUpdate()
    {
        timer = timer + 1;



        if (timer == 630)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
