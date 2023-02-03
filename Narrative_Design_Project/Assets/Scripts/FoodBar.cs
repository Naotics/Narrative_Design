using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FoodBar : MonoBehaviour
{
    //the food ammount 
    public float food;


    [SerializeField] int foodDicreaseTime;
    [SerializeField] int foodDicreaseAmount;
    private void Start()
    {
        //start the food draine
        StartCoroutine(FoodDraine());
    }


    void Update()
    {
        //check for input
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;
            //Raycast
            if (Physics.Raycast(ray, out hit))
            {
                //compare for the right tag
                if (hit.collider.CompareTag("Food"))
                {
                    //make sure food isn't above 100
                    if (food <= 100)
                    {
                        //increase food and destroy the food game object
                        food += 10;
                        Destroy(hit.collider.gameObject);
                    }
                }
            }
        }
        if (food <= 0)
        {
            //SWITCH TO END SCENE
            SceneManager.LoadScene("MainMenu");
        }
    }

    // Remove food from food bar
    IEnumerator FoodDraine()
    {
        while (true)
        {
            food -= foodDicreaseAmount;
            yield return new WaitForSeconds(foodDicreaseTime);
        }
    }
}



