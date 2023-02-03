using UnityEngine;
using UnityEngine.SceneManagement;

public class BatTrigger : MonoBehaviour
{

    void OnCollisionEnter(UnityEngine.Collision collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Batcutscene");
        }
    }
}
